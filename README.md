# Ice Cream Shop

## Description

An Ice cream shop application with SQL and MongoDB database options.
Save your customers orders and get your shop statistics in the manager settings window.

**_Main Window:_**

<img src="https://user-images.githubusercontent.com/74299935/191500491-655a62b6-f207-452e-bce6-7974273218b6.jpg" width="80%">

- **Initalize DB**  - Reset the database
- **Manager Settings**  - Customer receipts , selling statistics and database options.
- **Reset Order**  - Send the order to the database as an uncompleted order.
- **Finish Order**  - Send the order to the database.

**_Manager Settings Window:_**

<img src="https://user-images.githubusercontent.com/74299935/191500565-2d4b43a8-1779-450d-864d-7250f30dad12.jpg" width="80%">

- **Change DB**  - Select which database you want to work with SQL (SSMS) or NoSQL (mongodb)
- **Daily Report**  - Enter a date and get a report of all sales made at that date. (number of sales, Income ,Average Daily Sales)
- **Unfinished Order**  - Show you the number of uncompleted orders in the database.
- **Current Bill**  - Bill that show the cost of the order.
- **Best Topping/Flavor**  - Show the most popular ice cream topping/flavor.
- **Best selling item**  - Show the most popular ice cream item in the shop.



## Requirement

- SQL Server Management Studio or a MongoDB database
- Visual Studio/ Visual Studio Code

## How to use

1. Clone repo
2. Run your SQL or a MongoDB database.
3. Enter your connection string in the connectSql/connectNoSql function in the DAL.cs/mongoDB_DAL.cs files.
4. Run the program
5. Press Manager Settings and seleced the DB you want to work with and close the Window.
6. Press Initalize DB button and wait untill the button is gray.
7. Order your ice cream and enjoy the rest of the functions.


## ERD and UML

### UML
![ClassDiagram1](https://user-images.githubusercontent.com/74299935/191016693-1bfc4a22-ea72-4682-9a2a-65f6bc568d7d.jpg)

### ERD
![ERD](https://user-images.githubusercontent.com/74299935/191016801-9d9c9f34-d8ed-4345-8c59-878644f12169.jpg)


## Authors
[Ilan Gold](https://github.com/IlanG96)
[Haim Or Hadad](https://github.com/Haim-Or)
