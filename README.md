<div align="center">

<br/>

# 📚 D-Lab — Digital Library Management System with Study Assistant

> **A feature-rich Windows Forms C# desktop application** that combines a comprehensive digital library management system with an integrated study planning and timer feature — helping students and book enthusiasts stay organized and focused.

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
- [Security Features](#-security-features)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About the Project

**D-Lab** is a comprehensive **Windows Forms desktop application** built with **C# and .NET 10** that empowers users to manage their personal digital library while enhancing academic productivity. It provides a complete solution for:

- 📚 **Manage a Digital Library** — Organize, catalog, and browse a personal collection of books across multiple categories
- 🗓️ **Plan Study Sessions** — Schedule and track dedicated study/reading sessions
- ⏰ **Study Timer** — Built-in countdown timer with customizable duration for focused, distraction-free study sessions
- 👥 **Role-based Access Control** — Super Admin, Admin, Librarian, and User roles with distinct permissions and interfaces
- 🔐 **Secure Authentication** — BCrypt password hashing and parameterized SQL queries for enhanced security
- 👤 **User Profile Management** — Update profile pictures and personal information

Whether you're a student managing multiple subjects, a librarian cataloging resources, or an avid reader staying organized, D-Lab provides an intuitive and efficient workflow tailored to your needs.

---

## ✨ Features

### 📚 Digital Library Module

| Feature | Description |
|---|---|
| 📖 **Book Management** | Add, edit, view, and remove books from the library (Librarian/Super Admin) |
| 🔍 **Book Browsing** | Browse books organized by categories (Programming, Medicine, Novel, etc.) |
| 📂 **Category Organization** | View and filter books by predefined and custom categories |
| 📝 **Book Metadata** | Store comprehensive book information including Title, Author, Category, Year, and Format |
| 📋 **Book Grid View** | Display books in organized data grids with sortable columns |

### ⏱️ Study Assistant Module

| Feature | Description |
|---|---|
| ⏰ **Study Timer** | Set custom study session duration in minutes with real-time countdown |
| ⏱️ **Timer Controls** | Start/Stop functionality for flexible session management |
| 📊 **Session Display** | Clear display of remaining time in MM:SS format |
| 🎯 **Focus Mode** | Dedicated study panel for distraction-free timer usage |

### 👥 User & Admin Features

| Feature | Description |
|---|---|
| 🔐 **Role-Based Access Control** | Super Admin, Admin, Librarian, and User roles with distinct interfaces |
| 👥 **User Management** | Admins can manage users, assign/modify roles, and view user statistics |
| 📋 **User Approval** | Manage pending user registrations and assign initial roles |
| 👤 **User Profile** | Update profile picture and view personal information |
| 🔄 **Role Assignment** | Dynamic UI changes based on assigned user role |

---

## 🛠️ Tech Stack

```
Language              │  C# (.NET 10)
Platform              │  Windows Forms Desktop Application
Framework             │  .NET 10.0-windows
Database              │  Microsoft SQL Server
Authentication        │  BCrypt.Net-Next (password hashing)
Dependencies          │  Microsoft.Data.SqlClient, Npgsql, Oracle.ManagedDataAccess.Core
```

### Key Dependencies

- **Microsoft.Data.SqlClient 7.0.1** — SQL Server connectivity
- **System.Data.SqlClient 4.9.1** — Legacy SQL support
- **BCrypt.Net-Next 4.2.0** — Secure password hashing and verification
- **Npgsql 10.0.2** — PostgreSQL connectivity (for future expansion)
- **Oracle.ManagedDataAccess.Core 23.26.200** — Oracle database support

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
cd A-C-sharp-digital-library-Mng-t-desktop-app
```

2. **Restore NuGet packages**

```bash
dotnet restore
```

3. **Set up the database**

   - Open SQL Server Management Studio (SSMS)
   - Execute the `SQLQuery2.sql` script to create the database schema and tables
   - Update the connection string in `DB/dbconnection.cs`:
   ```csharp
   return @"Data Source=YOUR_SERVER;Initial Catalog=d_lab;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
   ```

4. **Open in Visual Studio**

```bash
# Open the solution file
start D_lab.slnx
```

5. **Build & Run**

```bash
# Build the project
dotnet build

# Run the application
dotnet run
```

---

## 📋 Usage

### Initial Launch

Upon launching the application, you'll encounter the **Welcome Page** with options to Login or Sign Up.

### Authentication Flow

#### For New Users (Sign Up)

1. Click **"Sign Up"** on the welcome screen
2. Enter your details:
   - First Name
   - Last Name
   - Username
   - Password (will be hashed with BCrypt)
3. Your account is created with a pending role status (awaiting admin approval)
4. Return to login with your credentials once approved

#### For Existing Users (Login)

1. Enter your **Username** and **Password**
2. Credentials are validated against the database
3. Password is verified using BCrypt enhanced verification
4. If role is not yet assigned, you'll see an access denied message
5. Upon successful authentication, you're redirected to your role-specific dashboard

### Role-Based Dashboards

#### 👤 User Role
After login, regular users can access:
- **Books Section** — Browse books by category (Programming, Medicine, Novel)
- **Study Assistant** — Access the countdown timer
- **Profile** — View and update personal information

#### 🔧 Librarian Role
Librarians have access to:
- **Library Management** — Add new books to the catalog
- **Book Management** — Edit and manage book information
- **Category Management** — Organize books by categories
- **Books Section** — Browse the complete library

#### ⚙️ Admin Role
Admins can:
- **User Management** — View all registered users
- **Role Assignment** — Assign and modify user roles
- **Filter by Role** — View users filtered by role (All, Super_Admin, Admin, User, Librarian, Pending)
- **User Statistics** — Monitor user count and role distribution

#### 🏆 Super Admin Role
Super Admins have full access to:
- All Admin features
- All Librarian features
- All User features
- Complete system control

### How to Use Features

#### 📚 Managing Books (Librarian/Super Admin)

1. Click **"Manage Books"** button
2. Fill in book details:
   - **Title** (Required) — Book name
   - **Author** (Required) — Author name
   - **Category** — Select from dropdown
   - **Publication Year** — Select date
   - **Format** — Choose format type
3. Click **"Add"** to save the book
4. Success message confirms addition to the library

#### ⏰ Using the Study Timer (All Users)

1. Click **"Study Assistant"** on the home menu
2. Enter desired study duration in **minutes**
3. Click **"START"** to begin the countdown
4. Timer displays remaining time in **MM:SS** format
5. Click **"STOP"** to pause the timer
6. Resume by clicking **"START"** again

#### 👤 Updating Profile

1. Click **"Profile"** link on the navigation
2. View current profile information:
   - First Name
   - Last Name
   - Username
   - Current Role
3. Click **"Edit"** to update profile picture
4. Select an image file (JPG, PNG, JPEG)
5. Changes are saved to the user profile

---

## 📁 Project Structure

```
A-C-sharp-digital-library-Mng-t-desktop-app/
│
├── 📄 Program.cs                           # Application entry point
├── 📄 D-lab.cs                             # Main form - primary UI and business logic
├── 📄 D-lab.Designer.cs                    # Auto-generated Windows Forms designer code
├── 📄 D-lab.resx                           # Form resources
│
├── 📁 DB/                                  # Database layer
│   └── 📄 dbconnection.cs                  # Database connection management
│
├── 📁 User controls/                       # Custom Windows Forms user controls
│   ├── 📄 Add_bookucontrol.cs              # User control for adding/managing books
│   ├── 📄 Add_bookucontrol.Designer.cs     # Designer file for book control
│   ├── 📄 Add_bookucontrol.resx            # Resources for book control
│   ├── 📄 Profile_updateucontrol.cs        # User control for profile updates
│   ├── 📄 Profile_updateucontrol.Designer.cs
│   └── 📄 Profile_updateucontrol.resx
│
├── 📁 Properties/                          # .NET project properties
│   ├── 📄 Resources.resx                   # Resource definitions
│   └── 📄 Resources.Designer.cs            # Auto-generated resource accessor
│
├── 📁 Resources/                           # Application resources (images, icons, etc.)
│
├── 📁 diagrams for d_lab/                  # Visual diagrams and documentation
│
├── 📄 D_lab.csproj                         # Project configuration and dependencies
├── 📄 D_lab.slnx                           # Solution file
│
├── 📄 SQLQuery2.sql                        # Database schema and migration script
├── 📄 .gitignore                           # Git ignore rules
├── 📄 .gitattributes                       # Git attributes
│
└── 📄 README.md                            # You are here 👋
```

### Key Files Explained

| File | Purpose |
|---|---|
| **Program.cs** | Entry point; initializes and runs the WinForms application |
| **D-lab.cs** | Main form containing all UI logic, authentication, role management, and feature implementations |
| **D-lab.Designer.cs** | Auto-generated designer code with control definitions |
| **dbconnection.cs** | Manages database connections and SQL query execution |
| **Add_bookucontrol.cs** | User control for book addition with form validation and database insertion |
| **Profile_updateucontrol.cs** | User control for profile picture and information updates |
| **SQLQuery2.sql** | Database schema defining Users, Books, and related tables |

---

## 🏗️ Architecture

The application follows a **layered architecture** with clear separation of concerns:

```
┌─────────────────────────────────────────────────────────────┐
│                   D-Lab Application                         │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  ┌──────────────────────────────────────────────────────┐  │
│  │        Presentation Layer (Windows Forms)            │  │
│  │  ┌─────────────────────────────────────────────────┐ │  │
│  │  │  D-lab.cs - Main Form                          │ │  │
│  │  │  ├─ Welcome/Login/SignUp Panels               │ │  │
│  │  │  ├─ Book Category Display                      │ │  │
│  │  │  ├─ User Management Dashboard                 │ │  │
│  │  │  ├─ Study Assistant Panel (Timer)             │ │  │
│  │  │  ├─ Profile Management Panel                  │ │  │
│  │  │  └─ Role-Based UI Rendering                   │ │  │
│  │  └─────────────────────────────────────────────────┘ │  │
│  │  ┌─────────────────────────────────────────────────┐ │  │
│  │  │  User Controls                                 │ │  │
│  │  │  ├─ Add_bookucontrol - Book Addition          │ │  │
│  │  │  └─ Profile_updateucontrol - Profile Update   │ │  │
│  │  └─────────────────────────────────────────────────┘ │  │
│  └──────────────────────────────────────────────────────┘  │
│                           │                                │
├────────────────────────────┴────────────────────────────────┤
│                   Business Logic Layer                      │
│  ├─ Authentication & BCrypt password verification          │
│  ├─ Study timer countdown logic                            │
│  ├─ Role-based access control                              │
│  ├─ User and book management workflows                     │
│  ├─ Book category filtering                                │
│  └─ Profile management                                     │
├───────────────────────────────────────���─────────────────────┤
│                   Data Access Layer (DB)                    │
│  ├─ DBConnection - SQL Server connection pooling           │
│  ├─ Parameterized SQL queries                              │
│  ├─ SqlDataAdapter for data binding                        │
│  ├─ SqlDataReader for result processing                    │
│  └─ Connection state management                            │
├─────────────────────────────────────────────────────────────┤
│              Database Layer (SQL Server)                    │
│  ├─ Users Table (authentication & role storage)            │
│  ├─ Books Table (library catalog)                          │
│  └─ Related tables for extended functionality              │
└─────────────────────────────────────────────────────────────┘
```

### Design Patterns Used

- **Layered Architecture** — Clear separation between presentation, business logic, and data access
- **MVC-inspired Pattern** — Windows Forms with separated control logic
- **Session Management** — Static Session class for maintaining user context
- **Role-Based Access Control (RBAC)** — Different UI and features based on assigned role
- **Parameterized Queries** — SQL injection prevention

---

## 📊 Database Schema

### Users Table

```sql
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1, 1),
    First_Name NVARCHAR(MAX) NOT NULL,
    Last_Name NVARCHAR(MAX) NOT NULL,
    Username NVARCHAR(MAX) NOT NULL,
    Password NVARCHAR(MAX) NOT NULL,          -- BCrypt hashed password
    Role NVARCHAR(MAX) NULL                   -- 'Super_Admin', 'Admin', 'Librarian', 'User', or NULL (Pending)
);
```

### Books Table

```sql
CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1, 1),
    Title NVARCHAR(MAX) NOT NULL,
    Author NVARCHAR(MAX) NOT NULL,
    Category NVARCHAR(MAX) NOT NULL,          -- 'Programming', 'Medicine', 'Novel', etc.
    Year INT NOT NULL,
    Format NVARCHAR(MAX) NOT NULL,            -- Book format (PDF, Hardcover, eBook, etc.)
    AddedBy INT NOT NULL,
    AddedDate DATETIME DEFAULT GETDATE()
);
```

### Supported User Roles

| Role | Permissions |
|---|---|
| **Super_Admin** | Full system access, all features, complete control |
| **Admin** | User management, role assignment, user statistics |
| **Librarian** | Add/edit/delete books, manage library catalog, category management |
| **User** | Browse library, add to personal collection, use study timer, update profile |
| **Pending** | None - awaiting role assignment from admin (Role = NULL) |

---

## 🔐 Security Features

- **BCrypt Password Hashing** — Industry-standard password hashing with enhanced verification
- **Parameterized SQL Queries** — Full SQL injection prevention
- **Secure Database Connection** — TLS/SSL encryption for database communications
- **Role-Based Access Control** — UI and features restricted by user role
- **Session State Management** — Secure session tracking with user context
- **Input Validation** — Required field validation before database operations
- **Error Handling** — Graceful exception handling with user-friendly messages

---

## 🛣️ Development Roadmap

### ✅ Completed Features
- [x] Core digital library management system
- [x] User authentication with BCrypt hashing
- [x] Role-based access control (4 roles)
- [x] Study timer with countdown functionality
- [x] User management dashboard for admins
- [x] Windows Forms UI implementation
- [x] Profile management with picture upload

### 🚀 Planned Enhancements
- [ ] Enhanced UI/UX with modern styling
- [ ] Book search functionality
- [ ] User reading history tracking
- [ ] Data export (PDF/Excel reports)
- [ ] Reading progress analytics
- [ ] Study session statistics
- [ ] Cloud backup/sync support
- [ ] Mobile companion app
- [ ] Dark mode support
- [ ] Notification system

---

## 🤝 Contributing

Contributions are welcome! We appreciate your interest in improving D-Lab. Here's how to contribute:

### Getting Started

1. **Fork** the repository
2. **Clone** your fork locally
3. **Create** a feature branch with a descriptive name:
   ```bash
   git checkout -b feature/add-search-functionality
   ```

### Making Changes

1. **Make** your code changes
2. **Test** thoroughly before committing
3. **Follow** C# naming conventions:
   - `PascalCase` for classes, methods, and properties
   - `camelCase` for local variables
   - `_camelCase` for private fields
4. **Comment** complex logic
5. **Keep commits** atomic and well-described

### Submitting Changes

1. **Commit** your changes with clear messages:
   ```bash
   git commit -m "feat: add book search functionality"
   git commit -m "fix: resolve timer bug"
   ```
2. **Push** to your fork:
   ```bash
   git push origin feature/add-search-functionality
   ```
3. **Open** a Pull Request with:
   - Clear description of changes
   - Reference to related issues
   - Before/after screenshots if UI changes

### Guidelines

- Follow existing code style and patterns
- Write meaningful commit messages
- Test all changes before submitting PR
- Update README if adding new features
- No breaking changes without discussion
- Request code review before merging

### Reporting Issues

Found a bug? Have a feature request? We'd love to hear from you!

- **Issues**: [Open an issue](https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app/issues)
- **Discussions**: Use GitHub Discussions for questions and ideas
- **Contact**: [@isra-w](https://github.com/isra-w)

---

## 📄 License

This project is currently **unlicensed**. For licensing information or to request a specific license, please contact the repository maintainer at [@isra-w](https://github.com/isra-w).

---

## 📞 Support & Contact

Need help? Have questions? Here's how to reach out:

- **GitHub Issues**: [Report bugs or request features](https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app/issues)
- **GitHub Discussions**: [Ask questions and share ideas](https://github.com/isra-w/A-C-sharp-digital-library-Mng-t-desktop-app/discussions)
- **Repository Owner**: [@isra-w](https://github.com/isra-w)

---

## 🌟 Acknowledgments

- Built with [.NET 10](https://dotnet.microsoft.com/)
- Secure password hashing with [BCrypt.Net-Next](https://github.com/BcryptNet/bcrypt.net)
- Database connectivity via [Microsoft.Data.SqlClient](https://github.com/dotnet/SqlClient)

---

<div align="center">

**⭐ If you find this project helpful, please consider giving it a star! ⭐**

Made with ❤️ by [@isra-w](https://github.com/isra-w)

[Back to top](#-d-lab--digital-library-management-system-with-study-assistant)

</div>
