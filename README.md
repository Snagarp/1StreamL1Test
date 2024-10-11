Introduction
Vendor-Hub project is a Vehicle Management System built using ASP.NET Core, Entity Framework Core, and Blazor using Clean Architecure in .Net 8. It provides functionality to manage vehicles, including creating, updating, deleting, and retrieving vehicle details, brands, and owners. User needs to Login firt to mange and it currently supports to define differe Role typesS (Admin, BusineesUser, Supportuser). the initial version has two API Account and Vehicle

Features User Authentication: Secure user login and role management using JWT token flow. Vehicle Management: Add, update, delete, and retrieve vehicle details. Vehicle Brand Management: Manage vehicle brands. Vehicle Owner Management: Manage vehicle owners. Presentiaton: Web api: Followed RESTful API's that include Entity framework access and migrations Responsive UI: A user-friendly interface built using Blazor,.Net8 Component Architecture: Followed Clean architecure,Design is flexible to enhance and scale up horizontally, Middleware & Configuration: Need to setup middleware ,depedency injections, configuring services, components with data-binding, routing between them. Unit Testing: Written possible test cases to test web api's / components using xUnit.

Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:

Prerquisite: Visaual studio 2022 SqlExpress/Sql Server Create a datbase called "StreamAssessment"

Installation process Step 1: Clone the repository:

Step2: Open the solution OneStreamAssessmentBlazor-API in Visual Studio 2022.

Step3: Update the database connection string in appsettings.json fo API project located under Presentation folder to match your SQL Server configuration.

Step4: Apply migrations to set up the database ( ensure you are selecting the Infrastructure project as Default project from package manager console drop down. execute "dotnet ef database update" from package manager console and wait for all the table to be crated.

Step5: Right click on the solution file and Configure start up Projects, and choose Multiple Startup projects option, and set VendorHub.API, VendorHub.WEBUI and click ok

Step6: Run the application, for first time Use Invoke Account/Setup API from initial admin account creation.

step7 : you can login to the VendorHub UI applicaion using admin@admin.com 
