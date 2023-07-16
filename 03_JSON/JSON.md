
---


7. Create folders and files:
    - ```mkdir SerializationApp```    
        - ```dotnet --version```
        - ```dotnet new console -n Serializer --framework net6.0```        
        - ```dotnet restore```
        - ```dotnet build```
        - ```dotnet run```        
        
    - ```mkdir DeserializationApp```
        - ```dotnet --version```
        - ```dotnet new console -n Deserializer --framework net6.0```
        - ```dotnet restore```
        - ```dotnet build```
        - ```dotnet run```
    - ```mkdir API```
        - ```dotnet new webapi -n WeatherAPI --framework net6.0```
        - ```code -r WheatherAPI```
    - ```New-Item JSON.md```

        Just for check: delete file or folder: ```Remove-Item FileName/FolderName```