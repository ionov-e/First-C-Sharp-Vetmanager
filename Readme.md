# C# project: Vetmanager Gateway API & Windows forms

![Vetmanager Logo](docs/logo-vetmanager.svg)

Vetmanager - a CRM service for veterinary clinics.

This project uses its REST API feature to provide CRUD functionality for Pets.

All REST API funtionality with DTOs was moved to a separete REST API package which was added to this project as dependency:
https://www.nuget.org/packages/VetmanagerApiGateway/

![Usage 1](docs/usage-1.gif)

## Features

- **Autosaving and autoloading last successful credentials**:
    
    - After every successful login via user-login and password an XML file (last_settings.xml) is created in execution directory.

    - At application start: autosearch wheter the XML file is already present and try to use its contents to connect to Vetmanager user base.

- **API Gateway Package** was made while performing this task. Link is provided above. If needed - it will be expanded into complete package providing all neccessary features and including all existing DTOs 