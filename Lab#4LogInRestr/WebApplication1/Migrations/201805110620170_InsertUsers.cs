namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'61878d0c-a552-468f-8a67-590361dfd10e', N'Mihai#111Aaa@gmail.com', 0, N'AOjZqEVHLpgYrolAgKmPXsCDdql+ASs7fOV0YXvcCqcGCKJHzo7ujwFmOycRYsCPaw==', N'6cf629f5-df3b-43a3-bc00-dde9c6819251', NULL, 0, 0, NULL, 1, 0, N'Mihai#111Aaa@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'82b316af-b4b2-4419-aaec-2aefc799841f', N'Radu#555Ccc@gmail.com', 0, N'ACk/rVEGF/sq07yOaLfRVbpaZVDgsjH1FUeMFru9jvi0aT0KsKue6LosbloCiEZSGg==', N'c79607ce-2df5-4d95-93ce-d67ae99abd6e', NULL, 0, 0, NULL, 1, 0, N'Radu#555Ccc@gmail.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd43709ac-df4f-465f-95ae-b36a2767d052', N'ManageData')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'61878d0c-a552-468f-8a67-590361dfd10e', N'd43709ac-df4f-465f-95ae-b36a2767d052')




");
        }
        
        public override void Down()
        {
        }
    }
}
