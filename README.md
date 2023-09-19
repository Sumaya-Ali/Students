# Students
N Tier Architecture - dotNet Core6 MVC CRUD & AutoMapper library

first of all, we create 3 basic layers:
1. Data Access layer to deal with DB
2. Object layer for c# classes
3. Business layer to deal with logic, validation, etc.
and all of that according to the main project with controllers, modules & views

then we add references for the project:
Main project --> Business layer & object layer
Business layer --> object layer & data access layer
Data Access layer --> object layer

All the classes in Modules -that deal with Migration Issues (Code first) - need to be converted to equivalent c# classes in the object layer-- for that we use the AutoMapper.

All the classes in the Business layer & Data Access layer need to have Interfaces and we register all of them in the program.cs (Dependency Injection)

We added the Nuget packages (SQL Server, Entity Framework Core, Tool,..) to the Data Access layer project. however, we added (Design & real-time compilation in the Main Project).

The reason why we adding interfaces & classes to Dependency Injection is that we can now pass parameters in constructors and in that way inject the controller in the Main project
with the appropriate function in the Business layer easily and the last one injects the Data Access layer.

Automapper converts objects between Modules and the Object layer easily.

All the operations of migration, DB context & modules took place in the Data Access layer, Modules exist not in the Main project.

![image](https://github.com/Sumaya-Ali/Students/assets/52631071/1d715bd4-5a99-40c0-ad42-1d9263b40379)

![image](https://github.com/Sumaya-Ali/Students/assets/52631071/edd4c787-f87d-4220-b8ba-f395a43d5fcf)

![image](https://github.com/Sumaya-Ali/Students/assets/52631071/53a7c909-90b7-41c9-92a0-a3ddcf4c5090)

![image](https://github.com/Sumaya-Ali/Students/assets/52631071/beb54649-9ae2-44f8-803d-c6713673c3b7)



