# Azure Blob Storage ASP.NET Core API
> A simple ASP.NET Core Web API to make CRUD operations against a Azure Storage Container for interacting with Azure Blobs.

You can find the fill guide on how this API was made with detailed instructions for configuration of Azure + API here: [How to use Azure Blob Storage in an ASP.NET Core Web API to list, upload, download, and delete files](https://christian-schou.dk/how-to-use-azure-blob-storage-with-asp-net-core/).

## Development Setup (Docker)

1. Clone project to local machine
2. Open solution file 
3. Choose to start the `docker-compose` launch settings

N'joy :-)

The above steps will start [Azurite storage emulator](https://docs.microsoft.com/en-us/azure/storage/common/storage-use-azurite?tabs=visual-studio), 
[Seq](https://datalust.co/seq) log server and the API. The services will be started by
the definitions in the docker-compose.yml file

All Docker container logs will also be sent to the Seq log server.

To see all logs, open http://localhost:5341/

Running Docker requires that you have installed [Docker Desktop for Windows](https://docs.docker.com/desktop/install/windows-install/).


## Development Setup

Azure:

1. Create Storage Account
2. Create Container
3. Get Connection String from Access Keys in Storage Account

API:

1. Fork project or copy code
2. Change Connection String with the one from your Azure Storage Account in appsettings.json
3. Run the Application

## Usage

- Upload file
- Get Files
- Download file
- Delete file

## Changelog

* 0.1.0
    * Update Readme 
    * Added Readme
* 0.0.1
    * Initial Commit

## Meta

Christian Schou – [My tech blog](https://christian-schou.dk/). Feel free to connect with me on [LinkedIn](https://www.linkedin.com/in/chrschou1996) as well.

Distributed under the MIT license. See ``LICENSE`` for more information.

[https://github.com/Christian-Schou/](Follow me on Github)
