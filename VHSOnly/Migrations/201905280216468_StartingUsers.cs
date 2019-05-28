namespace VHSOnly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartingUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2b19eb41-8d41-4cbf-a9ca-047548a16866', N'guest@VHSOnly.com', 0, N'AHGPC/dPvP6TeFFmAlbnF0TGLlzALkX9CA88z6fIFezINqv+0dUh5jqbJ+0R30mQJw==', N'55c79c8d-27b4-4880-8af3-35f36388b0c9', NULL, 0, 0, NULL, 1, 0, N'guest@VHSOnly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6005649f-5fad-44ed-85a2-c314902f7b02', N'admin@VHSOnly.com', 0, N'AK/pL1mvIcp6j6DK+Bv9svJnSN0dfSD3jlPpixeTc2P34PuYzhphfe++VaYPQSmUWA==', N'f2ca953a-a19b-436f-8e2a-071af7e0c1f9', NULL, 0, 0, NULL, 1, 0, N'admin@VHSOnly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd132e72e-8f4b-4b62-ac49-1fd6de132ce0', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6005649f-5fad-44ed-85a2-c314902f7b02', N'd132e72e-8f4b-4b62-ac49-1fd6de132ce0')

");
        }
        
        public override void Down()
        {
        }
    }
}
