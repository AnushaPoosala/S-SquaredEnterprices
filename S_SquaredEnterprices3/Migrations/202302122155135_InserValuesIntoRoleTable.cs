namespace S_SquaredEnterprices3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserValuesIntoRoleTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(1,'Director')");
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(2,'IT')");
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(3,'Support')");
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(4,'Accounting')");
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(5,'Analyst')");
            Sql("INSERT INTO Roles(EmployeeRoleId,RoleName) VALUES(6,'Sales')");
        }
        
        public override void Down()
        {
        }
    }
}
