# bike-repairing

# Back-end setup
- Download and install .NET 6 Runtime. https://dotnet.microsoft.com/en-us/download/dotnet/6.0
- Install .NET Core CLI. Run command: dotnet tool install --global dotnet-ef
- Create database on your local
- Change connection string in appsettings.json
- Open Powershell in folder WebAPI\WebAPI and run command: dotnet ef database update
- Build and run WebAPI project

# Front-end setup
- Download and install Node LTS version: https://nodejs.org/en
- Open Powershell in WebApp folder
- Run command: npm install -g @angular/cli
- Run command: npm install
- Run command: npm start
