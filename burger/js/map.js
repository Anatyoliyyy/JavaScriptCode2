var map;

function initMap() {
    var coord = {
        lat: 38.713382,
        lng: -9.127600
      };

    map = new google.maps.Map(document.getElementById('map__content'), {
        center: coord,
        zoom: 15,
        scrollwheel: false,
        styles: [
            {
                "featureType": "water",
                "elementType": "geometry",
                "stylers": [
                    {
                        "hue": "#71ABC3"
                    },
                    {
                        "saturation": -10
                    },
                    {
                        "lightness": -21
                    },
                    {
                        "visibility": "simplified"
                    }
                ]
            },
            {
                "featureType": "landscape.natural",
                "elementType": "geometry",
                "stylers": [
                    {
                        "hue": "#7DC45C"
                    },
                    {
                        "saturation": 37
                    },
                    {
                        "lightness": -41
                    },
                    {
                        "visibility": "simplified"
                    }
                ]
            },
            {
                "featureType": "landscape.man_made",
                "elementType": "geometry",
                "stylers": [
                    {
                        "hue": "#C3E0B0"
                    },
                    {
                        "saturation": 23
                    },
                    {
                        "lightness": -12
                    },
                    {
                        "visibility": "simplified"
                    }
                ]
            },
            {
                "featureType": "poi",
                "elementType": "all",
                "stylers": [
                    {
                        "hue": "#A19FA0"
                    },
                    {
                        "saturation": -98
                    },
                    {
                        "lightness": -20
                    },
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "geometry",
                "stylers": [
                    {
                        "hue": "#FFFFFF"
                    },
                    {
                        "saturation": -100
                    },
                    {
                        "lightness": 100
                    },
                    {
                        "visibility": "simplified"
                    }
                ]
            }
        ]

    });

    let icons = {
        position: {
            icon: {
                url: './img/icons-svg/map-marker.svg',
                size: new google.maps.Size(60, 60),
                scaledsize: new google.maps.Size(60, 60)
            }
        },
        logo: {
            icon: {
                url: './img/icons-svg/map-marker.svg',
                size: new google.maps.Size(60, 60),
                scaledsize: new google.maps.Size(60, 60)
            }
        }
    };

    let features = [{
            position: new google.maps.LatLng(38.711302,-9.131968),
            type: 'position',
            contentString: 'First',
            content: 'Come to Daddy'
        },
        {
            position: new google.maps.LatLng(38.712730, -9.134259),
            type: 'position',
            contentString: 'Second',
            content: 'Best burgers ever'
        },
        {
            position: new google.maps.LatLng(38.714438, -9.123744),
            type: 'logo',
            contentString: 'Third',
            content: 'We are here'
        }
    ];

    var infowindow = new google.maps.InfoWindow();

    features.forEach(feature => {
        let marker = new google.maps.Marker({
            position: feature.position,
            icon: icons[feature.type].icon,
            map: map,
            title: feature.contentString
        });

        marker.addListener('click', function () {
            infowindow.setContent(feature.content);
            infowindow.open(map, marker);
            marker.setAnimation(google.maps.Animation.BOUNCE);
            setTimeout(function () {
                marker.setAnimation(null)
            }, 1400);

        });
        // marker.addListener('mouseout', function() {
        //   marker.setAnimation(null);
        // } )

    });

}

google.maps.event.addDomListener(window, 'load', initMap);