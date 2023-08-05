### **Scaffold DiAPI .Net Project version 6.0**

>[1. Dependency Injection](#dependency-injection)
>
>[2. Ingredients](#Ingredients)
>
>[3. Terminal Commands](#terminal-commands)

---

### **Dependency Injection**

- Dependency Injection (DI) is a Design Pattern
- Used predominantly in Object Oriented Programming (OOP)
- Aims to allow us to develop "loosely-coupled" code
- With primary aim of making our code more maintainable

---

### **Ingredients**

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
4. GitHub Desktop (free): https://desktop.github.com/

---

### **Terminal Commands**

> **Check the version of .NET:**
```
dotnet --version
```

> **Create new minimal API project with name Dependency injection API:**
```
dotnet new webapi -minimal -n DiAPI --framework net6.0
```

> **Create gitignore file:**
```
dotnet new gitignore
```

> **Restore Project:**
```
dotnet restore
```

> **Build Project:**
```
dotnet build
```

> **Run project:**
```
dotnet run
```

> **Create folders and files:**

    > **Create folder "Data":**
    ```
    mkdir Data
    ```

    In folder "Data" create current files:

    > **IDataRepo.cs:**
    ```
    New-Item IDataRepo.cs
    ```

    > **NoSqlDataRepo.cs**
    ```
    New-Item NoSqlDataRepo.cs
    ```

    > **SqlData.cs**
    ```
    New-Item SqlData.cs
    ```

    > **Create folder "DataServices":
    ```
    mkdir DataServices
    ```

    > **IDataService.cs**
    ```New-Item IDataService.cs```

    > **HttpDataService.cs**
    ```
    New-Item HttpDataService.cs
    ```

    > **Create folder "Middleware":
    ```
    mkdir Middleware
    ```

    > **CustomMiddleware.cs**
    ```New-Item CustomMiddleware.cs```

    > **Create folder "Utility":
    ```
    mkdir Utility
    ```

    > **IOperation.cs**
    ```New-Item IOperation.cs```

    > **Operation.cs**
    ```New-Item Operation.cs```

> **Just for check: delete file or folder:**
```
Remove-Item FileName/FolderName
```