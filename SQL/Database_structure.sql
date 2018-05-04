CREATE TABLE IF NOT EXISTS Type
(Code TEXT PRIMARY KEY, 
 Name TEXT);

CREATE TABLE IF NOT EXISTS Person
(ID INTEGER PRIMARY KEY AUTOINCREMENT, 
 Email TEXT, 
 Fname TEXT, 
 LName TEXT);
 
CREATE TABLE IF NOT EXISTS Transactions
(Person INT,
 DateTime TEXT,
 Comments TEXT,
 Value NUMERIC, 
 Type TEXT,
 PRIMARY KEY (Person, DateTime), 
 FOREIGN KEY (Person) references Person(ID),
 FOREIGN KEY (Type) references Type(Code) 
);