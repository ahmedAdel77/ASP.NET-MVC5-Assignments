namespace Day02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenderToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Gender");
        }
    }
}
