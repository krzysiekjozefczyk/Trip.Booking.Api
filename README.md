# Trip.Booking.Api
Urls for trips controller actions:<br/>
https://tripsbookingapi.azurewebsites.net/api/trips <br/>
https://tripsbookingapi.azurewebsites.net/api/trips/create<br/>
https://tripsbookingapi.azurewebsites.net/api/trips/update/{id}<br/>
https://tripsbookingapi.azurewebsites.net/api/trips/delete/{id}<br/>
https://tripsbookingapi.azurewebsites.net/api/trips/?country=Spain

Example json file for trip request:
```json
[
  {
    "id": 1,
    "name": "Feel the wave",
    "description": "Come with us to Spain for a surfing adventure",
    "startdate": "2018-12-10",
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
    "email": "JohnSnosw@mail.com",
     "travelersamount": 3
  }
]
  ```
Example output:
![image](https://user-images.githubusercontent.com/16777051/174497921-6c9c5cc8-00cf-43da-900b-226d8537247b.png)
