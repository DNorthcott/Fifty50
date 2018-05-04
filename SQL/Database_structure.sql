CREATE TABLE IF NOT EXISTS Type
(Code TEXT(2) PRIMARY KEY, 
 Name TEXT (50));



CREATE TABLE IF NOT EXISTS Person
(ID INTEGER PRIMARY KEY AUTOINCREMENT, 
 Email TEXT(256), 
 Fname TEXT(50), 
 LName TEXT(50) 
 );
 
CREATE TABLE IF NOT EXISTS Transactions
(Person INT,
 DateTime TEXT,
 Comments TEXT (300),
 Value NUMERIC, 
 Type TEXT(2) ,
 PRIMARY KEY (Person, DateTime), 
 FOREIGN KEY (Person) references Person(ID),
 FOREIGN KEY (Type) references Type(Code) 
);