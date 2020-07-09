CREATE TABLE [dbo].[UserMovies]
(
	[Id] BIGINT NOT NULL IDENTITY,
	[UserId] INT NOT NULL,
	[MovieId] INT NOT NULL, 
    CONSTRAINT [PK_UserMovies] PRIMARY KEY ([Id]),	
    CONSTRAINT [UK_UserMovies] UNIQUE ([UserId], [MovieId]), 
    CONSTRAINT [FK_UserMovies_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_UserMovies_Movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([Id]),
)

GO
CREATE INDEX [IX_UserMovies_UserId] ON [dbo].[UserMovies] ([UserId]);
