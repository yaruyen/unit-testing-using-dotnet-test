#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
ENV http_proxy http://10.160.3.88:8080/
ENV https_proxy http://10.160.3.88:8080/
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY /app/publish .
ENTRYPOINT ["dotnet", "fakeRA2.dll"]