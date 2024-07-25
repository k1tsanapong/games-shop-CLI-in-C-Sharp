# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project files
COPY . ./

# Restore and build the project
RUN dotnet restore ./main.sln
RUN dotnet publish ./main.sln -c Release -o out

# Use the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Set the working directory
WORKDIR /app

# Copy the built files
COPY --from=build /app/out .
COPY --from=build /app/data/ ./../data
# Install ttyd
RUN apt-get update && \
    apt-get install -y build-essential cmake git libjson-c-dev libwebsockets-dev && \
    git clone https://github.com/tsl0922/ttyd.git && \
    cd ttyd && \
    mkdir build && \
    cd build && \
    cmake .. && \
    make && \
    make install && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Expose the port
EXPOSE 8080

# Run the application with ttyd

RUN ls

CMD ["ttyd", "--writable", "-p", "8080", "-t", "fontSize=25", "dotnet", "main.dll"]
