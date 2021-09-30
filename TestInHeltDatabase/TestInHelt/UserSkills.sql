CREATE TABLE [dbo].[UserSkills]
(
	[userSkillId] NVARCHAR(50) PRIMARY KEY, 
    [username] NVARCHAR(50) NULL, 
    [skillID] INT NULL, 
    [skillLevelID] INT NULL, 
    CONSTRAINT [FK_UserSkills_ToUser] FOREIGN KEY ([username]) REFERENCES [User]([username]), 
    CONSTRAINT [FK_UserSkills_ToSkill] FOREIGN KEY ([skillID]) REFERENCES [Skill]([skillID]), 
    CONSTRAINT [FK_UserSkills_ToSkillLevel] FOREIGN KEY ([skillLevelID]) REFERENCES [SkillLevel]([skillLevelID])
)
