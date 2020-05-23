namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3727f159-206c-4512-a478-5f35a1d8a159', N'guest@vidly.com', 0, N'APRAO6r8Yi75uPP/m0aqJ6cIxvk+197cJba1FJY1JCWRr+jj7+wuhbukvU2zobXEBQ==', N'fd40e668-14cd-41e1-87c7-39dc6e4909c2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3cd10925-eee8-4e7b-9f4b-7fa5e0d72a35', N'admin@vidly.com', 0, N'AOKqtDZGBYs4O/kvYE634wn5ykoSHiUqARZp/RylMjnoHBmQlxHVXlexX53fl6JaBw==', N'7e4ded44-c833-4f8b-a96b-63629f8b7a2e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'708f643f-74ac-4a00-81ba-8b96de0e3de4', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3cd10925-eee8-4e7b-9f4b-7fa5e0d72a35', N'708f643f-74ac-4a00-81ba-8b96de0e3de4')

");
        }
        
        public override void Down()
        {
        }
    }
}
