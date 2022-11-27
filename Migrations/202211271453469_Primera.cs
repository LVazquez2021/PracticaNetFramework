namespace NET_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adress",
                c => new
                    {
                        AdressId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Localidad = c.String(maxLength: 50),
                        Provincia = c.String(maxLength: 50),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdressId)
                .ForeignKey("dbo.Client", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Cuit = c.String(maxLength: 15),
                        Telefono = c.String(maxLength: 20),
                        Direccion = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 70),
                        Price = c.Long(nullable: false),
                        Tax = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 35),
                        Description = c.String(maxLength: 60),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RolId)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        SaleNumber = c.Int(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        Sale_SaleId = c.Int(),
                    })
                .PrimaryKey(t => t.SaleId)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.Sale_SaleId)
                .Index(t => t.CompanyId)
                .Index(t => t.Sale_SaleId);
            
            CreateTable(
                "dbo.SalesLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LineName = c.String(maxLength: 30),
                        SaleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sale", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesLine", "SaleId", "dbo.Sale");
            DropForeignKey("dbo.Sale", "Sale_SaleId", "dbo.Sale");
            DropForeignKey("dbo.Sale", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.Rol", "UserId", "dbo.User");
            DropForeignKey("dbo.Adress", "ClienteId", "dbo.Client");
            DropForeignKey("dbo.Client", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "CompanyId", "dbo.Company");
            DropIndex("dbo.SalesLine", new[] { "SaleId" });
            DropIndex("dbo.Sale", new[] { "Sale_SaleId" });
            DropIndex("dbo.Sale", new[] { "CompanyId" });
            DropIndex("dbo.Rol", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "CompanyId" });
            DropIndex("dbo.Client", new[] { "UserId" });
            DropIndex("dbo.Adress", new[] { "ClienteId" });
            DropTable("dbo.Stock");
            DropTable("dbo.SalesLine");
            DropTable("dbo.Sale");
            DropTable("dbo.Rol");
            DropTable("dbo.Product");
            DropTable("dbo.Company");
            DropTable("dbo.User");
            DropTable("dbo.Client");
            DropTable("dbo.Adress");
        }
    }
}
