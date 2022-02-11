ARG VERSION=3.1-alpine3.10
FROM mcr.microsoft.com/dotnet/core/aspnet:$VERSION 
RUN adduser \
  --disabled-password \
  --home /app \
  --gecos '' app \
  && chown -R app /app
USER app

# Add some libs required by .NET runtime 
# https://github.com/dotnet/core/blob/master/Documentation/build-and-install-rhel6-prerequisites.md#troubleshooting
#RUN apk add --no-cache libstdc++ libintl icu

EXPOSE 80
EXPOSE 443

# Copy 
WORKDIR /app
COPY ./publish ./
#COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "COT.API.dll"]