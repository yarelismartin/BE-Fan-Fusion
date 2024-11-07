# Fan Fusion - Backend

## Contributors
Backend Developers:
<link href="https://github.com/yarelismartin">Yarelis Martin</link>
<link href="https://github.com/FletcherJMoore">Fletcher Moore</link>

Frontend Developers:
<link href="https://github.com/dinnerdoggy">Casey Cunningham</link>
<link href="https://github.com/sirenabailie">Sirena Foster</link>

## Description

Fan Fusion is a fan fiction platform where writers aspiring writers can publish their stories, build an audience, and recieve feedback. At the same time, readers can easily explore and enjoy new stories based on their preferences. 

## Table of Contents

- [Technologies](#technologies)
- [Installation](#installation)
- [API Endpoints](#api-endpoints)
- [Testing](#testing)
- [Frontend Repository Link](#link-to-frontend)

## Technologies

- **Programming Language:** C#
- **Framework:** [e.g., Node.js/Express, Django, Flask]
- **Database:** PostgreSQL
- **Authentication:** Firebase
- **Other Tools:** 

## Installation

1. Clone the repository:
   ```bash
   git clone git@github.com:yarelismartin/BE-Fan-Fusion.git
   cd BE-Fan-Fusion
  
2. Install dependencies:
   ```bash
   npm install  # For Node.js

3.Set up environment variables: 
Create a .env file in the root directory and add the required environment variables 

4. To start the server, run:
 ```bash
npm run dev
```
You can now access the API at http://localhost:3000

## API Endpoints

### Stories
| Method | Endpoint                             | Description                   |
|--------|--------------------------------------|-------------------------------|
| GET    | `/stories`                           | Retrieve all stories          |
| POST   | `/stories`                           | Create a new story            |
| GET    | `/stories/{storyId}`                 | Retrieve a specific story     |
| PUT    | `/stories/{storyId}`                 | Update an existing story      |
| DELETE | `/stories/{storyId}`                 | Delete a story                |
| GET    | `/stories/search`                    | Search story by title         |
| GET    | `/stories/categories/{categoryId}`   | Get stories by category       |
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


## Testing
To run tests, use:
```bash
npm test 
```

## Link to Frontend
Here is the link to our frontend repo: <link href="https://github.com/sirenabailie/Fan-Fusion-FE">Fan-Fusion-FE</link>

We also coded this backend in minimal API. Feel free to check it out: <link href="https://github.com/FletcherJMoore/Fan-Fusion-BE">Fan-Fusion-BE</link>


