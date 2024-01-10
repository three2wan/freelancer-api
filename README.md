# freelancer-api

This repository hosts an API for building a comprehensive list of freelancers, showcasing their unique skills, hobbies, and contact information. Whether you're looking to connect with talented individuals or you're a freelancer eager to showcase your expertise, this API provides a simple and efficient solution.

</br>
## 1. Get All Freelancers

Retrieve a list of all freelancers available in the system. Freelancers are individuals who offer their details, skills and hobbies. This endpoint provides a comprehensive overview of their profiles.

Endpoint: GET http://<server_url:port>/api/freelancer

Parameter: none

Response:

```
[
    {
        "id": "0799ce6e-d538-400a-b616-24e65abb5266",
        "username": "SyazwanJamil",
        "email": "syazwan_jamil88@yahoo.com",
        "phone": "017-2342869",
        "skillset": "Web App Development, Games Development",
        "hobby": "Playing video games"
    },
    {
        "id": "a75db8b6-aefd-40e5-ab24-41571f7d9bdf",
        "username": "JohnDoe",
        "email": "john.doe@example.com",
        "phone": "123-456-7890",
        "skillset": "Web Development, UX/UI Design",
        "hobby": "Photography"
    },
    {
        "id": "bbd9654a-0732-45ee-b21b-81d6ac0cdfb4",
        "username": "JaneSmith",
        "email": "jane.smith@example.com",
        "phone": "987-654-3210",
        "skillset": "Mobile App Development, Graphic Design",
        "hobby": "Reading"
    }
]
```

</br>
## 2. Get Freelancer by ID

Retrieve detailed information about a specific freelancer based on their unique identifier (ID). This endpoint is useful when you need detailed insights into a particular freelancer's profile.

Endpoint: GET http://<server_url:port>/api/freelancer/{id}

Parameter: none

Response:

```
{
    "id": "0799ce6e-d538-400a-b616-24e65abb5266",
    "username": "SyazwanJamil",
    "email": "syazwan_jamil88@yahoo.com",
    "phone": "017-2342869",
    "skillset": "Web App Development, Games Development",
    "hobby": "Playing video games"
}
```

</br>
## 3. Create New Freelancer

Add a new freelancer to the system. This endpoint is essential for onboarding new talent and expanding the pool of available freelancers within your platform.

Endpoint: POST http://<server_url:port>/api/freelancer/

Parameter:

- username
- email
- phone
- skillset
- hobby

Example Request Body:

```
{
    "username": "Happy123",
    "email": "happy@example.com",
    "phone": "017-237 4332",
    "skillset": "Data entry",
    "hobby": "Swimming"
}
```

Response:

```
{
    "message": "Successful added to database",
    "dateTime": "2024-01-10 21:29:04"
}
```

</br>
## 4. Update Freelancer Details

Modify and update the information associated with a specific freelancer. This functionality is crucial for keeping freelancer profiles accurate and up-to-date.

Endpoint: PUT http://<server_url:port>/api/freelancer/{id}

Parameter:

- username
- email
- phone
- skillset
- hobby

Example Request Body:

```
{
    "username": "UpdatedUsername",
    "email": "happy@example.com",
    "phone": "017-237 4332",
    "skillset": "Data entry",
    "hobby": "Swimming"
}
```

Response:

```
{
    "message": "Successful update data",
    "dateTime": "2024-01-10 21:33:12"
}
```

</br>
## 5. Delete Freelancer by ID

Remove a specific freelancer from the system, permanently deleting their profile and associated data. Use this endpoint with caution, as it irreversibly removes the freelancer's information.

Endpoint: DELETE http://<server_url:port>/api/freelancer/{id}

Parameter: none

Response:

```
{
    "message": "Successful delete the data",
    "dateTime": "2024-01-10 21:36:25"
}
```
