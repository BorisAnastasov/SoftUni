ALTER TABLE Users
ADD CONSTRAINT DF_LastLogin
DEFAULT GETDATE() FOR LastLoginTime;