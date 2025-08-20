# 📊 JoleraONE — Customer Portal Dashboard (Proof of Concept)
JoleraONE is a modern and interactive customer portal dashboard designed as a Proof of Concept for Jolera Inc. It allows clients to view and track real-time and historical IT system performance across key services such as:

🔄 Backup statuses and growth trends  
🎫 Helpdesk ticket metrics and resolution times  
🔐 Security alerts and performance scores  
📈 System KPIs and customer satisfaction 

## 👨‍💻 My Role -
As the Web developer, I am responsible for:

=> Translating business requirements into usable UI components  
=> Building reusable layouts (sidebar, topbar, metric cards)  
=> Creating KPI dashboards with Chart.js  
=> Implementing frontend interactivity and navigation logic  
=> Coordinating with my supervisor for milestone reviews and feedback  
=> Documenting usability and technical details  

## 🧰 Tech Stack  
Frontend: HTML, CSS, JavaScript, Chart.js  
Backend: .NET (Planned for dynamic data APIs)  
Data: JSON (mock data), SQL Server (future integration) 

## 📆 Project Timeline & Tools 

🎨 Figma Wireframes : https://www.figma.com/design/sMqy5IHP4yJkYRhgFPIoes/JolerONE?node-id=0-1&t=UMCdbYIitUaz1uD3-1

📄 Milestone Document : https://jolera365-my.sharepoint.com/:w:/g/personal/isha_shah_jolera_com/EUlEiUgx8OtJubPE8Ajhu6MBu1IPIk0t3iSOakCtk8Yvdg?e=0JAJO6

✅ Daily Milestone Tracker : https://docs.google.com/spreadsheets/d/1QYDtC-KtjGM6_-FqehA2ZcJp9qgy6kpTlmOs8lVAabI/edit?usp=sharing

⏱️ Project Timesheet : https://jolera365-my.sharepoint.com/:x:/g/personal/isha_shah_jolera_com/EQLjn6CjxAtJm9g99vBWQmcBY1Ydqw8yRBJgzNkDkcLYdQ?e=jLOQVt

## 🧪 Features In Development  
=> Modular views for each service (Helpdesk, Backup, Security, etc.)  
=> Reusable sidebar, topbar, and footer layout  
=> KPI widgets, charts, and status indicators   
=> Authentication (Login/Logout)  
=> Responsive design (desktop-first, tablet/mobile planned) 

## 📂 Folder Structure
```
JoleraONE/
│── JoleraONE.sln                # Solution file
│── JoleraONE.csproj             # Project definition
│── Program.cs                   # Application entry point
│── appsettings.json             # App configuration
│
├── Controllers/                  # Controllers for MVC routing
├── Views/                        # Views (HTML/CSS-based)
│   ├── Shared/                   # Layout, header, sidebar, footer
│   ├── SupportIT/                # Support IT dashboards
│   ├── StoreIT/                  # Store IT dashboards
│   ├── SecureIT/                 # Secure IT dashboards
│   └── ...                       # Other service modules
│
├── wwwroot/                      # Static assets
│   ├── css/                      # Stylesheets
│   ├── js/                       # JavaScript
│   └── lib/                      # Libraries (Chart.js, etc.)
│
└── .git/                         # Git repository files
```

---

## 🖥️ Installation & Setup

### ✅ Prerequisites
- Install **.NET 8 SDK** (or compatible version)  
- Install **Visual Studio 2022 / VS Code**  
- Install **Git**  

### ▶️ Steps to Run
1. Clone the repository [Optional]:  
   ```bash
   git clone <repo-url>
   cd JoleraONE
   ```

2. Restore dependencies:  
   ```bash
   dotnet restore
   ```

3. Build the project:  
   ```bash
   dotnet build
   ```

4. Run the project:  
   ```bash
   dotnet run
   ```

5. Open in browser:  
   ```
   http://localhost:5000
   ```

---

## 🚀 Usage
- Sidebar navigation allows switching between service dashboards.  
- Each service (SupportIT, StoreIT, SecureIT, etc.) includes metric panels, charts, and tables.  
- Data is currently **static** (dummy data only).  

---

## 👨‍💻 Developer Notes
- Modify **CSS** in `wwwroot/css/` for UI updates.  
- Update/add **views** under `Views/` for new service modules.  
- Add **charts** using Chart.js (place under `wwwroot/lib/`).  
- To extend project with real backend:
  - Add **Models** for database entities  
  - Implement **Controllers** for CRUD operations  
  - Connect to **SQL Server or MongoDB**  

---

## 📄 License
This project is developed as part of a **Proof of Concept Internship Project** for Jolera.  


