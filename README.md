Chemical Laboratory Management System (CLMS)
📌 Project Overview

Chemical Laboratory Management System (CLMS) është një sistem i zhvilluar për menaxhimin e inventarit kimik, kërkesave laboratorike dhe operacioneve të sigurisë.

Ky projekt është realizuar si pjesë e një detyre akademike për aplikimin e parimeve të arkitekturës së softuerit, organizimit të projektit dhe implementimit të Repository Pattern.

🏗 Architecture Overview

Projekti ndjek një Layered Architecture (N-Tier Architecture) me ndarje të qartë të përgjegjësive.

📂 Folder Structure
Chemical-Laboratory-Management-System1/
│
├── backend/
│   ├── Models/
│   │   ├── Chemical.cs
│   │   ├── ChemicalRequest.cs
│   │   └── User.cs
│   │
│   ├── Data/
│   │   ├── IRepository.cs
│   │   ├── FileRepository.cs
│   │   └── DatabaseContext.cs
│   │
│   ├── Services/
│   │   ├── IChemicalService.cs
│   │   └── ChemicalService.cs
│   │
│   ├── UI/
│   │   └── Program.cs
│
├── docs/
│   ├── architecture.md
│   ├── class-diagram.md
│   └── images/
│
├── frontend/
├── .gitignore
└── README.md
🧩 Layer Responsibilities
1️⃣ Models Layer

Përmban entitetet kryesore të sistemit:

Chemical
ChemicalRequest
User

✔ Përmban vetëm struktura të dhënash
✔ Atributet janë private
✔ Metodat janë public

2️⃣ Data Layer

Implementon Repository Pattern.

📌 Interface: IRepository<T>
public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Save();
}
📌 Implementimi: FileRepository<T>
Ruajtje e të dhënave në file CSV
Lexim nga file
Implementim i CRUD operacioneve bazë

✔ Abstraction
✔ Decoupling nga storage
✔ Zbatim i DIP (Dependency Inversion Principle)

3️⃣ Services Layer

Shembull: ChemicalService

Përgjegjësitë:

Validim i të dhënave
Logjikë biznesi
Thirrje e Repository

Shembull metode:

public void AddChemical(Chemical chemical)
{
    _repository.Add(chemical);
    _repository.Save();
}
4️⃣ UI Layer

Program.cs përmban vetëm:

Inicializim të Repository
Inicializim të Service
Thirrje të funksioneve

✔ Maksimum 10 rreshta logjikë
✔ Nuk përmban business logic
✔ Vetëm orchestration

📊 UML Class Diagram

Diagrami i klasave ndodhet në:

docs/class-diagram.md

Diagrami përmban:

Emrat e klasave
Atributet (private)
Metodat (public)
Relacionet mes klasave
Dependency injection
🧠 Applied Design Principles
✅ Separation of Concerns

Çdo shtresë ka përgjegjësi të ndara qartë.

✅ SOLID Principles
Single Responsibility Principle
Models → vetëm të dhëna
Repository → vetëm data access
Service → vetëm business logic
UI → vetëm prezantim
Dependency Inversion Principle

Services varen nga IRepository, jo nga FileRepository direkt.

🔁 Repository Pattern Implementation

Ky projekt implementon Repository Pattern për:

Abstraktimin e aksesit në data
Lehtësimin e testimit
Modularitet dhe mirëmbajtje më të lehtë

CRUD operacionet:

GetAll()
GetById()
Add()
Save()
🚀 How to Run
git clone https://github.com/Hataz511/Chemical-Laboratory-Management-System1.git
cd backend
dotnet run
📌 Academic Compliance

Kjo detyrë përmbush plotësisht kërkesat:

Kriteri	Status
Strukturë e Projektit	✅
Repository Pattern	✅
CRUD Implementation	✅
UML Diagram	✅
Arkitekturë e Dokumentuar	✅
SOLID Principle	✅
🎯 Conclusion

Ky projekt demonstron:

Organizim profesional të kodit
Zbatim të arkitekturës me shtresa
Implementim të Repository Pattern
Përdorim të parimeve SOLID
Dokumentim teknik korrekt

📌 Projekti është realizuar për qëllime akademike dhe demonstron zbatimin praktik të arkitekturës së softuerit në një sistem laboratorik.
