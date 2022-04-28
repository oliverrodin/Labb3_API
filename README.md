


**- Hämta alla personer i systemet =>** 
    (GET) https://localhost:7097/api/Person

**- Hämta alla intressen som är kopplade till en specifik person =>** 
    (GET) https://localhost:7097/api/Interest/byperson/{personId}

**- Hämta alla länkar som är kopplade till en specifik person =>**
    (GET) https://localhost:7097/api/Link/byperson/{personId}

**- Koppla en person till ett nytt intresse =>**
    (PUT) https://localhost:7097/api/Person/updateinterest/{personId}

    REQUEST BODY:
    {
        "id": 5,
        "title": "Gravel-biking",
        "description": "Its a great way of training and discover your surroundings.",
        "persons": [],
        "links": []
    }

   Finns inte id:t i request bodyn så skapas en nytt intresse.

**- Lägga in nya länkar för en specifik person och ett specifikt intresse =>**
    (PUT) https://localhost:7097/api/Person/addlink/{personId}/{interestId}
    
    REQUEST BODY:
    {
        "url": "https://se.dbjourney.com/",
        "interestId": 7,
        "personId": 4
    }
