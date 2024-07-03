# Amaral

## Introduction
This project is a .NET Core web application following an N-Tier architecture. It employs the Repository pattern and UnitOfWork for data access, includes various features like session management, user roles and authorization, and integrates several third-party libraries and services for enhanced functionality.

## Architecture
The application is structured using N-Tier architecture, which separates concerns into different layers:
- **Presentation Layer**: Handles UI components.
- **Business Logic Layer (BLL)**: Contains business logic.
- **Data Access Layer (DAL)**: Manages data access using Repository and UnitOfWork patterns.

## Features

### Repository Pattern and UnitOfWork
The Repository pattern is used to abstract data access, making it easier to test and maintain. The UnitOfWork pattern is implemented to ensure that multiple repositories can be handled within a single transaction.

### TempData/ViewBag/ViewData
These features are used for passing data between controllers and views in ASP.NET Core:
- **TempData**: Stores data until it's read.
- **ViewBag**: A dynamic object for passing data to views.
- **ViewData**: Dictionary for storing data to be used in views.

### SweetAlerts, Rich Text Editor, and DataTables
- **SweetAlerts**: For enhanced alert messages.
- **Rich Text Editor**: Integrates a WYSIWYG editor for text input.
- **DataTables**: For advanced interaction with HTML tables, such as sorting, filtering, and pagination.

### Roles and Authorization
Authorization is managed using ASP.NET Core Identity. Roles are assigned to users, and authorization policies are enforced throughout the application.

### Stripe Payment/Refund
Stripe is integrated for processing payments and issuing refunds. This feature includes both front-end and back-end implementations for handling transactions.

### Session Management
Sessions are used to store user-specific data for the duration of their interaction with the application.

### Emails with SendGrid
SendGrid is used for sending emails. The application includes services for sending transactional and notification emails.

### User Management
User management features include registration, login, password reset, and profile management.

### Social Login using Facebook
Facebook authentication is integrated to allow users to log in using their Facebook accounts.

### View Components
View Components are used to encapsulate reusable components in the UI.

## Database Initialization
The `DbInitializer` class is used to seed the database with initial data. This ensures that the application has the necessary data to function correctly from the start.

## Deployment
The application is designed to be deployed on Microsoft Azure. Deployment steps include:
1. Creating an Azure App Service.
2. Configuring the database on Azure.
3. Deploying the application using Azure DevOps or GitHub Actions.

## Getting Started
### Prerequisites
- .NET Core SDK
- SQL Server
- SendGrid Account
- Stripe Account
- Facebook Developer Account

### Installation
1. Clone the repository.
   ```bash
   git clone https://github.com/Amaral-tec/e-commerce-application-ASP.NET-Core-MVC.git