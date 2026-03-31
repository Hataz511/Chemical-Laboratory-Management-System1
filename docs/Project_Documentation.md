# Chemical Laboratory Management System (CLMS) - Dokumentacion i Projektit

## Table of Contents
1. [Përmbledhje](#1-përmbledhje)  
2. [Funksionalitetet Kryesore](#2-funksionalitetet-kryesore)  
3. [Arkitektura e Projektit](#3-arkitektura-e-projektit)  
4. [Teknologjitë e Përdorura](#4-teknologjitë-e-përdorura)  
5. [Udhëzime për Përdorim](#5-udhëzime-për-përdorim)  
6. [Historiku i Commit-eve](#6-historiku-i-commit-eve)  
7. [Përmirësime të Arsyeshme](#7-përmirësime-të-arsyeshme)  
8. [Skedarët e Dokumentacionit](#8-skedarët-e-dokumentacionit)  
9. [Diagramat e Projektit](#9-diagramat-e-projektit)  

---

## 1. Përmbledhje
Ky projekt është një sistem për menaxhimin e laboratorëve kimikë. Qëllimi është të lehtësojë regjistrimin e eksperimentëve, menaxhimin e materialeve, dhe raportimin e rezultateve. Projekti është zhvilluar për të ndihmuar studentët dhe stafit të laboratorit të menaxhojnë punën ditore më efikasitet.  

Sistemi mbulon gjithashtu:  
- Auditimin e veprimeve laboratorike  
- Kontrollin e qasjes sipas roleve  
- Gjurmueshmërinë e kimikateve dhe pajisjeve  

---

## 2. Funksionalitetet Kryesore
- Regjistrimi i eksperimentëve të reja  
- Menaxhimi i materialeve dhe reagentëve  
- Raportimi i rezultateve të eksperimenteve  
- Krijimi i llogarive të përdoruesve dhe administrimi i tyre  
- Kontrolli i aksesit sipas rolit të përdoruesit  
- Alerts për skadim kimikatesh dhe stok të ulët  
- Rezervimi i pajisjeve laboratorike  
- Backup dhe restore të të dhënave  

---

## 3. Arkitektura e Projektit
Projektimi është bazuar në një **strukturë modulare**:

**Modulet kryesore:**  
- `User Management`: Krijimi i përdoruesve, autentikimi, Role-Based Access Control  
- `Chemical Inventory`: CRUD për kimikate, alerts, historik lëvizjesh  
- `Experiment Tracking`: Log eksperimenti, deduksion sasi automatik  
- `Equipment Management`: Rezervim pajisjesh dhe mirëmbajtje  
- `Safety & Incidents`: Regjistrim incidente, restriction për kimikate high-risk  
- `Reporting & Dashboard`: Shfaqje indikatorësh, eksport raporte  
- `Backup & Data Protection`: Backup automatik dhe restore  

> Klasa bazë: `Experiment`, `Material`, `User`, `Equipment`, `Incident`  

---

## 4. Teknologjitë e Përdorura
- **Gjuha e programimit:** C# / Java / Python  
- **Frontend:** React / Angular / Vue.js  
- **Backend:** Node.js + Express / Spring Boot / Django  
- **Database:** SQLite / MySQL / PostgreSQL  
- **Authentication:** JWT + 2FA (One Time Password)  
- **Version Control:** Git + GitHub  
- **IDE:** Visual Studio 2022 / IntelliJ / VS Code  
- **Diagram Tools:** Lucidchart / draw.io / StarUML  

---

## 5. Udhëzime për Përdorim
1. Klono repository-n:  
```bash
git clone https://github.com/Hataz511/Chemical-Laboratory-Management-System1.git
Hape projektin në Visual Studio ose IDE të preferuar.

Konfiguro database-n nëse përdoret SQLite/MySQL/PostgreSQL.

Fillo aplikacionin dhe krijo një llogari përdoruesi.

Shto eksperimentet, materialet dhe menaxho laboratorin sipas nevojës.

6. Historiku i Commit-eve

Commit 1: Strukturë fillestare dhe skedarët bazë

Commit 2: Funksionaliteti bazë i menaxhimit të laboratorit

Commit 3: Përmirësime, refactor dhe dokumentim

Commit 4: Shtim diagramash dhe dokumentacion teknik

Commit 5: Integrim 2FA dhe alerts për inventar

7. Përmirësime të Arsyeshme

Integrimi i më shumë funksionaliteteve për raportim statistikash

Shtimi i autentikimit me nivele të ndryshme përdoruesish

Pamje grafike (GUI) për përdorues më miqësor

Dashboard me alertet dhe statistika në kohë reale

Analitikë e avancuar dhe parashikim konsumi kimikatesh

8. Skedarët e Dokumentacionit

README.md – Përshkrimi i përgjithshëm i projektit

docs/Project_Documentation.md – Ky dokument i plotë

docs/ER_Diagram.png – Diagrami i Entitet/Relationship

docs/UseCaseDiagram.png – Diagrami Use Case

docs/SequenceDiagram.png – Workflow approval

tests/ – Testet për funksionalitetet e ndryshme

9. Diagramat e Projektit

Placeholder për diagramat kryesore:

ER Diagram: Lidhja mes tabelave User, Chemical, Experiment, Equipment, Incident

Use Case Diagram: Regjistrimi i eksperimentit, kërkesat për kimikate, aprovimet

Sequence Diagram: Multi-level approval workflow

Sugjerim: Përdor Lucidchart ose draw.io për të vizualizuar dhe eksportuar PNG/PNG/ PDF për GitHub