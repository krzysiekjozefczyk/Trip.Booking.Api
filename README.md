# Trip.Booking.Api
Urls for trips controller actions:<br/>
https://tripsbookingapi.azurewebsites.net/api/trips <br/>
https://tripsbookingapi.azurewebsites.net/api/trips/create<br/>
https://tripsbookingapi.azurewebsites.net/api/trips/update<br/>
https://tripsbookingapi.azurewebsites.net/api/trips/delete<br/>

Example json file for trip request:
```json
[
  {
    "id": 1,
    "name": "Feel the wave",
    "description": "Come with us to Spain for a surfing adventure",
    "startdate": "2018-12-10",
    "travelersamount": 3,
    "country": "Spain"
  }
]
```
Urls for customers controller actions:<br/>
https://tripsbookingapi.azurewebsites.net/api/customers<br/>
https://tripsbookingapi.azurewebsites.net/api/customers/register<br/>
https://tripsbookingapi.azurewebsites.net/api/customers/unregister/{email}<br/>

```json
[
  {
    "id": 1,
    "name": "John",
    "lastname": "Snow",
    "tripname": "Feel the wave",
    "email": "JohnSnosw@mail.com"
  }
  ]
  ```
