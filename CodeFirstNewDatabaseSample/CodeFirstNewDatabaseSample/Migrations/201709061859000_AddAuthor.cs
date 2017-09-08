namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        NickName = c.String(nullable: false, maxLength: 128),
                        Address = c.String(maxLength: 128),
                        Age = c.Int(),
                    })
                .PrimaryKey(t => t.NickName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Author");
        }
    }
}
