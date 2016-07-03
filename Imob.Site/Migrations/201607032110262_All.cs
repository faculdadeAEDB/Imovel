namespace Imob.Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class All : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicio = c.String(),
                        DataFim = c.String(),
                        Habitation_ID = c.Int(),
                        Dono_ID = c.Int(),
                        Inquilino_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Habitations", t => t.Habitation_ID)
                .ForeignKey("dbo.Owners", t => t.Dono_ID)
                .ForeignKey("dbo.Customers", t => t.Inquilino_ID)
                .Index(t => t.Habitation_ID)
                .Index(t => t.Dono_ID)
                .Index(t => t.Inquilino_ID);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        CPF = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Habitations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco = c.String(),
                        Tipo = c.String(),
                        Dono_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Owners", t => t.Dono_ID)
                .Index(t => t.Dono_ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Idade = c.String(),
                        Endereco = c.String(),
                        Telefone = c.String(),
                        cpf = c.Int(nullable: false),
                        MyProperty = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataPagament = c.String(),
                        Alguel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rents", t => t.Alguel_ID)
                .Index(t => t.Alguel_ID);
            
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pagamento_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Payments", t => t.Pagamento_ID)
                .Index(t => t.Pagamento_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fees", "Pagamento_ID", "dbo.Payments");
            DropForeignKey("dbo.Payments", "Alguel_ID", "dbo.Rents");
            DropForeignKey("dbo.Rents", "Inquilino_ID", "dbo.Customers");
            DropForeignKey("dbo.Rents", "Dono_ID", "dbo.Owners");
            DropForeignKey("dbo.Habitations", "Dono_ID", "dbo.Owners");
            DropForeignKey("dbo.Rents", "Habitation_ID", "dbo.Habitations");
            DropIndex("dbo.Fees", new[] { "Pagamento_ID" });
            DropIndex("dbo.Payments", new[] { "Alguel_ID" });
            DropIndex("dbo.Habitations", new[] { "Dono_ID" });
            DropIndex("dbo.Rents", new[] { "Inquilino_ID" });
            DropIndex("dbo.Rents", new[] { "Dono_ID" });
            DropIndex("dbo.Rents", new[] { "Habitation_ID" });
            DropTable("dbo.Fees");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Habitations");
            DropTable("dbo.Owners");
            DropTable("dbo.Rents");
        }
    }
}
