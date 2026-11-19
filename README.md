# TaskManager

A simple task management web application built with **C#**, **ASP.NET Core MVC**, and **.NET 10**. This project demonstrates MVC architecture, form handling, server-side input validation, and rendering task data with Razor views.

## Features

- Create a task with a title, description, and status.
- View submitted tasks with their IDs, descriptions, and statuses.
- Choose from three statuses: **Not Started**, **Pending**, and **Completed**.
- Validate required titles and permitted status values on the server.
- Generate an ID for each newly submitted task.
- Display whether a task is completed using a computed model property.
- Protect the task creation POST action with anti-forgery validation.

## Tech stack

- C# / .NET 10
- ASP.NET Core MVC
- Razor Views
- HTML and CSS

## Getting started

**Requirements:** .NET 10 SDK

1. Clone the repository:

   ```bash
   git clone https://github.com/xataustundag/TaskManager.git
   cd TaskManager
   ```

2. Restore dependencies:

   ```bash
   dotnet restore TaskManager.sln
   ```

3. Run the application:

   ```bash
   dotnet run --project TaskManager/TaskManager.csproj
   ```

4. Open the localhost URL shown in the terminal. The default route opens the `TaskTwo` task list page.

## Project structure

```text
TaskManager.sln
TaskManager/
├── Controllers/
│   ├── TaskController.cs
│   └── TaskTwoController.cs
├── Models/
│   ├── TaskItem.cs
│   └── TaskTwoItem.cs
├── Views/
│   ├── Task/
│   ├── TaskTwo/
│   ├── Home/
│   └── Shared/
├── wwwroot/
├── Program.cs
└── TaskManager.csproj
```

## How it works

The main task page uses `TaskTwoController`. Its `Index` action displays the current task list. Submitting the form posts to `Create`, which checks that the title is not blank and that the status is one of the supported values. A new `TaskTwoItem` is added to the list, then the user is redirected back to the index page.

`TaskTwoItem.IsCompleted` is computed from the status value rather than stored separately.

## Current limitations

- Tasks are stored in an **in-memory static list**, not a database. They are lost when the application restarts.
- Editing and deleting tasks are not implemented.
- The `TaskController` page uses sample task data; the active default route points to `TaskTwoController`.
- This is a learning project, not a production-ready multi-user task management system.

## Author

**Ata Ustundag**  
[GitHub](https://github.com/xataustundag)
