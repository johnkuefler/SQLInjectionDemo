# SQLInjectionDemo
A project to demonstrate SQL Injection  
  
## Prerequisites:
Need a localdb named "Injection" with a table called "Login". Some scripts to get started:
```
Create table Login  
(  
id int primary key,  
Name varchar(50),  
Email varchar(50),  
Password varchar(50)  
)   
```  
  
```
Insert into Login values(1, 'Sourabh Somani', 'sourabh_somani2010@hotmail.com', 'password');  
Insert into Login values(2, 'Shaili Dashora', 'dashorashaili17@gmail.com' 'password');  
Insert into Login values(3, 'Divya Sharma', 'sharma.divya485@gmail.com', 'password');  
Insert into Login values(4, 'Swati Soni', 'swati_soni@gmail.com', 'password');  
```


## Injection demos:  
1=1 method if username is not known: `' or 1=1--`  
  
method if username is known: `'--`  
  
method to delete data `' Delete from Login --`
    

## Credit
Some elements taken from: https://www.c-sharpcorner.com/UploadFile/75a48f/how-sql-injection-can-be-possible-in-asp-net-websites/
