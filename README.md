# QHRM_Assignment_Sanket
QHRM Assignment

1) You need to download this zip file & extract.
2) Then open in visual studio.
3) After that create one database and execute this query to create Products table.

4)      CREATE TABLE [dbo].[Products] (
      [id]          INT           NOT NULL Primary Key Identity(1,1),
      [product]     VARCHAR (50)  NOT NULL,
       [description] VARCHAR (100) NOT NULL,
      [created]     DATETIME      NULL
      );
     
5) Then change the connection String in DefaultConnection of your database in appsetting.json file.
6) And finnaly run the project.
