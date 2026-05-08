# dlab
<div align="center">


<br/>

# 📚 D-Lab — Digital Library & Study Planner

> **A feature-rich C# desktop application** that combines a personal digital book library with an integrated study planning system — helping students and readers stay organised, track their reading, and plan their learning effectively.

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)
![Stars](https://img.shields.io/github/stars/isra-w/a-C-sharp-digital-library-app-with-study-planner?style=for-the-badge&color=yellow)

<br/>

[🚀 Get Started](#-getting-started) • [✨ Features](#-features) • [🏗️ Architecture](#️-architecture) • [📸 Screenshots](#-screenshots) • [🤝 Contributing](#-contributing)

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
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About the Project

**D-Lab** is a dual-purpose productivity application built entirely in **C#**. It bridges the gap between *reading* and *learning* by combining two powerful tools in one:

- 📚 **A Digital Library** — Catalog, search, and manage your personal collection of books and resources.
- 🗓️ **A Study Planner** — Schedule sessions, track reading progress, and stay on top of your academic goals.

Whether you're a student juggling multiple subjects or an avid reader who wants to stay organised, D-Lab gives you a clean and efficient workflow to manage your knowledge.

---

## ✨ Features

### 📚 Digital Library Module

| Feature | Description |
|---|---|
| 📖 **Book Management** | Add, edit, view, and remove books from your personal library |
| 🔍 **Search & Filter** | Quickly find books by title, author, genre, or category |
| ⭐ **Status Tracking** | Mark books as *To Read*, *Reading*, or *Completed* |
| 📝 **Notes & Reviews** | Attach personal notes and ratings to each book |
| 📂 **Genre Categorisation** | Organise your collection into custom categories |

### 🗓️ Study Planner Module

| Feature | Description |
|---|---|
| 📅 **Session Scheduling** | Plan and schedule dedicated study/reading sessions |
| ✅ **Task Management** | Create and track study tasks with deadlines |
| 📊 **Progress Tracking** | Monitor reading progress and study goals |
| ⏰ **Deadline Reminders** | Set and manage due dates for assignments and chapters |
| 🎯 **Goal Setting** | Define and pursue short- and long-term learning objectives |

---

## 🛠️ Tech Stack

```
Language  │  C# (.NET)
Platform  │  Windows Desktop Application
Storage   │  File-based / Local Data Persistence
Pattern   │  Object-Oriented Programming (OOP)
Diagrams  │  UML Class & Sequence Diagrams
```

- **Language:** C# — 100% of the codebase
- **Framework:** .NET (Console / WinForms)
- **Design:** Object-Oriented Architecture with clearly defined classes and modules
- **Tooling:** Visual Studio

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed before running the project:

- ✅ [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or above recommended)
- ✅ [Visual Studio](https://visualstudio.microsoft.com/) 2019 / 2022 (or VS Code with C# extension)
- ✅ Git

### Installation

1. **Clone the repository**

```bash
git clone https://github.com/isra-w/a-C-sharp-digital-library-app-with-study-planner.git
```

2. **Navigate into the project directory**

```bash
cd a-C-sharp-digital-library-app-with-study-planner/d-lab
```

3. **Open in Visual Studio**

```bash
# Option A: Open the solution file in Visual Studio
start d-lab.sln

# Option B: Run directly with .NET CLI
dotnet run
```

4. **Build & Run**

```bash
dotnet build
dotnet run
```

---

## 📋 Usage

Once the application starts, you'll be presented with a main menu to navigate between the two core modules:

```
╔══════════════════════════════════════╗
║        D-LAB — Main Menu            ║
╠══════════════════════════════════════╣
║  [1]  📚 Open Digital Library       ║
║  [2]  🗓️  Open Study Planner        ║
║  [3]  📊 View Progress Dashboard    ║
║  [0]  🚪 Exit                       ║
╚══════════════════════════════════════╝
```

### Library — Quick Workflow

```
1. Select "Digital Library" from the main menu
2. Add a new book → Enter title, author, genre, and status
3. Browse your collection with search/filter
4. Update reading status as you progress
5. Attach notes and a rating once finished
```

### Study Planner — Quick Workflow

```
1. Select "Study Planner" from the main menu
2. Create a new study session → Set subject, date, and duration
3. Add tasks or goals linked to specific books
4. Mark tasks complete as you go
5. Review your progress dashboard
```

---

## 📁 Project Structure

```
a-C-sharp-digital-library-app-with-study-planner/
│
├── 📂 d-lab/                         # Main C# project
│   ├── 📄 Program.cs                 # Application entry point
│   ├── 📄 Library.cs                 # Library module — book management
│   ├── 📄 Book.cs                    # Book entity / model class
│   ├── 📄 StudyPlanner.cs            # Study planner module
│   ├── 📄 StudySession.cs            # Study session entity
│   ├── 📄 Task.cs                    # Task / to-do entity
│   └── 📄 *.csproj                   # Project configuration file
│
├── 📂 Diagram samples/               # UML & architecture diagrams
│   ├── 🖼️  ClassDiagram.*            # Class relationship diagrams
│   └── 🖼️  SequenceDiagram.*        # Flow / sequence diagrams
│
└── 📄 README.md                      # You are here 👋
```

---

## 🏗️ Architecture

The application follows a clean **Object-Oriented** design with clearly separated concerns:

```
┌─────────────────────────────────────────────────────────────┐
│                     D-Lab Application                       │
├───────────────────────┬─────────────────────────────────────┤
│   📚 Library Module   │       🗓️ Study Planner Module       │
│                       │                                     │
│  ┌─────────────────┐  │  ┌──────────────────────────────┐   │
│  │   Book (Model)  │  │  │  StudySession (Model)        │   │
│  │  - Title        │  │  │  - Subject                   │   │
│  │  - Author       │  │  │  - Date / Duration           │   │
│  │  - Genre        │  │  │  - Linked Books              │   │
│  │  - Status       │  │  └──────────────────────────────┘   │
│  │  - Notes/Rating │  │  ┌──────────────────────────────┐   │
│  └─────────────────┘  │  │  Task (Model)                │   │
│  ┌─────────────────┐  │  │  - Title / Deadline          │   │
│  │ Library Manager │  │  │  - Completion Status         │   │
│  │  - Add/Edit     │  │  └──────────────────────────────┘   │
│  │  - Search       │  │  ┌──────────────────────────────┐   │
│  │  - Filter       │  │  │  Planner Manager             │   │
│  └─────────────────┘  │  │  - Schedule / Track / Report │   │
│                       │  └──────────────────────────────┘   │
└───────────────────────┴─────────────────────────────────────┘
                         │
               ┌─────────────────┐
               │  Program.cs     │
               │  (Entry Point   │
               │   & Main Menu)  │
               └─────────────────┘
```

> 📐 Full UML class diagrams and sequence diagrams are available in the [`Diagram samples/`](./Diagram%20samples/) folder.

---

## 🗺️ Roadmap

- [x] Core digital library with CRUD operations
- [x] Study planner with session scheduling
- [x] Task and goal management
- [ ] 🔮 GUI version (WinForms / WPF)
- [ ] 🔮 Data export (PDF / CSV reports)
- [ ] 🔮 Cloud sync / backup support
- [ ] 🔮 Statistics and reading analytics dashboard

---

## 🤝 Contributing

Contributions are welcome and appreciated! Here's how to get involved:

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
5. **Open** a Pull Request — describe your changes and we'll review it!

> 💡 Found a bug? Have a feature request? Open an [issue](https://github.com/isra-w/a-C-sharp-digital-library-app-with-study-planner/issues)!

---

## 📄 License

This project is licensed under the **MIT License** — you're free to use, modify, and distribute it. See the [LICENSE](LICENSE) file for details.

---

<div align="center">
⭐ **If you found this useful, give it a star!** ⭐

</div>
