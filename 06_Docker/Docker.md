### 

---

### Ingredients

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Docker (optional to set up SQL Server) (free): https://www.docker.com/products/docker-desktop/
4. Web Browser or API Client (Postman or Insomnia)
    - Postman  (free): https://www.postman.com/downloads/
    - Insomnia (free): https://insomnia.rest/download
5. Azure DevOps account (free): https://azure.microsoft.com/en-us/products/devops
6. SQL Server Management Studio (free)): 
    *(or DBeaver for Linux or Mac users)*

---

### Docker

Docker is containerization platform, meaning that it enables you to package, (build), your applications into images and run them as "containers" on any platform that can run Docker.


### Images vs Containers

1. Image: pre-build application, ready to run on Docker
    - You can get 1000's of pre-build images from Docker Hub
    - We will use a SQL Server Image
    - We will create an app and build our own Image
2. Container: a running image


### Why use it?

- Easy of Deployment (avoids "it works on my machine" argument)
- Assist Development: you can spin up containers without painful set up and config
- The can be "orchestrated"
    - They underpin most microservices architectures

### Benefits of Docker Compose

- Reduces reliance on, and simplifies use of, Docker CLI
- Allows you to start multiple containers quickly
- Provides networking between containers

---

- Install WSL
Check all installed Linux distributions: 
- wsl -l -v
Check Docker installation:
- docker
Docker login
- docker login
Check Docker version
- docker --version
List all containers:
- docker ps
- docker images

- docker pull mysql
- docker pull mcr.microsoft.com/mssql/server:2022-latest
- docker pull rabbitmq
- docker pull redis

