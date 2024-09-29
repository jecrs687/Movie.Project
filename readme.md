# Movie API Documentation

## Overview

The **Movie API** project consists of a REST API that provides access to a list of movies stored in a database. Additionally, the project includes a React-based frontend that consumes this API and displays the movie data in a user-friendly manner using Material-UI (MUI). The main features include filtering movies by genre and searching movies by title.

This documentation outlines the development of the API, the frontend, and the proposed architectural design utilizing AWS services.

## Requirements

To accomplish this project, the following components need to be developed:

1. **ASP.NET API**:
    - A REST API developed using ASP.NET Core that exposes an endpoint for retrieving movie data. The data will initially be loaded from a JSON file stored on disk.

2. **React Frontend**:
    - A responsive UI built with React and Material-UI (MUI) that consumes the movie API and displays the movie data. It should include:
        - **Genre Filtering**: Allow users to filter movies by genre.
        - **Title Search**: Enable users to search movies by title.

3. **Architectural Design**:
    - A diagram detailing the AWS services employed to host both the API and the React frontend.

## Movie Data

Below is the JSON structure representing the movie data:

```json
{
  "movies": [
    {
      "title": "The Shawshank Redemption",
      "year": 1994,
      "genre": ["Crime", "Drama"],
      "director": "Frank Darabont",
      "actors": ["Tim Robbins", "Morgan Freeman"],
      "rating": 9.3
    },
    {
      "title": "The Godfather",
      "year": 1972,
      "genre": ["Crime", "Drama"],
      "director": "Francis Ford Coppola",
      "actors": ["Marlon Brando", "Al Pacino", "James Caan"],
      "rating": 9.2
    },
    {
      "title": "The Dark Knight",
      "year": 2008,
      "genre": ["Action", "Crime", "Drama"],
      "director": "Christopher Nolan",
      "actors": ["Christian Bale", "Heath Ledger", "Gary Oldman"],
      "rating": 9.0
    },
    {
      "title": "Inception",
      "year": 2010,
      "genre": ["Action", "Adventure", "Sci-Fi"],
      "director": "Christopher Nolan",
      "actors": ["Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page"],
      "rating": 8.8
    }
  ]
}
```

## API Specifications

### Endpoint: /api/movies

- Method: GET
- Response:
  - Returns a list of movies in JSON format.
  - Response Example:
```json
[
  {
    "title": "The Shawshank Redemption",
    "year": 1994,
    "genre": ["Crime", "Drama"],
    "director": "Frank Darabont",
    "actors": ["Tim Robbins", "Morgan Freeman"],
    "rating": 9.3
  },
  {
    "title": "The Godfather",
    "year": 1972,
    "genre": ["Crime", "Drama"],
    "director": "Francis Ford Coppola",
    "actors": ["Marlon Brando", "Al Pacino", "James Caan"],
    "rating": 9.2
  }
]
```


## Frontend Features

- Movie Listing: All movies will be displayed in a visually appealing manner using MUI components such as Cards, Grids, and Tables.
- Genre Filtering: A dropdown or button group will be used to filter movies based on their genres.
- File Search: A search input field will allow users to search for movies by their title, with results updating in real-time as the user types.

AWS Architecture

The following AWS services are proposed to host and scale the application:
1. Amazon S3:
   - Used to store static assets such as frontend files.
2. AWS Lambda:
   - A serverless solution for hosting the backend API, ensuring scalability and reducing the need for server management. 
3. Amazon API Gateway:
   - Acts as a front door for the API, managing API requests and responses. 
4. Amazon RDS (Optional):
   - If we choose to persist movie data in a relational database, Amazon RDS will serve as the database solution.
5. CloudFront:
   - A content delivery network (CDN) to serve frontend assets globally with low latency.

### Architecture Diagram
```angular2html
   [Client Browser]
         |
   [CloudFront CDN]
         |
   [S3 Bucket (Static Files)]  <--- React Frontend
         |
   [API Gateway]  <--- Requests and Responses
         |
   [Lambda Function]  <--- Movie API
         |
   [Lambda Function]  <--- Cache Service (Optional)
         |
   [RDS Database (Optional)]  <--- Movie Data
```
This architecture ensures high availability, scalability, and low latency for users accessing the Movie API and frontend across the globe.
