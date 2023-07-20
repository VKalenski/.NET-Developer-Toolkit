### Ingredients

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download

---

- ```dotnet --version```
- ```dotnet new webapi -minimal -n UserAPI --framework net6.0```
- ```code -r UserAPI```
- ```dotnet new gitignore```
- ```dotnet build```
- ```dotnet run```
- ```dotnet user-secrets init```
- ```dotnet user-secrets set "Password" "password"```


- dotnet new console -n CommandConfig --framework net6.0
- ```code -r CommandConfig```
- ```dotnet new gitignore```
- ```dotnet build```
- ```dotnet run```
- dotnet add package Microsoft.Extensions.Hosting
- ```dotnet user-secrets init```
- ```dotnet user-secrets set "Password" "user secrets password"```





- ```dotnet dev-certs https --trust```