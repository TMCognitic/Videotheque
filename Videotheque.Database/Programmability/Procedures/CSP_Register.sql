CREATE PROCEDURE [AppUser].[CSP_Register]
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50),
	@Email NVARCHAR(320),
	@Passwd NVARCHAR(20)
AS
	INSERT INTO [Users] (LastName, FirstName, Email, Passwd)
	VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', [dbo].CSF_PreSalt() + @Passwd + [dbo].CSF_PostSalt()));
RETURN 0
