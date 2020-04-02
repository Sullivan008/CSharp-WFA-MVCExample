# C# - WFA - How to use MVC Pattern in WFA Application [Year of Development: 2016 and 2020]

About the application technologies and operation:

### Technologies:
- Programming Language: C#
- FrontEnd Side: Windows Forms Application (WinForms)
- BackEnd Side: .NET Framework 4.6.1.

### Installation/ Configuration:

1. Restore necessary Packages, run the following command in **PM Console**

   ```
   Update-Package -reinstall
   ```
 
### About the application:

This example is used to demonstrate the **MVC Pattern** in **.NET using C#/WinForm**.

Here a simple application which is organized according the the Model-View-Controller(MVC) pattern.

The application displays a list of contacts and allows you to add, modify, and delete existing contacts.

The idea is to separate the **user interface** into **View** (creates the display) and **Controller** (*responds to user requests, interacting with both the View as necessary*). 

The main advantage of **MVC** pattern is **Loose Coupling**. All the layers are separated with their own functionality. It is easy to replace a layer with some other type of layer so in other words, **MVC** pattern is to break up UI behavior into separate pieces in order to increase reuse possibilities and testability.

The main advantage of using the **MVC Pattern** is that it makes the code of the user interface more testable.

It makes a very structured approach onto the process of designing the user interface, which in itself contributes to writing *clean, testable code*, that will be easy to maintain and extend

The **Model-View-Controller** is a well-proven design pattern to solve the problem of separating data (**Model**) and user interface (**View**) concerns, so that changes to the user interface do not affect the data handling, and that the data can be changed without impacting/changing the UI. The *MVC solves this problem* by decoupling data access and business logic layer from UI and user interaction, by introducing an intermediate component: the controller. 

This application you can store your customers' contact information. The application displays a list of contacts and allows you to add, modify, and delete existing contacts (deleting multiple existing contacts at once). All customers have an *ID, First Name, Last Name and Sex*. The screen that operator of this app uses to maintain his list of customers. After a new user is added, his ID cannot change anymore because is a generated unique GUID!
