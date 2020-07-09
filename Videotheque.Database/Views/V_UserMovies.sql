CREATE VIEW [AppUser].[V_UserMovies]
	AS 
SELECT UM.[UserId], M.[Id], M.[Title], M.[Year] 
FROM [UserMovies] as UM
Join [Movies] as M on UM.MovieId = M.Id

