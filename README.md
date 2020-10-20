# RubiconAssignment

Assignment for an Asp.Net Core REST API

Assignment details can be found [here](https://docs.google.com/document/d/1ainQIDk264nGpBuTzDXpqfEbvhnvdGRE4dQagoGt_IE/edit)


## Installation

The project comes with an existing SQLite database simply run the API and that's it!

To delete the existing database use command

```bash
Drop-Database
```
To create a new database use command

```bash
Update-Database
```

## Database Details

**Database Details**
- DB: **SQLite**
- ORM: **Entity Framework Core**

Code-First approach with Fluent API for modelling the database. 

Separated the configuration files for cleaner architecture and easier debugging.

## General Info

Design Pattern: **MVC**

Request Validation: **Fluent Validation**

Global Exception Handling: **Enabled**

The API follows the **MVC guidelines** and makes use of view-models when handling requests and responses, **auto-mapper** is used for mapping the view-model to database-model and vice versa. 

The API uses **asynchronous methods** in case heavy data is written or read from the database.


**Concurrency Token** has been added to the UpdatedAt field since posts can be modified by multiple users.
#
**Bonus**: The seed data are some of my favorite blog posts.
