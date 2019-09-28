namespace Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        EstudanteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        DataDeAniversario = c.DateTime(precision: 0),
                        Foto = c.Binary(),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Peso = c.Single(nullable: false),
                        Grade_GradeId = c.Int(),
                    })
                .PrimaryKey(t => t.EstudanteID)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeId)
                .Index(t => t.Grade_GradeId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeNome = c.String(unicode: false),
                        Sessao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estudantes", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.Estudantes", new[] { "Grade_GradeId" });
            DropTable("dbo.Grades");
            DropTable("dbo.Estudantes");
        }
    }
}
