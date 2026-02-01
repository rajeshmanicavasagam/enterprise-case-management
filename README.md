# Enterprise Case Management System

Full-stack enterprise-style case management demo built with
ASP.NET Core and Angular, designed to showcase clean architecture,
REST APIs, and modern frontend development.

## Tech Stack
### Backend
- ASP.NET Core 8 Web API
- Entity Framework Core
- PostgreSQL
- Clean Architecture (Domain, Application, Infrastructure)

### Frontend
- Angular 17 (standalone components)
- Angular Router
- Reactive Forms
- Mock services for UI development

## Features
- Login screen with reactive form (mock authentication)
- Case list screen with enterprise-style table layout
- Clean separation of concerns
- Modern Angular standalone setup
- Backend REST API for case management

## Architecture
This project follows a lightweight clean architecture approach:
- Domain: core entities and enums
- Application: contracts and abstractions
- Infrastructure: EF Core and persistence
- API: REST endpoints and configuration

## Running the Application
### Backend
#bash
dotnet run

##Frontend
npm install
npm start

## Screenshots
![Login](screenshots/login.png)
![Cases](screenshots/cases.png)


Notes

Frontend currently uses mock data for UI development

Backend API is fully implemented and ready for integration

Docker support planned but not required to evaluate the project
