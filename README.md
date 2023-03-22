# IRISTechTask

<ins>**Scope of the Project**</ins></br>
This project demonstrates a single HTTP GET operation, where it fetches bank data from the SQL Server database, based on
given bank id. I have not created any othe application to consume the API, as the output can be viewed by using Postman/Swagger or can also be viewed by running the API project in the browser and providing available bank ID.


<ins>**Overview**</ins></br>
This project returns bank name and bank head office location, based on the given bank id.

<ins>**Technologies Used**</ins>
1) ASP.NET CORE API (.NET Framework 6.0)</br>
2) Entity Framework 7.0.4</br>
3) SQL Server 2019 (Express Edition)


<ins>**Approach Taken**</ins>
1) I am using .NET Core API considering the following points:</br>
   a) The file structure is compact and easy to understand as compared to Asp.Net Web API.</br>
   b) It can be run in multiple platforms - windows/mac/linux</br>
   c) It has got in-built dependency injection feature, where we need to register the services in "Program.cs" file and
      .NET Core takes care of creating the objects on "Scoped" lifetime. Dependency Injection helps us to write down loosely
      coupled code, which is quite helpful in case of unit testing as well.</br>
   d) .NET Core is much faster compared to Asp.Net web api, because of the .NET Core architecture, where the Microsoft team
      have completely rewritten the library classes, removing the things not needed. It also returns JSON result by default,
      which is more lightweight and applicable for most of the devices. Earlier, in Asp.Net Web API, it used to return XML
      response by default and we had to specify the JSON formatter in the config file.</br>
   e) It also got in-built Swagger service, which works as API documentation.

2) I am using Entity Framework Code First Approach using data annotations, considering the following points:</br>
   a) I am creating the application from scratch and there was no such existing database for it. Code First is recommended
      for the applications where no such existing database is present. It help the developers to create and manage the database
      tables through C# code, with full control on it, rather shuffling between SQL Server Management Studio and Visual Studio.</br>
   b) Code First Approach is recommended for smaller applications. This is a small demo application and so thought of using this
      approach here.</br>
   c) Code First approach gives us "migration" files automatically, on executing "Add-Migration" command, which can be treated as
      scripts file and can be run into any other machine for creating the database and seeding initial data, provided the connection string
      need to be changed accordingly.</br>
      In case of DB First approach, we have to generate scripts manually for those tables and need to be supplied separately.</br>
   d) In case of upgrading/downgrading to any specific migration, its quite easier to do it using Code First approach but maintaining the same
      in DB First approach may be difficult to be remembered always, which may cause data inconsistency.

<ins>**File Struture**<ins>
1) ***Controllers*** - Containing a single controller named as BanksController, with a single GET endpoint "GetBankDetails(int bankid)" to demnstrate "GET endpoint name/{id}</br>
2) ***DAL*** - Containing DBContext class.</br>
3) ***Migrations*** - Containing database creation and data seeding migration files.</br>
4) ***Models*** - Containing Domain Model class representing BankDetails table in Sql Server.</br>
5) ***ViewModels*** - Containing View Model class for BankDetails, representing the data that need to be shown to the users.</br>
6) ***launchSettings.json*** - Containing all the necessary settins and configurations need to launch the API application.</br>
7) ***appsettings.json*** - containngn SQL connection string.</br>
8) ***program.cs*** - registering the services here so that those can be used as dependency injection when needed and .NET Core
                      will create the required instance for the dependent class.

<ins>**Explanation of how the overall code works**</ins></br>
When the user requests for the GET endpoint name/{id}, it initiates the SQL Connection, considering the connection string
provided in appSettings.json file and then cretes the instance of the DBContext, which is being injected into the controller
through Constructor. The instance will be created under Scoped lifetime, which means a new instance will be created per request.
</br>
It fetch the data asynchronously, using LINQ Extension methods and returning it back as JSON response. I have used async/await
so that if it takes time to fetch the data, the application should not get stuck unless the data is retrieved. It gives poor
customer experience. Instead the thread will be released to carry out other operations (if any) and a new thread will be assigned
once the data is fetched.

</br></br>
Thank you all.
