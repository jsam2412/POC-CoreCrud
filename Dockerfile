FROM microsoft/aspnetcore-build:1.1.2 AS build-env
WORKDIR /CoreCrud

# Copy csproj and restore as distinct layers
#COPY */*.csproj ./

# Copy everything else and build
COPY . ./

RUN dotnet restore ./CoreCrud/CoreCrud.csproj; 
#    dotnet restore ./CoreCrud.API/CoreCrud.API.csproj; \
#    dotnet restore ./CoreCrud.Data/CoreCrud.Data.csproj; \
#    dotnet restore ./CoreCrud.Repository/CoreCrud.Repository.csproj; \
#    dotnet restore ./CoreCrud.Service/CoreCrud.Service.csproj;


#RUN dotnet build ./CoreCrud/CoreCrud.csproj;
RUN dotnet publish "./CoreCrud/CoreCrud.csproj" -c Release -o ./out;

# Build runtime image
FROM microsoft/aspnetcore:1.1.2
WORKDIR /CoreCrud
COPY --from=build-env /CoreCrud/CoreCrud/out .
ENTRYPOINT ["dotnet", "CoreCrud.dll"]