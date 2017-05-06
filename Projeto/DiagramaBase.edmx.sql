
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2017 12:41:16
-- Generated from EDMX file: C:\Repos\ProjetoArcMage\Projeto\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [arcmage2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DeckCard_Deck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeckCard] DROP CONSTRAINT [FK_DeckCard_Deck];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckCard_Card]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeckCard] DROP CONSTRAINT [FK_DeckCard_Card];
GO
IF OBJECT_ID(N'[dbo].[FK_GameReferee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_GameReferee];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_DeckGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckGame2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_DeckGame2];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_PlayerStandardGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardGame2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_PlayerStandardGame2];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardTournament1_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandardTournament1] DROP CONSTRAINT [FK_PlayerStandardTournament1_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardTournament1_StandardTournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandardTournament1] DROP CONSTRAINT [FK_PlayerStandardTournament1_StandardTournament];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardTournament2_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandardTournament2] DROP CONSTRAINT [FK_PlayerStandardTournament2_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardTournament2_StandardTournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandardTournament2] DROP CONSTRAINT [FK_PlayerStandardTournament2_StandardTournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTeamGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamTeamGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTeamGame2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamTeamGame2];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeam1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Team] DROP CONSTRAINT [FK_TeamTournamentTeam1];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeam2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Team] DROP CONSTRAINT [FK_TeamTournamentTeam2];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer1_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer1] DROP CONSTRAINT [FK_TeamPlayer1_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer1_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer1] DROP CONSTRAINT [FK_TeamPlayer1_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer2_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer2] DROP CONSTRAINT [FK_TeamPlayer2_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer2_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer2] DROP CONSTRAINT [FK_TeamPlayer2_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_TournamentGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_TournamentGame];
GO
IF OBJECT_ID(N'[dbo].[FK_Referee_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Referee] DROP CONSTRAINT [FK_Referee_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_StandardGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardTournament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tournament_StandardTournament] DROP CONSTRAINT [FK_StandardTournament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tournament_TeamTournament] DROP CONSTRAINT [FK_TeamTournament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrator_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Administrator] DROP CONSTRAINT [FK_Administrator_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Game]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game];
GO
IF OBJECT_ID(N'[dbo].[Deck]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deck];
GO
IF OBJECT_ID(N'[dbo].[Card]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Card];
GO
IF OBJECT_ID(N'[dbo].[Tournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament];
GO
IF OBJECT_ID(N'[dbo].[Team]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Team];
GO
IF OBJECT_ID(N'[dbo].[Player]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Player];
GO
IF OBJECT_ID(N'[dbo].[User_Referee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Referee];
GO
IF OBJECT_ID(N'[dbo].[Game_StandardGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game_StandardGame];
GO
IF OBJECT_ID(N'[dbo].[Tournament_StandardTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament_StandardTournament];
GO
IF OBJECT_ID(N'[dbo].[Game_TeamGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game_TeamGame];
GO
IF OBJECT_ID(N'[dbo].[Tournament_TeamTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament_TeamTournament];
GO
IF OBJECT_ID(N'[dbo].[User_Administrator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Administrator];
GO
IF OBJECT_ID(N'[dbo].[DeckCard]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeckCard];
GO
IF OBJECT_ID(N'[dbo].[PlayerStandardTournament1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlayerStandardTournament1];
GO
IF OBJECT_ID(N'[dbo].[PlayerStandardTournament2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlayerStandardTournament2];
GO
IF OBJECT_ID(N'[dbo].[TeamPlayer1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamPlayer1];
GO
IF OBJECT_ID(N'[dbo].[TeamPlayer2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamPlayer2];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Game'
CREATE TABLE [dbo].[Game] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [DeckId] int  NOT NULL,
    [Referee_Id] int  NOT NULL,
    [Deck1_Id] int  NOT NULL,
    [Deck2_Id] int  NOT NULL,
    [Tournament_Id] int  NOT NULL
);
GO

-- Creating table 'Deck'
CREATE TABLE [dbo].[Deck] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Card'
CREATE TABLE [dbo].[Card] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Atack] nvarchar(max)  NOT NULL,
    [Defense] nvarchar(max)  NOT NULL,
    [Loyal] nvarchar(max)  NOT NULL,
    [Rules] nvarchar(max)  NOT NULL,
    [Faction] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tournament'
CREATE TABLE [dbo].[Tournament] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Desc] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Team'
CREATE TABLE [dbo].[Team] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [TournamentAsTeam1_Id] int  NOT NULL,
    [TournamentAsTeam2_Id] int  NOT NULL
);
GO

-- Creating table 'Player'
CREATE TABLE [dbo].[Player] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'User_Referee'
CREATE TABLE [dbo].[User_Referee] (
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Game_StandardGame'
CREATE TABLE [dbo].[Game_StandardGame] (
    [Id] int  NOT NULL,
    [Player1_Id] int  NOT NULL,
    [Player2_Id] int  NOT NULL
);
GO

-- Creating table 'Tournament_StandardTournament'
CREATE TABLE [dbo].[Tournament_StandardTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Game_TeamGame'
CREATE TABLE [dbo].[Game_TeamGame] (
    [Id] int  NOT NULL,
    [Team1_Id] int  NOT NULL,
    [Team2_Id] int  NOT NULL
);
GO

-- Creating table 'Tournament_TeamTournament'
CREATE TABLE [dbo].[Tournament_TeamTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'User_Administrator'
CREATE TABLE [dbo].[User_Administrator] (
    [email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'DeckCard'
CREATE TABLE [dbo].[DeckCard] (
    [Deck_Id] int  NOT NULL,
    [Card_Id] int  NOT NULL
);
GO

-- Creating table 'PlayerStandardTournament1'
CREATE TABLE [dbo].[PlayerStandardTournament1] (
    [Player1_Id] int  NOT NULL,
    [SinglePlayerTournament1_Id] int  NOT NULL
);
GO

-- Creating table 'PlayerStandardTournament2'
CREATE TABLE [dbo].[PlayerStandardTournament2] (
    [Player2_Id] int  NOT NULL,
    [SinglePlayerTournament2_Id] int  NOT NULL
);
GO

-- Creating table 'TeamPlayer1'
CREATE TABLE [dbo].[TeamPlayer1] (
    [Team1_Id] int  NOT NULL,
    [Player1_Id] int  NOT NULL
);
GO

-- Creating table 'TeamPlayer2'
CREATE TABLE [dbo].[TeamPlayer2] (
    [Team2_Id] int  NOT NULL,
    [Player2_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [PK_Game]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deck'
ALTER TABLE [dbo].[Deck]
ADD CONSTRAINT [PK_Deck]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Card'
ALTER TABLE [dbo].[Card]
ADD CONSTRAINT [PK_Card]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament'
ALTER TABLE [dbo].[Tournament]
ADD CONSTRAINT [PK_Tournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [PK_Team]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Player'
ALTER TABLE [dbo].[Player]
ADD CONSTRAINT [PK_Player]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Referee'
ALTER TABLE [dbo].[User_Referee]
ADD CONSTRAINT [PK_User_Referee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [PK_Game_StandardGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament_StandardTournament'
ALTER TABLE [dbo].[Tournament_StandardTournament]
ADD CONSTRAINT [PK_Tournament_StandardTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [PK_Game_TeamGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament_TeamTournament'
ALTER TABLE [dbo].[Tournament_TeamTournament]
ADD CONSTRAINT [PK_Tournament_TeamTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Administrator'
ALTER TABLE [dbo].[User_Administrator]
ADD CONSTRAINT [PK_User_Administrator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Deck_Id], [Card_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [PK_DeckCard]
    PRIMARY KEY CLUSTERED ([Deck_Id], [Card_Id] ASC);
GO

-- Creating primary key on [Player1_Id], [SinglePlayerTournament1_Id] in table 'PlayerStandardTournament1'
ALTER TABLE [dbo].[PlayerStandardTournament1]
ADD CONSTRAINT [PK_PlayerStandardTournament1]
    PRIMARY KEY CLUSTERED ([Player1_Id], [SinglePlayerTournament1_Id] ASC);
GO

-- Creating primary key on [Player2_Id], [SinglePlayerTournament2_Id] in table 'PlayerStandardTournament2'
ALTER TABLE [dbo].[PlayerStandardTournament2]
ADD CONSTRAINT [PK_PlayerStandardTournament2]
    PRIMARY KEY CLUSTERED ([Player2_Id], [SinglePlayerTournament2_Id] ASC);
GO

-- Creating primary key on [Team1_Id], [Player1_Id] in table 'TeamPlayer1'
ALTER TABLE [dbo].[TeamPlayer1]
ADD CONSTRAINT [PK_TeamPlayer1]
    PRIMARY KEY CLUSTERED ([Team1_Id], [Player1_Id] ASC);
GO

-- Creating primary key on [Team2_Id], [Player2_Id] in table 'TeamPlayer2'
ALTER TABLE [dbo].[TeamPlayer2]
ADD CONSTRAINT [PK_TeamPlayer2]
    PRIMARY KEY CLUSTERED ([Team2_Id], [Player2_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Deck_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Deck]
    FOREIGN KEY ([Deck_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Card_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Card]
    FOREIGN KEY ([Card_Id])
    REFERENCES [dbo].[Card]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckCard_Card'
CREATE INDEX [IX_FK_DeckCard_Card]
ON [dbo].[DeckCard]
    ([Card_Id]);
GO

-- Creating foreign key on [Referee_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_GameReferee]
    FOREIGN KEY ([Referee_Id])
    REFERENCES [dbo].[User_Referee]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameReferee'
CREATE INDEX [IX_FK_GameReferee]
ON [dbo].[Game]
    ([Referee_Id]);
GO

-- Creating foreign key on [Deck1_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_DeckGame1]
    FOREIGN KEY ([Deck1_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckGame1'
CREATE INDEX [IX_FK_DeckGame1]
ON [dbo].[Game]
    ([Deck1_Id]);
GO

-- Creating foreign key on [Deck2_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_DeckGame2]
    FOREIGN KEY ([Deck2_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckGame2'
CREATE INDEX [IX_FK_DeckGame2]
ON [dbo].[Game]
    ([Deck2_Id]);
GO

-- Creating foreign key on [Player1_Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_PlayerStandardGame1]
    FOREIGN KEY ([Player1_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardGame1'
CREATE INDEX [IX_FK_PlayerStandardGame1]
ON [dbo].[Game_StandardGame]
    ([Player1_Id]);
GO

-- Creating foreign key on [Player2_Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_PlayerStandardGame2]
    FOREIGN KEY ([Player2_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardGame2'
CREATE INDEX [IX_FK_PlayerStandardGame2]
ON [dbo].[Game_StandardGame]
    ([Player2_Id]);
GO

-- Creating foreign key on [Player1_Id] in table 'PlayerStandardTournament1'
ALTER TABLE [dbo].[PlayerStandardTournament1]
ADD CONSTRAINT [FK_PlayerStandardTournament1_Player]
    FOREIGN KEY ([Player1_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SinglePlayerTournament1_Id] in table 'PlayerStandardTournament1'
ALTER TABLE [dbo].[PlayerStandardTournament1]
ADD CONSTRAINT [FK_PlayerStandardTournament1_StandardTournament]
    FOREIGN KEY ([SinglePlayerTournament1_Id])
    REFERENCES [dbo].[Tournament_StandardTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardTournament1_StandardTournament'
CREATE INDEX [IX_FK_PlayerStandardTournament1_StandardTournament]
ON [dbo].[PlayerStandardTournament1]
    ([SinglePlayerTournament1_Id]);
GO

-- Creating foreign key on [Player2_Id] in table 'PlayerStandardTournament2'
ALTER TABLE [dbo].[PlayerStandardTournament2]
ADD CONSTRAINT [FK_PlayerStandardTournament2_Player]
    FOREIGN KEY ([Player2_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SinglePlayerTournament2_Id] in table 'PlayerStandardTournament2'
ALTER TABLE [dbo].[PlayerStandardTournament2]
ADD CONSTRAINT [FK_PlayerStandardTournament2_StandardTournament]
    FOREIGN KEY ([SinglePlayerTournament2_Id])
    REFERENCES [dbo].[Tournament_StandardTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardTournament2_StandardTournament'
CREATE INDEX [IX_FK_PlayerStandardTournament2_StandardTournament]
ON [dbo].[PlayerStandardTournament2]
    ([SinglePlayerTournament2_Id]);
GO

-- Creating foreign key on [Team1_Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamTeamGame1]
    FOREIGN KEY ([Team1_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTeamGame1'
CREATE INDEX [IX_FK_TeamTeamGame1]
ON [dbo].[Game_TeamGame]
    ([Team1_Id]);
GO

-- Creating foreign key on [Team2_Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamTeamGame2]
    FOREIGN KEY ([Team2_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTeamGame2'
CREATE INDEX [IX_FK_TeamTeamGame2]
ON [dbo].[Game_TeamGame]
    ([Team2_Id]);
GO

-- Creating foreign key on [TournamentAsTeam1_Id] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [FK_TeamTournamentTeam1]
    FOREIGN KEY ([TournamentAsTeam1_Id])
    REFERENCES [dbo].[Tournament_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournamentTeam1'
CREATE INDEX [IX_FK_TeamTournamentTeam1]
ON [dbo].[Team]
    ([TournamentAsTeam1_Id]);
GO

-- Creating foreign key on [TournamentAsTeam2_Id] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [FK_TeamTournamentTeam2]
    FOREIGN KEY ([TournamentAsTeam2_Id])
    REFERENCES [dbo].[Tournament_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournamentTeam2'
CREATE INDEX [IX_FK_TeamTournamentTeam2]
ON [dbo].[Team]
    ([TournamentAsTeam2_Id]);
GO

-- Creating foreign key on [Team1_Id] in table 'TeamPlayer1'
ALTER TABLE [dbo].[TeamPlayer1]
ADD CONSTRAINT [FK_TeamPlayer1_Team]
    FOREIGN KEY ([Team1_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player1_Id] in table 'TeamPlayer1'
ALTER TABLE [dbo].[TeamPlayer1]
ADD CONSTRAINT [FK_TeamPlayer1_Player]
    FOREIGN KEY ([Player1_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer1_Player'
CREATE INDEX [IX_FK_TeamPlayer1_Player]
ON [dbo].[TeamPlayer1]
    ([Player1_Id]);
GO

-- Creating foreign key on [Team2_Id] in table 'TeamPlayer2'
ALTER TABLE [dbo].[TeamPlayer2]
ADD CONSTRAINT [FK_TeamPlayer2_Team]
    FOREIGN KEY ([Team2_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player2_Id] in table 'TeamPlayer2'
ALTER TABLE [dbo].[TeamPlayer2]
ADD CONSTRAINT [FK_TeamPlayer2_Player]
    FOREIGN KEY ([Player2_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer2_Player'
CREATE INDEX [IX_FK_TeamPlayer2_Player]
ON [dbo].[TeamPlayer2]
    ([Player2_Id]);
GO

-- Creating foreign key on [Tournament_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_TournamentGame]
    FOREIGN KEY ([Tournament_Id])
    REFERENCES [dbo].[Tournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TournamentGame'
CREATE INDEX [IX_FK_TournamentGame]
ON [dbo].[Game]
    ([Tournament_Id]);
GO

-- Creating foreign key on [Id] in table 'User_Referee'
ALTER TABLE [dbo].[User_Referee]
ADD CONSTRAINT [FK_Referee_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_StandardGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Game]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Tournament_StandardTournament'
ALTER TABLE [dbo].[Tournament_StandardTournament]
ADD CONSTRAINT [FK_StandardTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Tournament]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Game]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Tournament_TeamTournament'
ALTER TABLE [dbo].[Tournament_TeamTournament]
ADD CONSTRAINT [FK_TeamTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Tournament]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'User_Administrator'
ALTER TABLE [dbo].[User_Administrator]
ADD CONSTRAINT [FK_Administrator_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------