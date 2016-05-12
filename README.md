**School Management System (ERP)**
------------------------------
This system has been developed as client server architecture system. Follow each step below to run the system successfully

**`To run system successfully you will need to fulfill following requirements`**


1. Run Windows 7 or Later versions
2. Minimum 2.4 Ghz Dualcore PC
3. 2 GB RAM.
4. 30 GB Free hard disk space
5. Crystal Report runtime software.
6. MS SQL Server 2014 or later versions.
7. .Net Framework 4.0

***Please be sure to fulfill the above requirements to run the system successfully.***

    Note: Since this is an ERP system to be deployed as per clients need, an installation has not been created. Follow the instructions below to run the system.

Instructions
------------
To run this system successfully without running the solution file double click on School Management ERP shortcut else you can also run the system by opening Solution file and debugging

To connect to database you will need to configure the data source correctly. Follow the steps below.

1. Open 'School Management ERP.vshost.exe' in the folder where the application resides using notepad or any other texteditor.
2. Change  the default Datasource VIRUSDEV as your PC name 
`<add key="constr" value="Data Source=VIRUSDEV;Initial Catalog=SMSERP;Integrated Security=True"/> in the file and save.
3. Attach the Database mdf file in the Database folder to SQL Server Management Studio
How to run
----------
Since you you have successfully configured the system follow steps below to use the system.

*`The default administrator username and password has been created for the ease of demonstrating this system and create the other user category with ease. Below mentioned are username and respective password to access this system.`*

**Default username :  administrator**                                                                                                                                    
**Password				  : password**

> ***`User accounts created for demonstration purpose`***

The username and their respective access level are mention in the following format

**`username`**               
*`access-level`*

**Accounts**

1. **`mega`**			
*`Clerk`*

2. **mathew** 			
    *`Librarian`*
3. **`Fuller`**			
*`Inventory Manager`*

4. **`chanda`**			
*`Management Staff`*

5. **`zaeem`**			
*`Principal`*

> **Password for all the above user account is 'terror'**


