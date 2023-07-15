### Scaffold DiAPI .Net Project version 6.0

---

### Dependency Injection (DI)

- Dependency Injection (DI) is a Design Pattern
- Used predominantly in Object Oriented Programming (OOP)
- Aims to allow us to develop "loosely-coupled" code
- With primary aim of making our code more maintainable

---

### Ingredients

1. .NET 6 SDK (free)
2. VSCode (free): https://code.visualstudio.com/download
3. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download

---

### Terminal (PowerShell) commands for create project and files

1. Check the version of .NET:
    - ```dotnet --version```
2. Create new minimal API project with name Dependency injection API:
    - ```dotnet new webapi -minimal -n DiAPI --framework net6.0```
3. Create gitignore file:
    - ```dotnet new gitignore```
4. Restore Project:
    - ```dotnet restore```
5. Build Project:   
    - ```dotnet build```
6. Run project:
    - ```dotnet run```
7. Create folders and files:
    - ```mkdir Data```
        - ```New-Item IDataRepo.cs```
        - ```New-Item NoSqlDataRepo.cs```
        - ```New-Item SqlData.cs```-
    - ```mkdir DataServices```
        - ```New-Item IDataService.cs```
        - ```New-Item HttpDataService.cs```
    - ```mkdir Middleware```
        - ```New-Item CustomMiddleware.cs```
    - ```mkdir Utility```
        - ```New-Item IOperation.cs```
        - ```New-Item Operation.cs```

        Just for check: delete file or folder: ```Remove-Item FileName/FolderName```

---

### The Project use current Packages:
    - Swashbuckle.AspNetCore