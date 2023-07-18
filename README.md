# Mini OpenLayers Web API

Mini OpenLayers Web API is a web application built using .NET 6.0, OpenLayers, and PostgreSQL. It allows users to add and delete locations, and display them on a map.

## Features

- **Location Management:** Users can add new locations, delete existing locations, and view all the locations on the map.
- **Map Display:** The application utilizes OpenLayers to display the locations on an interactive map.
- **REST API:** The application's API, located at http://localhost:5000/api/location, provides the following functions:
  - **GET:** Retrieve all locations.
  - **POST:** Add a new location.
  - **PUT:** Update an existing location.
  - **DELETE:** Remove a location.

## Requirements

- .NET 6.0 SDK installed on your machine.
- PostgreSQL database server.
- OpenLayers library for map functionality.

## Installation

1. Clone the repository or download the project files.

```bash
git clone https://github.com/selinvuslat/mini-openlayers-api.git
```

2. Update the database connection settings.

   - Open the `appsettings.json` file.

   ```bash
   cd mini-openlayers-app
   nano appsettings.json
   ```

   - Update the PostgreSQL connection string with your database information.

3. Build and run the application.

```bash
dotnet run
```

4. Access the application in your web browser.

```bash
http://localhost:5000
```

## Usage

1. Launch the Mini OpenLayers Application in your web browser.
2. Click on the map to add a new location. Provide the necessary details such as name, coordinates, etc.
3. Existing locations will be displayed on the map. Click on a location to view its details.
4. To delete a location, click on the delete button associated with the location on the map or in the details view.
5. Use the API endpoints at http://localhost:5000/api/location to interact with the locations programmatically.

## License
This project is licensed under the MIT License. For more information, see the [LICENSE](LICENSE) file.

## Issues, Feature Requests or Support
Please use the [New Issue](https://github.com/selinvuslat/mini-openlayers-api/issues/new) button to submit issues, feature requests or support issues directly to me. You can also send an e-mail to selinvuslat@gmail.com.
