# 👥 Employee Management System

A full-stack web application built with **.NET 8 Blazor WebAssembly** and **ASP.NET Core Web API**, featuring JWT authentication, role-based access control, and a clean multi-project solution architecture.

Developed during internship at **Kartepe Municipality**.

---

## 📌 Overview

This system allows organizations to manage employee records, departments, and roles through a dynamic, responsive web interface. The backend exposes a RESTful API secured with JWT, while the frontend is a Blazor WebAssembly SPA that communicates with the API.

---

## 🖼️ Screenshots

<img width="913" height="584" alt="image" src="https://github.com/user-attachments/assets/68fbc4ef-3208-4b84-a216-07d35d43a0cd" />
<img width="1920" height="1033" alt="image" src="https://github.com/user-attachments/assets/2578a477-648d-4d9e-bd96-c3b6292fa78d" />

<img width="501" height="492" alt="image" src="https://github.com/user-attachments/assets/e076ab6f-2921-4e6c-92e2-5739b34a335a" />

<img width="369" height="793" alt="image" src="https://github.com/user-attachments/assets/16aa0dde-6b9b-4c16-99aa-29f71d5ebd3e" />

<img width="1393" height="484" alt="image" src="https://github.com/user-attachments/assets/6e11e5c2-3e4c-49d8-81a3-8eedfcb3e450" />
<img width="1447" height="610" alt="image" src="https://github.com/user-attachments/assets/57f53280-90f5-470f-8b5a-a3a4caff3289" />



---

## 🛠️ Tech Stack

**Backend**
- .NET 8 / ASP.NET Core Web API
- Entity Framework Core (Code-First)
- SQL Server
- JWT Authentication + Refresh Token

**Frontend**
- Blazor WebAssembly
- Syncfusion UI Components
- Bootstrap 5

**DevOps**
- GitHub Actions CI/CD (`dotnet.yml`)

---

## 🏗️ Solution Architecture

The solution is structured across 6 projects for clean separation of concerns:

```
EmployeeManagementSystem/
├── BaseLibrary/        # Shared models, DTOs, response wrappers
├── Client/             # Blazor WebAssembly frontend
├── ClientLibrary/      # Client-side services and HTTP helpers
├── Server/             # ASP.NET Core Web API
├── ServerLibrary/      # Server-side repositories and business logic
└── DemoEMS.sln
```

---

## 🔐 Authentication & Authorization

- JWT-based authentication with **refresh token rotation**
- Role-based access control (multiple user roles)
- Secure token storage and renewal handled on the client side

---

## ⚙️ Key Features

- Employee CRUD operations (create, read, update, delete)
- Department and role management
- JWT login / logout with refresh token support
- Responsive UI built with Syncfusion components and Bootstrap
- Generic Repository and Generic Controller patterns for standardized data access
- GitHub Actions pipeline for automated build and test on push

---

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (or SQL Server Express)
- Visual Studio 2022 or VS Code

### Setup

1. Clone the repository
```bash
git clone https://github.com/aslaydn/EmployeeManagementSystem.git
cd EmployeeManagementSystem
```

2. Update the connection string in `Server/appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeDB;Trusted_Connection=True;"
}
```

3. Apply migrations
```bash
cd Server
dotnet ef database update
```

4. Run the API
```bash
dotnet run --project Server
```

5. Run the Blazor client
```bash
dotnet run --project Client
```

Then open `https://localhost:5001` in your browser.

---

## 📁 CI/CD

GitHub Actions workflow (`.github/workflows/dotnet.yml`) automatically builds and tests the solution on every push to `main`.

---

## 📄 Academic & Professional Context

Developed as an internship project at **Kartepe Municipality, Kocaeli** (Jul–Sep 2025).  
Inspired by the [Netcode-Hub](https://www.youtube.com/@Netcode-Hub) tutorial series on Blazor WebAssembly and .NET 8 Web API.
