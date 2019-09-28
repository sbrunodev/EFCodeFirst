namespace Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        CompraID = c.Int(nullable: false, identity: true),
                        DataCompra = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.CompraID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdutoId = c.Int(nullable: false),
                        CompraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Compras", t => t.CompraId, cascadeDelete: true)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.CompraId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ProdutoId", "dbo.Produtoes");
            DropForeignKey("dbo.Items", "CompraId", "dbo.Compras");
            DropIndex("dbo.Items", new[] { "CompraId" });
            DropIndex("dbo.Items", new[] { "ProdutoId" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Items");
            DropTable("dbo.Compras");
        }
    }
}
