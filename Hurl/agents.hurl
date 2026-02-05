GET http://localhost:5168/api/agents
HTTP 200

POST http://localhost:5168/api/agents
Content-Type: application/json
{
    "firstName": "James",
    "lastName": "Bond",
    "codeName": "007",
    "active": true
}
HTTP 201

GET http://localhost:5168/api/agents/14
HTTP 200

PUT http://localhost:5168/api/agents/14
Content-Type: application/json
{
    "id": 14,
    "firstName": "Spider",
    "lastName": "Man",
    "codeName": "008",
    "active": true
}
HTTP 200

DELETE http://localhost:5168/api/agents/13
HTTP 204
