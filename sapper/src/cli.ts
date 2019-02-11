import * as fs from 'fs';
import * as path from 'path';
import sade from 'sade';
import colors from 'kleur';
import * as pkg from '../package.json';
import { elapsed, repeat, left_pad, format_milliseconds } from './utils';
import { InvalidEvent, ErrorEvent, FatalEvent, BuildEvent, ReadyEvent } from './interfaces';

const prog = sade('sapper').version(pkg.version);

if (process.argv[2] === 'start') {
	// remove this in a future version
	console.error(colors.bold.red(`'sapper start' has been removed`));
	console.error(`Use 'node [build_dir]' instead`);
	process.exit(1);
}

const start = Date.now();

prog.command('dev')
	.describe('Start a development server')
	.option('-p, --port', 'Specify a port')
	.option('-o, --open', 'Open a browser window')
	.option('--dev-port', 'Specify a port for development server')
	.option('--hot', 'Use hot module replacement (requires webpack)', true)
	.option('--live', 'Reload on changes if not using --hot', true)
	.option('--bundler', 'Specify a bundler (rollup or webpack)')
	.option('--cwd', 'Current working directory', '.')
	.option('--src', 'Source directory', 'src')
	.option('--routes', 'Routes directory', 'src/routes')
	.option('--static', 'Static files directory', 'static')
	.option('--output', 'Sapper output directory', '__sapper__')
	.option('--build-dir', 'Development build directory', '__sapper__/dev')
	.action(async (opts: {
		port: number,
		open: boolean,
		'dev-port': number,
		live: boolean,
		hot: boolean,
		bundler?: 'rollup' | 'webpack',
		cwd: string,
		src: string,
		routes: string,
		static: string,
		output: string,
		'build-dir': string
	}) => {
		const { dev } = await import('./api/dev');

		try {
			const watcher = dev({
				cwd: opts.cwd,
				src: opts.src,
				routes: opts.routes,
				static: opts.static,
				output: opts.output,
				dest: opts['build-dir'],
				port: opts.port,
				'dev-port': opts['dev-port'],
				live: opts.live,
				hot: opts.hot,
				bundler: opts.bundler
			});

			let first = true;

			watcher.on('stdout', data => {
				process.stdout.write(data);
			});

			watcher.on('stderr', data => {
				process.stderr.write(data);
			});

			watcher.on('ready', async (event: ReadyEvent) => {
				if (first) {
					console.log(colors.bold.cyan(`> Listening on http://localhost:${event.port}`));
					if (opts.open) {
						const { exec } = await import('child_process');
						exec(`open http://localhost:${event.port}`);
					}
					first = false;
				}
			});

			watcher.on('invalid', (event: InvalidEvent) => {
				const changed = event.changed.map(filename => path.relative(process.cwd(), filename)).join(', ');
				console.log(`\n${colors.bold.cyan(changed)} changed. rebuilding...`);
			});

			watcher.on('error', (event: ErrorEvent) => {
				console.log(colors.red(`✗ ${event.type}`));
				console.log(colors.red(event.message));
			});

			watcher.on('fatal', (event: FatalEvent) => {
				console.log(colors.bold.red(`> ${event.message}`));
				if (event.log) console.log(event.log);
			});

			watcher.on('build', (event: BuildEvent) => {
				if (event.errors.length) {
					console.log(colors.bold.red(`✗ ${event.type}`));

					event.errors.filter(e => !e.duplicate).forEach(error => {
						if (error.file) console.log(colors.bold(error.file));
						console.log(error.message);
					});

					const hidden = event.errors.filter(e => e.duplicate).length;
					if (hidden > 0) {
						console.log(`${hidden} duplicate ${hidden === 1 ? 'error' : 'errors'} hidden\n`);
					}
				} else if (event.warnings.length) {
					console.log(colors.bold.yellow(`• ${event.type}`));

					event.warnings.filter(e => !e.duplicate).forEach(warning => {
						if (warning.file) console.log(colors.bold(warning.file));
						console.log(warning.message);
					});

					const hidden = event.warnings.filter(e => e.duplicate).length;
					if (hidden > 0) {
						console.log(`${hidden} duplicate ${hidden === 1 ? 'warning' : 'warnings'} hidden\n`);
					}
				} else {
					console.log(`${colors.bold.green(`✔ ${event.type}`)} ${colors.gray(`(${format_milliseconds(event.duration)})`)}`);
				}
			});
		} catch (err) {
			console.log(colors.bold.red(`> ${err.message}`));
			process.exit(1);
		}
	});

prog.command('build [dest]')
	.describe('Create a production-ready version of your app')
	.option('-p, --port', 'Default of process.env.PORT', '3000')
	.option('--bundler', 'Specify a bundler (rollup or webpack, blank for auto)')
	.option('--legacy', 'Create separate legacy build')
	.option('--cwd', 'Current working directory', '.')
	.option('--src', 'Source directory', 'src')
	.option('--routes', 'Routes directory', 'src/routes')
	.option('--output', 'Sapper output directory', '__sapper__')
	.example(`build custom-dir -p 4567`)
	.action(async (dest = '__sapper__/build', opts: {
		port: string,
		legacy: boolean,
		bundler?: 'rollup' | 'webpack',
		cwd: string,
		src: string,
		routes: string,
		output: string
	}) => {
		console.log(`> Building...`);

		try {
			await _build(opts.bundler, opts.legacy, opts.cwd, opts.src, opts.routes, opts.output, dest);

			const launcher = path.resolve(dest, 'index.js');

			fs.writeFileSync(launcher, `
				// generated by sapper build at ${new Date().toISOString()}
				process.env.NODE_ENV = process.env.NODE_ENV || 'production';
				process.env.PORT = process.env.PORT || ${opts.port || 3000};

				console.log('Starting server on port ' + process.env.PORT);
				require('./server/server.js');
			`.replace(/^\t+/gm, '').trim());

			console.error(`\n> Finished in ${elapsed(start)}. Type ${colors.bold.cyan(`node ${dest}`)} to run the app.`);
		} catch (err) {
			console.log(`${colors.bold.red(`> ${err.message}`)}`);
			process.exit(1);
		}
	});

prog.command('export [dest]')
	.describe('Export your app as static files (if possible)')
	.option('--build', '(Re)build app before exporting', true)
	.option('--basepath', 'Specify a base path')
	.option('--timeout', 'Milliseconds to wait for a page (--no-timeout to disable)', 5000)
	.option('--legacy', 'Create separate legacy build')
	.option('--bundler', 'Specify a bundler (rollup or webpack, blank for auto)')
	.option('--cwd', 'Current working directory', '.')
	.option('--src', 'Source directory', 'src')
	.option('--routes', 'Routes directory', 'src/routes')
	.option('--static', 'Static files directory', 'static')
	.option('--output', 'Sapper output directory', '__sapper__')
	.option('--build-dir', 'Intermediate build directory', '__sapper__/build')
	.action(async (dest = '__sapper__/export', opts: {
		build: boolean,
		legacy: boolean,
		bundler?: 'rollup' | 'webpack',
		basepath?: string,
		timeout: number | false,
		cwd: string,
		src: string,
		routes: string,
		static: string,
		output: string,
		'build-dir': string,
	}) => {
		try {
			if (opts.build) {
				console.log(`> Building...`);
				await _build(opts.bundler, opts.legacy, opts.cwd, opts.src, opts.routes, opts.output, opts['build-dir']);
				console.error(`\n> Built in ${elapsed(start)}`);
			}

			const { export: _export } = await import('./api/export');
			const { default: pb } = await import('pretty-bytes');

			await _export({
				cwd: opts.cwd,
				static: opts.static,
				build_dir: opts['build-dir'],
				export_dir: dest,
				basepath: opts.basepath,
				timeout: opts.timeout,

				oninfo: event => {
					console.log(colors.bold.cyan(`> ${event.message}`));
				},

				onfile: event => {
					const size_color = event.size > 150000 ? colors.bold.red : event.size > 50000 ? colors.bold.yellow : colors.bold.gray;
						const size_label = size_color(left_pad(pb(event.size), 10));

						const file_label = event.status === 200
							? event.file
							: colors.bold[event.status >= 400 ? 'red' : 'yellow'](`(${event.status}) ${event.file}`);

						console.log(`${size_label}   ${file_label}`);
				}
			});

			console.error(`\n> Finished in ${elapsed(start)}. Type ${colors.bold.cyan(`npx serve ${dest}`)} to run the app.`);
		} catch (err) {
			console.error(colors.bold.red(`> ${err.message}`));
			process.exit(1);
		}
	});

prog.parse(process.argv);


async function _build(
	bundler: 'rollup' | 'webpack',
	legacy: boolean,
	cwd: string,
	src: string,
	routes: string,
	output: string,
	dest: string
) {
	const { build } = await import('./api/build');

	await build({
		bundler,
		legacy,
		cwd,
		src,
		routes,
		dest,

		oncompile: event => {
			let banner = `built ${event.type}`;
			let c = colors.cyan;

			const { warnings } = event.result;
			if (warnings.length > 0) {
				banner += ` with ${warnings.length} ${warnings.length === 1 ? 'warning' : 'warnings'}`;
				c = colors.yellow;
			}

			console.log();
			console.log(c(`┌─${repeat('─', banner.length)}─┐`));
			console.log(c(`│ ${colors.bold(banner)       } │`));
			console.log(c(`└─${repeat('─', banner.length)}─┘`));

			console.log(event.result.print());
		}
	});
}