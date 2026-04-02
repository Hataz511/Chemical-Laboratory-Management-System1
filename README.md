
📄 README.md 
# Chemical Laboratory Management System (CLMS) 🧪

## 📌 Project Overview

Chemical Laboratory Management System (CLMS) është një aplikacion për menaxhimin e inventarit kimik, kërkesave laboratorike dhe operacioneve bazë të një laboratori.

Ky projekt është realizuar në kuadër të një detyre akademike dhe demonstron:

- organizimin e kodit sipas arkitekturës me shtresa (Layered Architecture)
- implementimin e Repository Pattern
- aplikimin e parimeve SOLID
- ndarjen e përgjegjësive (Separation of Concerns)
- dokumentimin teknik profesional

---

## 🏗 Architecture Overview

Projekti ndjek **Layered Architecture (N-Tier Architecture)** duke ndarë sistemin në shtresa të pavarura.

### 🎯 Përfitimet:
- mirëmbajtje më e lehtë
- kod më i organizuar dhe i lexueshëm
- fleksibilitet për ndryshime të ardhshme
- testueshmëri më e mirë

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
│   │   └── ConsoleUI.cs
│   │
│   └── Program.cs
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

Përmban entitetet:

Chemical

ChemicalRequest

User

✔ Vetëm struktura të dhënash
✔ Pa logjikë biznesi
✔ Atributet të encapsulated (private / properties)

2️⃣ Data Layer

Implementon Repository Pattern.

📌 Interface: IRepository
public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Save();
}
📌 Implementimi: FileRepository

Ruajtje e të dhënave në file CSV

Lexim nga file CSV

Operacione bazë CRUD

✔ Përfitimet:

Abstraction nga storage

Decoupling

Lehtësi për testim dhe ndryshim të storage (p.sh. DB në të ardhmen)

3️⃣ Services Layer

Shembull: ChemicalService

Përgjegjësitë:

Validimi i të dhënave

Logjikë biznesi

Thirrje e repository

public void AddChemical(Chemical chemical)
{
    _repository.Add(chemical);
    _repository.Save();
}
4️⃣ UI Layer

Implementuar me ConsoleUI.

✔ Ndërveprim me përdoruesin
✔ Nuk përmban business logic
✔ Thirr vetëm Services

5️⃣ Program.cs
static void Main(string[] args)
{
    var repo = new FileRepository<Chemical>("chemicals.csv");
    var service = new ChemicalService(repo);
    var ui = new ConsoleUI(service);

    ui.Start();
}

✔ Minimal (vetëm inicializim)
✔ Respekton arkitekturën

📊 UML Class Diagram

Diagrami gjendet në:

docs/class-diagram.md

Përmban:

klasat

atributet (private)

metodat (public)

relacionet (association, dependency)

🧠 Design Decisions

Layered Architecture → ndarje e përgjegjësive dhe mirëmbajtje më e lehtë

Repository Pattern → izolim i logjikës së aksesit në të dhëna

CSV Storage → zgjidhje e thjeshtë për fazë akademike

Interfaces (IRepository) → fleksibilitet dhe testueshmëri

🔁 Repository Pattern Implementation

Ky projekt përdor Repository Pattern për:

abstraktimin e aksesit në data

modularitet

mirëmbajtje

CRUD operacionet:

GetAll()

GetById()

Add()

Save()

🧠 Applied Design Principles
✅ Separation of Concerns

Çdo shtresë ka një rol të ndarë dhe të qartë.

✅ SOLID Principles

SRP (Single Responsibility Principle)
Çdo klasë ka një përgjegjësi të vetme.

DIP (Dependency Inversion Principle)
Services varen nga interface (IRepository), jo nga implementimi konkret.

⚠️ Limitations

Nuk përdoret databazë reale (përdoret CSV)

Nuk ka autentifikim përdoruesi

Nuk ka GUI (vetëm Console UI)

🔮 Future Improvements

Integrim me databazë (SQL Server / MySQL)

Ndërtimi i një GUI (WinForms / Web)

Shtimi i autentifikimit dhe roleve

Implementim i logging dhe error handling

🚀 How to Run
git clone https://github.com/Hataz511/Chemical-Laboratory-Management-System1.git
cd backend
dotnet run
📌 Academic Note

Ky projekt është ndërtuar për qëllime akademike dhe demonstron zbatimin praktik të arkitekturës së softuerit dhe dizajnit të sistemeve.

🎯 Conclusion

Ky projekt demonstron:

organizim profesional të kodit

arkitekturë të ndarë në shtresa

implementim korrekt të Repository Pattern

përdorim të parimeve SOLID

dokumentim teknik të strukturuar dhe të qartë

dokumentim teknik të strukturuarin praktik të arkitekturës së softuerit në një sistem laboratorik.
