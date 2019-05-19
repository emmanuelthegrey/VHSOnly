namespace VHSOnly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
