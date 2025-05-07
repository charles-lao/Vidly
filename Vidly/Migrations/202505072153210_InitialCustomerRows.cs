namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCustomerRows : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('John Smith', 1, 1, 15/08/1995)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) VALUES ('Mary Williams', 1, 2, null)");
        }
        
        public override void Down()
        {
        }
    }
}
