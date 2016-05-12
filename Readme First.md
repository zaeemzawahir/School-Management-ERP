School Management System (ERP)
------------------------------

This system has been developed as client server architecure system. Follow each step below to run the system successfully

________________________________________________________________________
To run system sucessfully you will need to fulfill following reqirements
________________________________________________________________________

1. Run Windows 7 or Later versions
2. Minimum 2.4 Ghz Dualcore PC
3. 2 GB RAM.
4. 30 GB Free hardisk space
5. Crystal Report runtime software.
6. MS SQL Server 2014 or later versions.
7. .Net Framework 4.0

Pleae be sure to fulfill the above requirement to run the system sucessfully.

Note: Since this is an ERP system an Installation has not been created. Follow the instructions below to run the system.


Instructions
..............................
To run this system sucessfully without running the solution file double click on School Management ERP shortcut else you can also run the system by opening Solution file and debugging.
To connect database you will need to configure the datasource correctly. Follow the steps below.

1. Open 'School Management ERP.vshost.exe' in the folder where the application resides using notepad or any other texteditor.
2. Change  the default Datasource VIRUSDEV as your PC name <add key="constr" value="Data Source=VIRUSDEV;Initial Catalog=SMSERP;Integrated Security=True"/> in the file and save.
3. Attach the Database mdf file in the Database folder to SQL Server Management Studio
............
How to run
............
Since you you have sucessfully configured the system follow steps below to use the system.

The Administrator username and password by default has been created for the ease of demonstrating this system and create the other user category with ease. Below mentioned are username and respective password to access this system.

Default username = administrator 
password = password


User accounts created for demonstration purpose

username 		access level
________		_____________
mega      Clerk
mathew 			Librarian
Fuller		 	Inventory Manager
chanda		 	Management Staff
zaeem			  Principal


Password for all the above user account is 'terror'

