☕ Coffee Shop Management System

A Coffee Shop Management Website built with .NET Core, designed to streamline daily operations such as order management, product inventory, employee handling, and customer billing.

🚀 Features

User Authentication & Authorization

Secure login for Admins, Managers, and Staff.

Product Management

Add, update, delete, and view coffee items, snacks, and beverages.

Order Management

Create and manage customer orders with real-time updates.

Billing & Payments

Auto-generate bills and handle multiple payment methods.

Inventory Management

Track stock levels and get low-stock alerts.

Employee Management

Manage staff roles, shifts, and details.

Reports & Analytics

Daily/Monthly sales reports, revenue tracking, and performance insights.

🛠️ Tech Stack

Backend: ASP.NET Core (C#)

Frontend: Razor Pages / MVC with Bootstrap & CSS

Database: SQL Server (Entity Framework Core ORM)

Authentication: ASP.NET Core Identity (JWT / Cookie-based auth)

Other Tools: LINQ, Dependency Injection, Repository Pattern

📂 Project Structure
CoffeeShopManagement/
│-- CoffeeShopManagement.sln
│-- Controllers/
│-- Models/
│-- Views/
│-- Data/
│-- wwwroot/
│   ├── css/
│   ├── js/
│   ├── images/
│-- Migrations/
│-- appsettings.json
│-- Program.cs
│-- Startup.cs

⚡ Getting Started
1️⃣ Prerequisites

.NET 6/7 SDK

SQL Server

Visual Studio 2022 / VS Code

2️⃣ Clone the Repository
git clone [https://github.com/Zatakiya2510/Coffee-Shop-]
cd CoffeeShopManagement

3️⃣ Database Setup

Update appsettings.json with your SQL Server connection string.

Run migrations:

dotnet ef database update

4️⃣ Run the Application
dotnet run


Now open http://localhost:5000
 in your browser.

🔑 Default Admin Credentials
Email: admin@coffeeshop.com
Password: Admin@123

📊 Future Enhancements

✅ Online ordering & delivery module

✅ Customer loyalty program

✅ Mobile app integration (Xamarin/MAUI)

✅ AI-powered sales prediction
