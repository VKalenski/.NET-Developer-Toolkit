### Scaffold DTO API .Net Project version 6.0

---

### Data Transfer Objects (DTO)

- DTOs allow you to decouple internal models from external facing consumers
- DTOs are external facing, used in the "transport of data", both:
    - Outbound (e.g. Read operations);
    - Inbound (Create and Update operations).
- DTOs makes code more maintainable:
    - Your internal data representations are not bound to (external) consumer contracts.
- You have more control over what external clients see, e.g.:
    - Security sensitive properties in your internal models don`t need to be exposed via DTOs.

---

### Object Mapping

- The ability to trace or "map" properties between objects
    - Map from a Source object properties to a Destination object properties
- Can be done manually
    - Laborious and prone to error
- Alternatively use of a mapping framework
    - E.g. AutoMapper

---

### AutoMapper
    
- Popular mapping framework in .NET
- Mapping are set up using Profiles (automatic mappings established)
- Mapping can have rules and vary depending on the direction of data
    - Mapping Read vs Create and Update operations;
    - Mapping using profiles (property names are different)
    - Changing the type of data
    - Null substitution
    - Custom Resolvers (calculate stuff when mapping)
- Used anywhere that you need to map objects (not just DTO / API use-case)

---

### Ingredients

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/
4. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download

---

1. Check the version of .NET and info:
    - ```dotnet --version```
    - ```dotnet --info```
2. Create new minimal API project with name Dependency injection API:
    - ```dotnet new webapi -minimal -n PersonalAPI --framework net6.0```
3. Create gitignore file:
    - ```dotnet new gitignore```
4. Restore Project:
    - ```dotnet restore```
5. Build Project:   
    - ```dotnet build```
6. Run project:
    - ```dotnet run```
7. Create folders and files:
    - ```New-Item PersonAPI.md```
    - ```New-Item docker-compose.yaml```
    - ```mkdir Data```
        - ```New-Item AppDbContext.cs```
    - ```mkdir Dtos```
        - ```New-Item PersonBaseDto.cs```
        - ```New-Item PersonCreateDto.cs```
        - ```New-Item PersonReadDto.cs```
        - ```New-Item PersonUpdateDto.cs```
    - ```mkdir Models```
        - ```New-Item Person.cs```
    - ```mkdir Profiles```
        - ```New-Item AgeResolver.cs```
        - ```New-Item FullNameResolver.cs```
        - ```New-Item IntTypeConverter.cs```
        - ```New-Item PeopleProfile.cs```

        Just for check: delete file or folder: ```Remove-Item FileName/FolderName```

---

### Migrate Data

Docker setup
1. Check Docker installation:
    - docker
2. Check Docker version:
    - docker --version
3. Docker up
    - docker compose up -d
4. Docker check containers
    - docker ps
5. Docker stop
    - docker compose stop

Create Migrations:
- dotnet-ef
- dotnet-ef migrations add 'InitialCreate'
- dotnet-ef database update

---

1. .NET Commands to add packages:
- dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer

---

### The Project use current Packages:
    - Swashbuckle.AspNetCore