#!/bin/sh

dotnet ef migrations add $1 -p ./src/Infrastructure -s ./src/WebAPI -o ./Persistence/Migrations