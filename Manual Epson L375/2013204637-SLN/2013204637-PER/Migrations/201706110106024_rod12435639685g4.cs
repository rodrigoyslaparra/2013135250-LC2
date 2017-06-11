namespace _2013204637_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rod12435639685g4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ATM",
                c => new
                    {
                        ATMId = c.Int(nullable: false, identity: true),
                        DescATM = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ATMId);
            
            CreateTable(
                "dbo.Retiro",
                c => new
                    {
                        RetiroId = c.Int(nullable: false, identity: true),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescRetiro = c.String(nullable: false),
                        FechaRetiro = c.DateTime(nullable: false),
                        ATMId = c.Int(nullable: false),
                        CuentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RetiroId)
                .ForeignKey("dbo.ATM", t => t.ATMId, cascadeDelete: true)
                .ForeignKey("dbo.Cuenta", t => t.CuentaId, cascadeDelete: true)
                .Index(t => t.ATMId)
                .Index(t => t.CuentaId);
            
            CreateTable(
                "dbo.Cuenta",
                c => new
                    {
                        CuentaId = c.Int(nullable: false, identity: true),
                        NumeroCuenta = c.Int(nullable: false),
                        DescCuenta = c.String(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pin = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CuentaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        NombreCliente = c.String(nullable: false),
                        EdadCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Retiro", "CuentaId", "dbo.Cuenta");
            DropForeignKey("dbo.Cuenta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Retiro", "ATMId", "dbo.ATM");
            DropIndex("dbo.Cuenta", new[] { "ClienteId" });
            DropIndex("dbo.Retiro", new[] { "CuentaId" });
            DropIndex("dbo.Retiro", new[] { "ATMId" });
            DropTable("dbo.Cliente");
            DropTable("dbo.Cuenta");
            DropTable("dbo.Retiro");
            DropTable("dbo.ATM");
        }
    }
}
