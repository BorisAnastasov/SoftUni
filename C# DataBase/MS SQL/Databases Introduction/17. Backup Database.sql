BACKUP DATABASE SoftUni
TO DISK = 'softuni-backup.bak';

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni  
 FROM DISK = 'C:\Users\USER\softuni-backup.bak';
