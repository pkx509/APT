#!/bin/sh

dotnet ef database drop -p ./src/Infrastructure -s ./src/WebAPI -f --no-build
