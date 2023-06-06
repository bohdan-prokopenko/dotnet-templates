# Project Title

MiniApi Project Template

## Description

This project template provides a starting point for creating web applications using the Minimal API approach in .NET. It leverages the `dotnet new` command to generate a basic project structure with minimal configuration and ceremony.

### What is Minimal API?

Minimal API is a lightweight approach introduced in ASP.NET Core 6.0 that simplifies the development of web applications by reducing the amount of boilerplate code and configuration required. It allows developers to define HTTP endpoints and routes using a minimalistic syntax, making it easier and faster to build APIs and web applications.

### Features

- **Minimal Configuration**: The project template generates a minimal set of files and configurations, eliminating unnecessary complexity and allowing developers to focus on writing code.

- **Lightweight Syntax**: The Minimal API approach uses a concise syntax for defining endpoints and routes, making it intuitive and straightforward to create HTTP-based services.

- **Rapid Development**: With the project template, you can quickly get started with developing your web application, thanks to the simplified setup and reduced ceremony.

- **Flexible and Extensible**: Despite its minimalistic nature, the Minimal API approach is highly flexible and extensible. You can easily add middleware, authentication, authorization, and other components to customize your application as needed.

- **Fast Endpoints**: The generated project template includes the Fast Endpoints library, which provides a high-performance routing and request handling framework for Minimal APIs. For more information, visit the [Fast Endpoints website](https://fast-endpoints.com/docs/get-started).

## Getting Started

To install the MiniApi project template, follow these steps:

1. Install the latest version of the .NET SDK on your machine.

2. Open a terminal or command prompt and navigate to the directory where you have downloaded or cloned this project.

3. To install the template download source or the latest release from the [Releases](https://github.com/bohdan-prokopenko/dotnet-templates/releases) page.
Run the following command if you want to install from sources:
```shell
dotnet new -i ./mini-api-template
```
or if you want to install from the [Releases](https://github.com/bohdan-prokopenko/dotnet-templates/releases):
```shell
dotnet new -i MiniApi.Template.2.0.0.nupkg
```

To create a new MiniApi project, follow these steps:

1. Open a terminal or command prompt and navigate to the directory where you want to create your project.

2. Run the following command to create a new project using the MiniApi template:

3. Once the project is created, navigate to the project directory:

4. Run the project using the following command:
```shell
dotnet new mapi
```
```shell
cd MyMiniApiProject
```
```shell
dotnet run
```

5. Open your web browser and navigate to `http://localhost:5000/hello` to see the MiniApi welcome page.

## Contributing

Contributions to this project are welcome! If you encounter any issues or have suggestions for improvements, please open an issue or submit a pull request on the project's GitHub repository.

## License

This project is licensed under the [MIT License](LICENSE.txt). Please see the [LICENSE](LICENSE.txt) file for more details.

## Resources

- [ASP.NET Core documentation](https://docs.microsoft.com/aspnet/core)
- [Minimal APIs in ASP.NET Core 7.0](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0)
- [Fast Endpoints Website](https://fast-endpoints.com/docs/get-started#create-project-install-package)

## Acknowledgments

We would like to express our gratitude to the ASP.NET Core team for introducing the Minimal API approach and providing excellent documentation and resources. Their efforts have greatly simplified web application development in .NET.

## Authors

- Bohdan Prokopenko
