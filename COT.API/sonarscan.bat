dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /k:"COT-API-Test" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="5628db972a34af26f097f91644441fe180b1e0e1"
dotnet build
dotnet sonarscanner end /d:sonar.login="5628db972a34af26f097f91644441fe180b1e0e1"