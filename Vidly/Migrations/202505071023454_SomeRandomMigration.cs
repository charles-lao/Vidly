﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeRandomMigration : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
            //DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
