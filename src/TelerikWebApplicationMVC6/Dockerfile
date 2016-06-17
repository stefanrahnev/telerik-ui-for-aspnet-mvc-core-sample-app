FROM microsoft/dotnet:1.0.0-preview1

COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]

EXPOSE 5004
ENTRYPOINT ["dotnet", "-p", "project.json", "kestrel"]
