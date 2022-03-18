# SovtechAPI - ASP.NET Core Web API

This repository contains a controllers which are dealing with Chuck Norris Jokes and Star Wars People using the [Chuck Norris API](https://api.chucknorris.io/) and [Star Wars API](https://swapi.dev/).

See the examples here: 

## Versions

``` https://localhost:44375/swagger ```

![image](https://user-images.githubusercontent.com/83064592/158956397-e6687bbb-1d7b-41bb-8078-1d2868c4b9dd.png)


## GET all the joke categories

``` https://localhost:44375/chuck/categories ```


```javascript
  ["animal","career","celebrity","dev","explicit","fashion","food","history","money","movie","music","political","religion","science","sport","travel"]
```



## GET all the Star Wars people

``` https://localhost:44375/swapi/people ```


```javascript
  {"count":82,
  "next":"https://swapi.dev/api/people/?page=2",
  "previous":null,
  "results":[
    {"name":"Luke Skywalker","height":"172","mass":"77","hair_color":"blond","skin_color":"fair","eye_color":"blue","birth_year":"19BBY","gender":"male","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":["https://swapi.dev/api/vehicles/14/","https://swapi.dev/api/vehicles/30/"],"starships":["https://swapi.dev/api/starships/12/","https://swapi.dev/api/starships/22/"],"created":"2014-12-09T13:50:51.644000Z","edited":"2014-12-20T21:17:56.891000Z","url":"https://swapi.dev/api/people/1/"},{"name":"C-3PO","height":"167","mass":"75","hair_color":"n/a","skin_color":"gold","eye_color":"yellow","birth_year":"112BBY","gender":"n/a","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/4/","https://swapi.dev/api/films/5/","https://swapi.dev/api/films/6/"],"species":["https://swapi.dev/api/species/2/"],"vehicles":[],"starships":[],"created":"2014-12-10T15:10:51.357000Z","edited":"2014-12-20T21:17:50.309000Z","url":"https://swapi.dev/api/people/2/"},{"name":"R2-D2","height":"96","mass":"32","hair_color":"n/a","skin_color":"white, blue","eye_color":"red","birth_year":"33BBY","gender":"n/a","homeworld":"https://swapi.dev/api/planets/8/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/4/","https://swapi.dev/api/films/5/","https://swapi.dev/api/films/6/"],"species":["https://swapi.dev/api/species/2/"],"vehicles":[],"starships":[],"created":"2014-12-10T15:11:50.376000Z","edited":"2014-12-20T21:17:50.311000Z","url":"https://swapi.dev/api/people/3/"},{"name":"Darth Vader","height":"202","mass":"136","hair_color":"none","skin_color":"white","eye_color":"yellow","birth_year":"41.9BBY","gender":"male","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":[],"starships":["https://swapi.dev/api/starships/13/"],"created":"2014-12-10T15:18:20.704000Z","edited":"2014-12-20T21:17:50.313000Z","url":"https://swapi.dev/api/people/4/"},{"name":"Leia Organa","height":"150","mass":"49","hair_color":"brown","skin_color":"light","eye_color":"brown","birth_year":"19BBY","gender":"female","homeworld":"https://swapi.dev/api/planets/2/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":["https://swapi.dev/api/vehicles/30/"],"starships":[],"created":"2014-12-10T15:20:09.791000Z","edited":"2014-12-20T21:17:50.315000Z","url":"https://swapi.dev/api/people/5/"},{"name":"Owen Lars","height":"178","mass":"120","hair_color":"brown, grey","skin_color":"light","eye_color":"blue","birth_year":"52BBY","gender":"male","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/5/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":[],"starships":[],"created":"2014-12-10T15:52:14.024000Z","edited":"2014-12-20T21:17:50.317000Z","url":"https://swapi.dev/api/people/6/"},{"name":"Beru Whitesun lars","height":"165","mass":"75","hair_color":"brown","skin_color":"light","eye_color":"blue","birth_year":"47BBY","gender":"female","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/5/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":[],"starships":[],"created":"2014-12-10T15:53:41.121000Z","edited":"2014-12-20T21:17:50.319000Z","url":"https://swapi.dev/api/people/7/"},{"name":"R5-D4","height":"97","mass":"32","hair_color":"n/a","skin_color":"white, red","eye_color":"red","birth_year":"unknown","gender":"n/a","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/"],"species":["https://swapi.dev/api/species/2/"],"vehicles":[],"starships":[],"created":"2014-12-10T15:57:50.959000Z","edited":"2014-12-20T21:17:50.321000Z","url":"https://swapi.dev/api/people/8/"},{"name":"Biggs Darklighter","height":"183","mass":"84","hair_color":"black","skin_color":"light","eye_color":"brown","birth_year":"24BBY","gender":"male","homeworld":"https://swapi.dev/api/planets/1/","films":["https://swapi.dev/api/films/1/"],"species":[],"vehicles":[],"starships":["https://swapi.dev/api/starships/12/"],"created":"2014-12-10T15:59:50.509000Z","edited":"2014-12-20T21:17:50.323000Z","url":"https://swapi.dev/api/people/9/"},{"name":"Obi-Wan Kenobi","height":"182","mass":"77","hair_color":"auburn, white","skin_color":"fair","eye_color":"blue-gray","birth_year":"57BBY","gender":"male","homeworld":"https://swapi.dev/api/planets/20/","films":["https://swapi.dev/api/films/1/","https://swapi.dev/api/films/2/","https://swapi.dev/api/films/3/","https://swapi.dev/api/films/4/","https://swapi.dev/api/films/5/","https://swapi.dev/api/films/6/"],"species":[],"vehicles":["https://swapi.dev/api/vehicles/38/"],"starships":["https://swapi.dev/api/starships/48/","https://swapi.dev/api/starships/59/","https://swapi.dev/api/starships/64/","https://swapi.dev/api/starships/65/","https://swapi.dev/api/starships/74/"],"created":"2014-12-10T16:16:29.192000Z","edited":"2014-12-20T21:17:50.325000Z","url":"https://swapi.dev/api/people/10/"}]}
```


## GET search both the Chuck Norris and Star Wars API. The response
contain metadata which indicates which API the result belongs to.

``` https://localhost:44375/search?query=luke ```

```javascript
  {"chuck":{
            "total":5,
            "result":[{"categories":[],"created_at":"2020-01-05 13:42:21.795084","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"5SdD2h0oQxOD4IAZCAy85w","updated_at":"2020-01-05 13:42:21.795084","url":"https://api.chucknorris.io/jokes/5SdD2h0oQxOD4IAZCAy85w","value":"One day Chuck Norris roundhouse kicked a building killing thousands of people while drinking a diet coke on a sunny day."},{"categories":[],"created_at":"2020-01-05 13:42:22.089095","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"AFbHbObUT06qzVkdfKlZ-A","updated_at":"2020-01-05 13:42:22.089095","url":"https://api.chucknorris.io/jokes/AFbHbObUT06qzVkdfKlZ-A","value":"Chuck Norris turned my pepsi into coke....I drank it for my own safety"},{"categories":[],"created_at":"2020-01-05 13:42:23.484083","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"fsTXH7kWSKesejuoIb5g5A","updated_at":"2020-01-05 13:42:23.484083","url":"https://api.chucknorris.io/jokes/fsTXH7kWSKesejuoIb5g5A","value":"One day Chuck Norris roundhouse kicked a building killing thousands of while drinking a diet coke on a sunny day."},{"categories":[],"created_at":"2020-01-05 13:42:29.296379","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"cSc9sZg1SF2iQsxV6V1ulQ","updated_at":"2020-01-05 13:42:29.296379","url":"https://api.chucknorris.io/jokes/cSc9sZg1SF2iQsxV6V1ulQ","value":"For entertainment purposes, Chuck Norris serves rum&coke and spiked punch as refreshments at AA meetings."},{"categories":["food"],"created_at":"2020-01-05 13:42:19.324003","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"uIrcWG7dRQG2SE2ZITAldQ","updated_at":"2020-05-22 06:02:41.792421","url":"https://api.chucknorris.io/jokes/uIrcWG7dRQG2SE2ZITAldQ","value":"Pepis was created when Chuck Norris said i want a Drink and not a Coke they owe me money. Pepis was thought of, invented, created, canned, and brought to Chuck Norris in 12 mins. Chuck Norris still roundhouse kicked the delivery guy for being to slow with his drink"}]},
    "swapi":{
             "count":0,
             "next":null,
             "previous":null,
             "results":[]
             }
   }
```
