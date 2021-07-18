#!/bin/sh

dotnet ef migrations remove -p ./src/Infrastructure -s ./src/WebAPI
