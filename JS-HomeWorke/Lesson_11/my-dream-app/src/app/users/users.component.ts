import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  public headline = 'List of users';

  public users = [
    {name: 'Feliks'},
    {name: 'Bob'},
    {name: 'Link'},
    {name: 'Stiv'},
    {name: 'Ivan'}
  ]

  constructor() { }

  ngOnInit() {
  }

  public removeUser(name : string){
    return this.users = this.users.filter(user => user.name !== name);
  }

  public addUser(name : string){
    if (!name){
      return;
    }
    return this.users.push({name});
  }

}
