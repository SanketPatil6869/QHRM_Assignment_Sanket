# QHRM_Assignment_Sanket
QHRM Assignment

1) You need to download this zip file & extract.
2) Then open in visual studio.
3) After that create one database and execute this query to create Products table.

4)      CREATE TABLE [dbo].[Products] (
5)      [id]          INT           NOT NULL Primary Key Identity(1,1),
6)      [product]     VARCHAR (50)  NOT NULL,
7)       [description] VARCHAR (100) NOT NULL,
8)      [created]     DATETIME      NULL
9)      );
     
10) Then change the connection String in DefaultConnection of your database in appsetting.json file.
11) And finnaly run the project.
