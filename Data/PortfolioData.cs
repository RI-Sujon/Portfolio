using RabiulPortfolio.Models;

namespace RabiulPortfolio.Data;

/// <summary>
/// Central source of truth for all portfolio content (skills, work experience,
/// professional projects and academic/personal projects).
/// </summary>
public static class PortfolioData
{
    public static readonly Dictionary<string, string[]> Skills = new()
    {
        ["Languages"] = new[] { "C#", "JavaScript", "TypeScript", "Dart", "Java", "C++", "PHP" },
        ["Frontend & Mobile"] = new[] { "Blazor", "NextJS", "React", "Angular", "Flutter", "Android" },
        ["Backend"] = new[] { "ASP.NET Core (MVC, Web API)", "NodeJS" },
        ["Databases"] = new[] { "PostgreSQL", "MSSQL", "MySQL", "MongoDB", "Firebase", "Redis" },
        ["Cloud & DevOps"] = new[] { "Azure", "Terraform", "Azure DevOps", "Docker", "Kubernetes", "RBAC/Managed Identity" },
        ["AI / LLM Integration"] = new[] { "Azure OpenAI", "RAG", "Vector Search", "Prompt Engineering", "Function/Tool Calling" },
        ["Tools & Testing"] = new[] { "Git", "Jira", "FastReport", "Selenium" }
    };

    public static readonly List<Company> Companies = new()
    {
        new("BJIT Ltd", "Dhaka-1212, Bangladesh", "August 2025 - Present", "BJIT_LOGO.png", new[]
        {
            new Role("Software Engineer", "August 2025 - Present", "Current", new[] { "ASP.NET Core", "Blazor", "PostgreSQL" })
        }),
        new("LoneSock", "Dhaka-1000, Bangladesh", "April 2025 - July 2025 • 4 months", "LoneSock_LOGO.svg", new[]
        {
            new Role("Software Engineer", "April 2025 - July 2025", "4 months", new[] { "ASP.NET Core", "NextJS", "PostgreSQL", "Docker", "Redis", "Azure DevOps" })
        }),
        new("Orion Informatics Ltd", "Dhaka-1205, Bangladesh", "January 2022 - March 2025 • 3 years 3 months", "Orion_LOGO.png", new[]
        {
            new Role("Software Engineer", "December 2023 - March 2025", "1 year 4 months", new[] { "ASP.NET Core", "MSSQL", "Fast Report" }),
            new Role("Junior Software Engineer", "July 2022 - November 2023", "1 year 5 months", new[] { "React", "ASP.NET Core", "MSSQL", "Fast Report" }),
            new Role("Software Engineer Intern", "January 2022 - June 2022", "6 months", new[] { "Angular", "Blockchain" })
        })
    };

    public static readonly List<Project> ProProjects = new()
    {
        new("Reamsシステム", "Blazor", "A Japan based client project for migrating a legacy system to a modern web application using Blazor Framework.",
            new[] { "Developed responsive Blazor UI components for migrating legacy Java application screens.", "Recreated legacy Java screens as modern, responsive web interfaces using Blazor." },
            "BJIT Ltd", "BJIT_LOGO.png"),
        new("医薬品在庫管理システム", "Blazor, PostgreSQL", "A Japan based client project for migrating a VB6 PC apps to Web Application using Blazor Framework.",
            new[] { "Developed application features using Blazor for migrating the legacy VB6 application.", "Implemented UI, business logic, and PostgreSQL database operations using Blazor." },
            "BJIT Ltd", "BJIT_LOGO.png"),
        new("Power Division ERP", "ASP.NET Core, MSSQL, Fast Report", "Enterprise ERP system for Bangladesh Power Division operations, inventory management, reporting, and performance tracking.",
            new[] { "Developed Inventory Management, Performance Appraisal, and Plant Management modules, translating operational requirements into scalable ERP solutions.", "Built and integrated full-stack features across frontend, backend APIs, and database layers, ensuring reliable data flow and seamless module integration.", "Designed and implemented dynamic reports using FastReport for data analysis, visualization, and performance monitoring." },
            "Orion Informatics Ltd", "Orion_LOGO.png"),
        new("Boooks.Net", "ASP.NET Core, NextJS, PostgreSQL", "An international marketplace for buying and selling rare, vintage, valuable, and collectible items.",
            new[] { "Designed the application architecture and established the project structure from scratch, including introducing Redis as a caching layer.", "Set up Docker containerization and began building an Azure DevOps CI/CD pipeline for the application.", "Implemented the user authentication module, including login functionality." },
            "LoneSock", "LoneSock_LOGO.svg"),
        new("ERP Dashboard", "ASP.NET Core, Chart.js", "Management dashboard for visualizing Power Division ERP data, operations, and performance insights.",
            new[] { "Contributed to ERP dashboard UI development with interactive Chart.js visualizations." },
            "Orion Informatics Ltd", "Orion_LOGO.png"),
        new("Identity Protection", "React", "A US-based client project focused on management workflows, reusable React components, and interactive user experiences.",
            new[] { "Resolved UI bugs and frontend issues, while refactoring React components to improve code readability, structure, and maintainability.", "Reduced code redundancy and streamlined page implementations, improving overall code quality and making the application easier to maintain and extend." },
            "Orion Informatics Ltd", "Orion_LOGO.png"),
        new("LikeHome.Care", "Flutter (Dart), Firebase", "Mobile platform connecting caregivers with families for in-home care services and streamlined registration.",
            new[] { "Built the caregiver registration and profile flow for onboarding service providers.", "Implemented the parent-facing search experience for finding nearby caregivers." },
            "Independent Client Project", "")
    };

    public static readonly List<AcademicProject> Academics = new()
    {
        new("AI-Powered E-Commerce Platform", "ASP.NET Core, PostgreSQL/pgvector, Terraform, Azure DevOps, Docker, Kubernetes, Azure OpenAI",
            "Full-stack e-commerce app with multi-environment cloud infrastructure fully defined as code, deployed both locally and to Azure Kubernetes Service (AKS).",
            "", "", "",
            new[] { "Terraform-provisioned Azure resources via Azure DevOps CI/CD", "Containerized with Kubernetes, Kustomize overlays for dev/staging/prod", "Semantic product search using RAG and vector embeddings", "AI content-generation admin tool and shopping-assistant chatbot with LLM function calling", "Managed Identity authentication throughout, no API keys" }),
        new("Cricket Live Streaming with Live Score", "Flutter, React, ASP.NET Core, Firebase",
            "A complete live cricket streaming solution with real-time score updates and match history.",
            "https://github.com/RI-Sujon/CricketLiveStreamingWithLiveScore/tree/dev", "", "",
            new[] { "Live video streaming via Agora SDK", "Real-time score updates with Firebase", "Three Android devices for video, commentary and scoring", "Match history and statistics" }),
        new("Tutors Planet", "Android (Java), Firebase",
            "Mobile app connecting guardians with qualified tutors for personalized education.",
            "https://github.com/RI-Sujon/TutorsPlanet", "", "",
            new[] { "Tutor-guardian matching system", "Student management modules", "Real-time chat functionality", "Rating and review system" }),
        new("Attendance Management System", "Angular, ASP.NET Core, MSSQL",
            "Admin portal for managing courses, teachers and students with live attendance tracking.",
            "https://github.com/RI-Sujon/AttendanceManagementSystemFrontEnd", "https://github.com/RI-Sujon/AttendanceManagementSystemBackEnd", "",
            new[] { "Course and teacher management", "Live attendance tracking", "Student announcements", "Admin dashboard" }),
        new("Stocker.io", "Angular, Django",
            "Stock market analysis and data visualization website for financial insights.",
            "https://github.com/Jahid1999/stocker-10-frontend", "", "",
            new[] { "Real-time stock data", "Interactive charts", "Portfolio tracking", "Market analysis tools" }),
        new("Web Scraping and Parsing Library", "C",
            "Custom library to extract structured data from HTML pages efficiently.",
            "https://github.com/RI-Sujon/SPL1", "", "",
            new[] { "HTML parsing engine", "CSS selector support", "Memory efficient", "Cross-platform compatible" }),
        new("Prescription Management System", "Angular, ASP.NET Core, MSSQL",
            "Platform for doctors to track patients and manage prescriptions digitally.",
            "https://github.com/RI-Sujon/Online-Prescription-Angular", "https://github.com/RI-Sujon/Online-Prescription-DotNet", "",
            new[] { "Patient records management", "Digital prescriptions", "Medical history tracking", "Appointment scheduling" }),
        new("Library Management System", "Angular, Laravel, MSSQL",
            "Complete website for book circulation and member records management.",
            "https://github.com/RI-Sujon/Library-Management-System-FrontEnd", "", "",
            new[] { "Book catalog system", "Member management", "Borrowing and returns", "Fine calculation" }),
        new("Face Mask Detection", "Java",
            "Image processing project detecting mask usage with high accuracy.",
            "https://github.com/RI-Sujon/DBMS2_Project_Mask_Detection", "", "",
            new[] { "Real-time detection", "High accuracy ML model", "Multiple face support", "Alert system" }),
        new("Wumpus World, Gomoku Games", "Android (Java)",
            "Two interactive Android AI games with intelligent opponents.",
            "https://github.com/RI-Sujon/WumpusWorldGame", "", "",
            new[] { "AI-powered opponents", "Multiple difficulty levels", "Score tracking", "Intuitive UI" })
    };
}
