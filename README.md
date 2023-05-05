# QHRM_Assignment_Sanket
QHRM Assignment

1) You need to download this zip file & extract.
2) Then open in visual studio.
3) After that create one database and execute this query to create Products table.

        CREATE TABLE [dbo].[Products] (
      [id]          INT           NOT NULL Primary Key Identity(1,1),
      [product]     VARCHAR (50)  NOT NULL,
       [description] VARCHAR (100) NOT NULL,
      [created]     DATETIME      NULL
     );
     
4) Then change the connection String in DefaultConnection of your database in appsetting.json file.
5) And finnaly run the project.
