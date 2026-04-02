
# Chemical Laboratory Management System (CLMS) 🧪

## 📌 Project Overview

Chemical Laboratory Management System (CLMS) është një aplikacion i zhvilluar për menaxhimin e inventarit kimik, kërkesave laboratorike dhe operacioneve bazë të një laboratori.

Ky projekt është realizuar në kuadër të një detyre akademike për të demonstruar:
- organizimin e kodit sipas arkitekturës me shtresa
- implementimin e Repository Pattern
- aplikimin e parimeve SOLID
- dokumentimin profesional të sistemit

---

## 🏗 Architecture Overview

Projekti ndjek **Layered Architecture (N-Tier Architecture)**, duke ndarë përgjegjësitë në mënyrë të qartë midis shtresave.

Kjo qasje përmirëson:
- mirëmbajtjen e kodit
- testueshmërinë
- fleksibilitetin e sistemit

---

## 📂 Project Structure

```bash
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

✔ Vetëm struktura të dhënash
✔ Pa logjikë biznesi
✔ Atributet private, metodat public

2️⃣ Data Layer

Implementon Repository Pattern për menaxhimin e të dhënave.

📌 Interface: IRepository
public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Save();
}
📌 Implementimi: FileRepository

Ruajtje në file CSV

Lexim nga file

Operacione bazë CRUD

✔ Abstraction
✔ Decoupling nga storage
✔ Lehtësi për testim

3️⃣ Services Layer

Shembull: ChemicalService

Përgjegjësitë:

Validimi i të dhënave

Logjika e biznesit

Komunikimi me repository

public void AddChemical(Chemical chemical)
{
    _repository.Add(chemical);
    _repository.Save();
}
4️⃣ UI Layer

Përmban ndërveprimin me përdoruesin.

✔ Program.cs minimal (vetëm inicializim)
✔ Nuk përmban business logic
✔ Vetëm orchestration

📊 UML Class Diagram

Diagrami i klasave ndodhet në:

docs/class-diagram.md

Përmban:

klasat

atributet (private)

metodat (public)

relacionet mes klasave

🧠 Design Decisions

Layered Architecture është përdorur për ndarje të qartë të përgjegjësive dhe mirëmbajtje më të lehtë.

Repository Pattern lejon ndryshim të mënyrës së ruajtjes së të dhënave pa ndikuar në business logic.

CSV File Storage është zgjedhur për thjeshtësi dhe për të shmangur kompleksitetin e databazave në këtë fazë akademike.

Përdorimi i interfaces rrit fleksibilitetin dhe testueshmërinë e kodit.

🔁 Repository Pattern Implementation

Ky projekt përdor Repository Pattern për:

abstraktimin e aksesit në të dhëna

modularitet

mirëmbajtje më të lehtë

CRUD operacionet:

GetAll()

GetById()

Add()

Save()

🧠 Applied Design Principles
✅ Separation of Concerns

Çdo shtresë ka një rol të qartë dhe të ndarë.

✅ SOLID Principles

SRP (Single Responsibility Principle)
Çdo klasë ka vetëm një përgjegjësi.

DIP (Dependency Inversion Principle)
Services varen nga IRepository, jo nga implementimi konkret.

🚀 How to Run
git clone https://github.com/Hataz511/Chemical-Laboratory-Management-System1.git
cd backend
dotnet run
📌 Academic Note

Ky projekt është ndërtuar për të përmbushur kërkesat e një detyre akademike dhe demonstron zbatimin praktik të arkitekturës së softuerit.

🎯 Conclusion

Ky projekt demonstron:

organizim profesional të kodit

ndarje të qartë të shtresave

implementim korrekt të Repository Pattern

përdorim të parimeve SOLID

dokumentim teknik të strukturuarin praktik të arkitekturës së softuerit në një sistem laboratorik.
