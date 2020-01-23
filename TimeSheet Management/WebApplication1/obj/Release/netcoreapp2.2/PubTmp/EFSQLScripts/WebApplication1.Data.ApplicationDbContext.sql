IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722053850_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722053850_Initial', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054050_AddApplicationusertoDb')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Discriminator] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054050_AddApplicationusertoDb')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054050_AddApplicationusertoDb')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054050_AddApplicationusertoDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054050_AddApplicationusertoDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054133_AddWorkspacestoDb')
BEGIN
    CREATE TABLE [Workspaces] (
        [WorkspaceId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [DateCreated] datetime2 NOT NULL,
        [PmId] nvarchar(450) NULL,
        CONSTRAINT [PK_Workspaces] PRIMARY KEY ([WorkspaceId]),
        CONSTRAINT [FK_Workspaces_AspNetUsers_PmId] FOREIGN KEY ([PmId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054133_AddWorkspacestoDb')
BEGIN
    CREATE INDEX [IX_Workspaces_PmId] ON [Workspaces] ([PmId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054133_AddWorkspacestoDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054133_AddWorkspacestoDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054208_AddProjectsToDb')
BEGIN
    CREATE TABLE [Projects] (
        [ProjectId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [DateCreated] datetime2 NOT NULL,
        [WorkspaceId] int NOT NULL,
        CONSTRAINT [PK_Projects] PRIMARY KEY ([ProjectId]),
        CONSTRAINT [FK_Projects_Workspaces_WorkspaceId] FOREIGN KEY ([WorkspaceId]) REFERENCES [Workspaces] ([WorkspaceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054208_AddProjectsToDb')
BEGIN
    CREATE INDEX [IX_Projects_WorkspaceId] ON [Projects] ([WorkspaceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054208_AddProjectsToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054208_AddProjectsToDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054305_AddProjectAssignmentToDb')
BEGIN
    CREATE TABLE [ProjectAssignment] (
        [ProjectAssignmentId] int NOT NULL IDENTITY,
        [Status] nvarchar(max) NULL,
        [ProjectId] int NOT NULL,
        [EmployeeId] nvarchar(450) NULL,
        CONSTRAINT [PK_ProjectAssignment] PRIMARY KEY ([ProjectAssignmentId]),
        CONSTRAINT [FK_ProjectAssignment_AspNetUsers_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ProjectAssignment_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054305_AddProjectAssignmentToDb')
BEGIN
    CREATE INDEX [IX_ProjectAssignment_EmployeeId] ON [ProjectAssignment] ([EmployeeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054305_AddProjectAssignmentToDb')
BEGIN
    CREATE INDEX [IX_ProjectAssignment_ProjectId] ON [ProjectAssignment] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054305_AddProjectAssignmentToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054305_AddProjectAssignmentToDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054348_AddTasksToDb')
BEGIN
    CREATE TABLE [Tasks] (
        [TaskId] int NOT NULL IDENTITY,
        [TaskName] nvarchar(max) NULL,
        [WorkspaceId] int NOT NULL,
        CONSTRAINT [PK_Tasks] PRIMARY KEY ([TaskId]),
        CONSTRAINT [FK_Tasks_Workspaces_WorkspaceId] FOREIGN KEY ([WorkspaceId]) REFERENCES [Workspaces] ([WorkspaceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054348_AddTasksToDb')
BEGIN
    CREATE INDEX [IX_Tasks_WorkspaceId] ON [Tasks] ([WorkspaceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054348_AddTasksToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054348_AddTasksToDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054441_AddWeekSettingsToDb')
BEGIN
    CREATE TABLE [WeekSettings] (
        [WeekSettingId] int NOT NULL IDENTITY,
        [StartDay] nvarchar(max) NULL,
        [EndDay] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [WorkspaceId] int NOT NULL,
        CONSTRAINT [PK_WeekSettings] PRIMARY KEY ([WeekSettingId]),
        CONSTRAINT [FK_WeekSettings_Workspaces_WorkspaceId] FOREIGN KEY ([WorkspaceId]) REFERENCES [Workspaces] ([WorkspaceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054441_AddWeekSettingsToDb')
BEGIN
    CREATE INDEX [IX_WeekSettings_WorkspaceId] ON [WeekSettings] ([WorkspaceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054441_AddWeekSettingsToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054441_AddWeekSettingsToDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054516_AddTimesheetsToDb')
BEGIN
    CREATE TABLE [TimeSheets] (
        [TimeSheetId] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [Task] nvarchar(max) NULL,
        [TaskType] nvarchar(max) NULL,
        [HoursSpent] int NOT NULL,
        [Status] nvarchar(max) NULL,
        [EmployeeId] nvarchar(450) NULL,
        [ProjectId] int NOT NULL,
        CONSTRAINT [PK_TimeSheets] PRIMARY KEY ([TimeSheetId]),
        CONSTRAINT [FK_TimeSheets_AspNetUsers_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_TimeSheets_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054516_AddTimesheetsToDb')
BEGIN
    CREATE INDEX [IX_TimeSheets_EmployeeId] ON [TimeSheets] ([EmployeeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054516_AddTimesheetsToDb')
BEGIN
    CREATE INDEX [IX_TimeSheets_ProjectId] ON [TimeSheets] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054516_AddTimesheetsToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054516_AddTimesheetsToDb', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054557_AddChangeProjectRequestToDb')
BEGIN
    CREATE TABLE [ChangeProjectRequests] (
        [ChangeProjectRequestId] int NOT NULL IDENTITY,
        [Status] nvarchar(max) NULL,
        [ProjectId] int NOT NULL,
        [IndividualId] nvarchar(450) NULL,
        CONSTRAINT [PK_ChangeProjectRequests] PRIMARY KEY ([ChangeProjectRequestId]),
        CONSTRAINT [FK_ChangeProjectRequests_AspNetUsers_IndividualId] FOREIGN KEY ([IndividualId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ChangeProjectRequests_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054557_AddChangeProjectRequestToDb')
BEGIN
    CREATE INDEX [IX_ChangeProjectRequests_IndividualId] ON [ChangeProjectRequests] ([IndividualId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054557_AddChangeProjectRequestToDb')
BEGIN
    CREATE INDEX [IX_ChangeProjectRequests_ProjectId] ON [ChangeProjectRequests] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190722054557_AddChangeProjectRequestToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190722054557_AddChangeProjectRequestToDb', N'2.2.6-servicing-10079');
END;

GO

