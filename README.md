# Fan Fusion - Backend

## Description

Fan Fusion is a platform for fanfiction enthusiasts to create, share, and explore user-generated stories based on popular media. It allows users to write and manage multi-chapter stories, organize their work with tags and categories, and interact with the community by favoriting stories.

## Table of Contents

- [Technologies](#technologies)
- [Get Started](#get-started)
- [API Endpoints](#api-endpoints)
- [Postman Documentation](#postman-documentation)
- [Frontend Repository Link](#link-to-frontend)
- [Video API Walkthrough](#video-api-walkthrough)
- [Contributors](#contributors)

## Technologies

- **Programming Language:** C#
- **Framework:** ASP.NET Core (.NET 8.0)
- **Object-Relational Mapper:** Entity Framework Core
- **Database:** PostgreSQL
- **Database Management Tool:** pgAdmin

## Get Started

#### For this project to run successfully, you'll need the following:

- Visual Studio
- .NET
- pgAdmin

Follow these steps to set up the **Fan Fusion API**:
#### 1. Fork and Clone the Repository
Fork the repository, then clone it to your local machine.

#### 2. Open in Visual Studio 2022
Open the solution file (`.sln`) in **Visual Studio 2022**.

#### 3. Restore Dependencies
Run the following command to restore project dependencies:

```bash
dotnet restore
```

#### 4. Configure User Secrets
Initialize user secrets and set your PostgreSQL connection string:

```bash
dotnet user-secrets init
dotnet user-secrets set "BE-FanFusionDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your-password>;Database=BE-FanFusion"
```
Replace `<your_postgresql_password>` with your actual database password.

#### 5. Apply Migrations and Create the Database
Run the following command to apply the existing migrations and create the database:

```bash
dotnet ef database update
```

#### 6. Start Debugging
Run the project in debug mode by selecting the **Start Debugging** option in Visual Studio. This will launch the API, and you can access Swagger to test the endpoints.

#### 7. Test the API
Use **Postman** or Swagger UI to interact with the API and test CRUD operations for books and authors.


## API Endpoints

### Stories
| Method | Endpoint                             | Description                   |
|--------|--------------------------------------|-------------------------------|
| GET    | `/stories/users/{userId}`                           | Retrieve all stories          |
| POST   | `/stories`                           | Create a new story            |
| GET    | `/stories/{storyId}`                 | Retrieve a specific story     |
| PUT    | `/stories/{storyId}`                 | Update an existing story      |
| DELETE | `/stories/{storyId}`                 | Delete a story                |
| GET    | `/stories/search`                    | Search story by title         |
| GET    | `/stories/users/{userId}/categories/{categoryId}`   | Get stories by category       |
| GET    | `/stories/{storyId}/users/{userId}/favorites`   | Favorite and unfavorite a story       |
| POST   | `/stories/{storyId}/add-tag/{tagId}` | Add a tag to a story          |
| DELETE | `/stories/{storyId}/add-tag/{tagId}` | Remove a tag from a story     |

### Chapters
| Method | Endpoint                           | Description                   |
|--------|------------------------------------|-------------------------------|
| GET    | `/chapters/{chapterId}`            | Retrieve all stories          |
| POST   | `/chapters`                        | Create a new story            |
| DELETE | `/chapters/{chapterId}`            | Delete a story                |

### Comments
| Method | Endpoint                           | Description                   |
|--------|------------------------------------|-------------------------------|
| GET    | `/comments`                        | Create a comment              |
| DELETE | `/comments`                        | Remove a comment              |

### Users
| Method | Endpoint                           | Description                   |
|--------|------------------------------------|-------------------------------|
| GET    | `/users/checkUser`                 | Checks logged in user         | 
| GET    | `/users/{userId}`                  | Retrieve a specific user      | 


### Tags
| Method | Endpoint                           | Description                   |
|--------|------------------------------------|-------------------------------|
| GET    | `/tags`                            | Retrieve all tags             | 
| GET    | `/tags/{tagId}/users/{userId}`                            | Retrieve single tag            | 


## Postman Documentation

The API documentation is available in Postman, providing a detailed guide on how to interact with the Fan Fusion API.

- [Fan Fusion API Documentation](https://documenter.getpostman.com/view/31992966/2sAY52byrS)

## Link to Frontend
Here is the link to our frontend repo: [Fan-Fusion-FE](https://github.com/sirenabailie/Fan-Fusion-FE)

We also coded this backend in minimal API. Feel free to check it out: [Fan-Fusion-Minimal-API](https://github.com/FletcherJMoore/Fan-Fusion-BE)

## Video API Walkthrough

## Contributors

- [Yarelis Martin](https://github.com/yarelismartin)
- [Fletcher Moore](https://github.com/FletcherJMoore)


