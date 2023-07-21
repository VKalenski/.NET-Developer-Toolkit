### Ingredients

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Git (free)
4. GitHub Account (free)
    - GitHub Desktop (free): https://desktop.github.com/
5. Azure DevOps account (free): https://azure.microsoft.com/en-us/products/devops
6. Azure account (free sign up / but potential on-going costs): https://azure.microsoft.com/en-us/get-started/azure-portal

---

### CI/CD

Continuous Integration / Continuous Delivery
or
Continuous Integration / Continuous Deployment

Foundational concept in Agile Software Development (DevOps)


#### Continuous Integration

- Taking code from one or more developers and building and testing that code to ensure those changes do not break the build
- Usually triggered when developers "check-in" code changes to a code repository (e.g. GitHub)
- Allows multiple changes to be Continuous Integrated

#### Continuous Delivery / Deployment

1. Continuous Delivery
    - Extension of CI, concerned with automating the Release process
    - Ensures that you can deploy changes frequently at press of a button (manual)
    - Stops short of automating the changes in to Production

2. Continuous Deployment
    - Goes further than Continuous Delivery
    - Code changes will make their way into Production without manual intervention assuming there are not failures
    - Requires a high level or organizational maturity

---

### Azure DevOps

- Cloud-based collection of tools that allow development teams to build and release software, includes features like:
    - Planning Boards
    - Code Repository
    - CI/CD Pipelines
    - Test Plans

Alternatives:
    - GitHub (also Microsoft)
    - Buildkite
    - Circle CI
    - Jenkins
    - Werker

---

- dotnet --version
- git --version
- gh --version
- mkdir ToDoAPI    
    - mkdir src
        - ```dotnet new webapi -minimal -n ToDoAPI --framework net6.0```
    - mkdir test
        - ```dotnet new xunit -n ToDoAPI.Tests --framework net6.0``` 
    - ```dotnet new sln --name ToDoAPISolution```
    - ```dotnet sln ToDoAPISolution.sln add src/ToDoAPI/ToDoAPI.csproj test/ToDoAPI.Tests/ToDoAPI.Tests.csproj```
    - ```dotnet add test/ToDoAPI.Tests/ToDoAPI.Tests.csproj reference src/ToDoAPI/ToDoAPI.csproj```
    - ```dotnet new gitignore```
    - git config --list
    - git status
    - git add .
    - git commit -m "Initial Create"
    - git push origin main
    - git logs
    - git branch -M main
    -git push -u origin main


---



