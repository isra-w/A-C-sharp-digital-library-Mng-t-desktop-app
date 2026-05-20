<div align="center">

<br/>

# 📚 D-Lab — Digital Library Management System with Study Assistant

> **A feature-rich Windows Forms C# desktop application** that combines a personal digital library management system with an integrated study planning and timer feature — helping students stay organized and manage their reading progress effectively.

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%2010-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Windows Forms](https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Status](https://img.shields.io/badge/Status-Active%20Development-success?style=for-the-badge)

<br/>

[🚀 Getting Started](#-getting-started) • [✨ Features](#-features) • [🏗️ Architecture](#️-architecture) • [📁 Project Structure](#-project-structure) • [🤝 Contributing](#-contributing)

---

</div>

## 📖 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Getting Started](#-getting-started)
- [Usage](#-usage)
- [Project Structure](#-project-structure)
- [Architecture](#️-architecture)
- [Database Schema](#-database-schema)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About the Project

**D-Lab** is a comprehensive **Windows Forms desktop application** built with **C# and .NET 10** that bridges the gap between personal library management and academic productivity. It provides a complete solution for users to:

- 📚 **Manage a Digital Library** — Organize, search, and catalog personal book collections
- 🗓️ **Plan Study Sessions** — Schedule and track dedicated study/reading sessions
- ⏰ **Study Timer** — Built-in timer feature with countdown display for focused study sessions
- 👤 **Role-based Access** — Admin, Librarian, and User roles with different permissions
- 🔐 **Secure Authentication** — BCrypt password hashing for enhanced security

Whether you're a student managing multiple subjects, a librarian cataloging resources, or an avid reader staying organized, D-Lab provides an efficient workflow integrated into a clean Windows Forms interface.

---

## ✨ Features

### 📚 Digital Library Module

| Feature | Description |
|---|---|
| 📖 **Book Management** | Add, edit, view, and remove books from your personal library |
| 🔍 **Search & Filter** | Find books with advanced search and category filtering |
| 📂 **Category Organization** | Organize books by genre and custom categories (Programming, Medicine, Novel, etc.) |
| 📝 **Book Metadata** | Store author, title, category, and other book information |
| 👤 **User Collections** | Each user maintains their own personal library |

### 🗓️ Study Assistant Module

| Feature | Description |
|---|---|
| ⏰ **Study Timer** | Customizable countdown timer for focused study sessions |
| 📊 **Session Tracking** | Monitor and track study session duration and progress |
| 🎯 **Study Planning** | Plan and organize study goals linked to library books |
| ✅ **Task Management** | Create and track study-related tasks |

### 👤 User & Admin Features

| Feature | Description |
|---|---|
| 🔐 **Role-Based Access Control** | Admin, Librarian, and User roles with distinct interfaces |
| 👥 **User Management** | Admins can manage users, assign roles, and view user statistics |
| 📋 **User Approval** | Manage pending user registrations and role assignments |
| 👤 **User Profile** | Update profile picture and personal information |

---

## 🛠️ Tech Stack

```
Language          │  C# (100%)
Platform          │  Windows Forms Desktop Application (.NET 10)
Database          │  Microsoft SQL Server
Authentication    │  BCrypt.Net-Next (password hashing)
Framework         │  .NET 10.0-windows
Additional Tools  │  Theme Provider, Navigation Menu, Binding Provider
```

### Key Dependencies

- **Microsoft.Data.SqlClient 7.0.1** — SQL Server connectivity
- **BCrypt.Net-Next 4.2.0** — Secure password hashing
- **Kimtoo Libraries** — UI components (ThemeProvider, NavigationMenu, BindingProvider, DbManager)
- **System.Data.SqlClient 4.9.1** — Legacy SQL support

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed:

- ✅ [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- ✅ [Visual Studio 2022](https://visualstudio.microsoft.com/) (with Windows Forms workload) or VS Code with C# extension
- ✅ [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or Standard Edition)
- ✅ Git

### Installation

1. **Clone the repository**

```bash
git clone https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app.git
```

2. **Navigate into the project directory**

```bash
cd A-C-sharp-digital-library-Mng-t-desktop-app
```

3. **Restore NuGet packages**

```bash
dotnet restore
```

4. **Set up the database**

   - Open SQL Server Management Studio (SSMS)
   - Execute the `SQLQuery2.sql` script to create the database schema
   - Update the database connection string in your project configuration

5. **Open in Visual Studio**

```bash
# Open the solution
start d.labdemo.slnx

# Or run directly with .NET CLI
dotnet run
```

6. **Build & Run**

```bash
dotnet build
dotnet run
```

---

## 📋 Usage

Upon launching the application, you'll see a welcome page with options to **Login** or **Sign Up**:

### Initial Screens

```
┌─────────────────────────────────┐
│    D-LAB Welcome Page           │
├─────────────────────────────────┤
│   [Login]     [Sign Up]         │
└─────────────────────────────────┘
```

### Login & Registration

**New Users:**
1. Click **"Sign Up"** on the welcome screen
2. Enter: First Name, Last Name, Username, and Password
3. Account is created with "User" role (pending admin approval)
4. Complete login credentials are encrypted using BCrypt

**Existing Users:**
1. Enter your username and password
2. Password is verified against the encrypted stored hash
3. You're authenticated and redirected to your role-specific dashboard

### User Dashboard (User Role)

After login, users with the **User** role see:

```
┌──────────────────────────────────┐
│      D-LAB Main Menu             │
├──────────────────────────────────┤
│  [📚 Books]                      │
│  [🗓️  Study Assistant]           │
│  [👤 Profile]                    │
│  [🚪 Logout]                     │
└──────────────────────────────────┘
```

**Books Section:**
- View all available books in the library
- Filter by category (Programming, Medicine, Novel, etc.)
- Add books to your personal collection
- Manage reading status

**Study Assistant:**
- Access the study timer (set custom duration in minutes)
- Start/Stop countdown sessions
- Track study session duration

**Profile:**
- Update profile picture
- View and edit personal information

### Admin Dashboard (Admin Role)

Admins have access to:

```
┌──────────────────────────────────┐
│      D-LAB Admin Panel           │
├──────────────────────────────────┤
│  [📊 Manage Users]               │
│  [👥 View Statistics]            │
│  [🚪 Logout]                     │
└──────────────────────────────────┘
```

**User Management:**
- View all registered users
- Filter by role: All, Admin, User, Librarian, Pending
- Assign roles to pending users
- Update user roles (Admin, User, Librarian)
- View user details (ID, Name, Username)

### Librarian Dashboard (Librarian Role)

Librarians can:
- Add new books to the library
- Manage library catalog
- Update book information
- Manage book categories

---

## 📁 Project Structure

```
A-C-sharp-digital-library-Mng-t-desktop-app/
│
├── 📄 Program.cs                    # Application entry point
├── 📄 Form1.cs                      # Main form (d_lab) - primary UI logic
├── 📄 Form1.Designer.cs             # Auto-generated Windows Forms designer code
├── 📄 Form1.resx                    # Form resources
├── 📄 Add_bookusercontrol.cs        # User control for adding books (empty stub)
│
├── 📁 Models/                       # Data model classes
│   └── (Model definitions for entities)
│
├── 📁 DB/                           # Database layer
│   ├── DBConnection.cs              # Database connection management
│   └── (Database-related code)
│
├── 📁 User controls/                # Custom Windows Forms user controls
│   └── (Reusable UI components)
│
├── 📁 Resources/                    # Application resources
│   └── (Images, icons, etc.)
│
├── 📁 Properties/                   # .NET project properties
│   ├── Resources.resx               # Resource definitions
│   └── Resources.Designer.cs        # Auto-generated resource accessor
│
├── 📄 d_labdemo.csproj             # Project configuration
├── 📄 d.labdemo.slnx               # Solution file
│
├── 📄 SQLQuery2.sql                 # Database schema/migration script
├── 📄 .gitignore                    # Git ignore rules
├── 📄 .gitattributes               # Git attributes
│
└── 📄 README.md                     # You are here 👋
```

### Key Files

- **Program.cs** — Entry point that initializes and runs the WinForms application
- **Form1.cs (d_lab)** — Main application form containing all UI logic:
  - Login/Registration workflow
  - Role-based UI rendering
  - User management for admins
  - Study timer implementation
  - Database interactions
- **Form1.Designer.cs** — Auto-generated designer file with control definitions (48KB)
- **Add_bookusercontrol.cs** — User control template for book addition (currently empty)
- **SQLQuery2.sql** — Database migration script for table schema setup

---

## 🏗️ Architecture

The application follows a **layered architecture** with separation of concerns:

### Architecture Diagram

```
┌─────────────────────────────────────────────────────────────┐
│                   D-Lab Application                         │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  ┌──────────────────────────────────────────────────────┐  │
│  │        Presentation Layer (Windows Forms)            │  │
│  │  ┌─────────────────────────────────────────────────┐ │  │
│  │  │  Form1 (d_lab) - Main Form                     │ │  │
│  │  │  - Welcome Page                                │ │  │
│  │  │  - Login/Registration                          │ │  │
│  │  │  - Book Category Panel                         │ │  │
│  │  │  - User Management Panel                       │ │  │
│  │  │  - Study Assistant Panel                       │ │  │
│  │  │  - Profile Panel                               │ │  │
│  │  └─────────────────────────────────────────────────┘ │  │
│  │  ┌─────────────────────────────────────────────────┐ │  │
│  │  │  User Controls                                 │ │  │
│  │  │  - Add_bookusercontrol                        │ │  │
│  │  └─────────────────────────────────────────────────┘ │  │
│  └──────────────────────────────────────────────────────┘  │
│                           │                                │
├────────────────────────────┴────────────────────────────────┤
│                   Business Logic Layer                      │
│  - Authentication & password verification (BCrypt)         │
│  - Study timer logic                                        │
│  - Role-based access control                               │
│  - User and book management workflows                       │
├─────────────────────────────────────────────────────────────┤
│                   Data Access Layer (DB)                    │
│  - DBConnection - SQL Server connection management         │
│  - Direct SQL queries                                       │
│  - Data reader operations                                   │
├─────────────────────────────────────────────────────────────┤
│              Database Layer (SQL Server)                    │
│  - Users Table (authentication & role storage)              │
│  - Books Table (library catalog)                            │
│  - Study Sessions & Tasks (planning features)               │
└─────────────────────────────────────────────────────────────┘
```

### Design Patterns

- **Layered Architecture** — Clear separation between presentation, business logic, and data access
- **Windows Forms Pattern** — Standard .NET Forms with designer-generated UI
- **Singleton-like Connection** — DBConnection manages shared database connections
- **Role-Based Access Control** — Different UI/features based on user role

---

## 📊 Database Schema

### Users Table

```sql
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1, 1),
    First_Name NVARCHAR(MAX) NOT NULL,
    Last_Name NVARCHAR(MAX) NOT NULL,
    Username NVARCHAR(MAX) NOT NULL,
    Password NVARCHAR(MAX) NOT NULL,  -- BCrypt hashed
    Role NVARCHAR(MAX) NULL           -- 'Admin', 'User', 'Librarian', or NULL (Pending)
)
```

### Supported Roles

- **Admin** — Full system access, user management, role assignment
- **User** — Access to library, personal collections, study tools
- **Librarian** — Can add and manage books in the library
- **Pending** — New users awaiting role assignment (Role = NULL)

### Other Tables

The schema includes tables for:
- **Books** — Digital library catalog (category, author, title, etc.)
- **Study Sessions** — User study session records
- **Tasks** — Study-related tasks and goals

(See SQLQuery2.sql for complete schema)

---

## 🔐 Security Features

- **BCrypt Password Hashing** — Passwords are hashed using BCrypt.Net-Next with enhanced verification
- **Parameterized Queries** — SQL injection prevention via parameterized SqlCommand
- **Role-Based Access Control** — Different UI and features based on user role
- **Secure Connection** — Uses Microsoft.Data.SqlClient for secure database communication

---

## 🗺️ Roadmap

- [x] Core digital library management
- [x] User authentication with role-based access
- [x] Study timer with countdown
- [x] User management dashboard (Admin)
- [x] Windows Forms UI implementation
- [ ] Enhanced UI/UX improvements
- [ ] Data export (PDF/Excel reports)
- [ ] Reading progress analytics
- [ ] Cloud backup/sync support
- [ ] Mobile companion app

---

## 🤝 Contributing

Contributions are welcome! Here's how to get involved:

1. **Fork** the repository
2. **Create** a feature branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. **Commit** your changes:
   ```bash
   git commit -m "feat: add your feature description"
   ```
4. **Push** to your branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. **Open** a Pull Request and describe your changes

### Guidelines

- Follow C# naming conventions (PascalCase for classes, camelCase for variables)
- Include comments for complex logic
- Test your changes before submitting a PR
- Update this README if adding new features

> 💡 Found a bug? Have a feature request? [Open an issue](https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app/issues)!

---

## 📄 License

This project is currently unlicensed. Please review the repository for licensing details or contact the maintainer.

---

## 📞 Support

For issues, questions, or suggestions:

- **Issues**: [GitHub Issues](https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app/issues)
- **Owner**: [@isra-w](https://github.com/isra-w)

---

<div align="center">

**Made with ❤️ by the D-Lab Team**

⭐ **If you found this useful, give it a star!** ⭐

</div>
