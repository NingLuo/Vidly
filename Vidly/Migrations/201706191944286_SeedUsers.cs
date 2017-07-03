namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f83ef90-5b72-4854-9264-25db3b5f68bf', N'guest@vidly.com', 0, N'AJvSufxtW86gjM/7jerDhRmkAnrE04UprBGZwYckTicbrzsMcdZ1hQ7ZoL0AZ8Xkzw==', N'f84e5cc6-5ae6-4d76-8af5-5e73223dfd09', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bbbc90ab-cf73-471a-a380-cbe3bf8737cd', N'admin@vidly.com', 0, N'AJmHgrZHNz/fKbS5YJO4d9Wf5g+ILPdd4TVh/wEXZjgMlwFq/2+hgoHI8Zs0Cd2ipg==', N'21af4e77-b779-426b-a9fa-b4aaaeb2667f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ca5ebc99-7a5d-4d06-ae86-781e6b78f0dc', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bbbc90ab-cf73-471a-a380-cbe3bf8737cd', N'ca5ebc99-7a5d-4d06-ae86-781e6b78f0dc')
");
        }
        
        public override void Down()
        {
        }
    }
}
