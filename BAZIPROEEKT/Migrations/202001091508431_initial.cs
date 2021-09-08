namespace BAZIPROEEKT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aviokompanijas",
                c => new
                    {
                        id_avio = c.Int(nullable: false, identity: true),
                        ime = c.String(),
                        drzava = c.String(),
                    })
                .PrimaryKey(t => t.id_avio);
            
            CreateTable(
                "dbo.Kartas",
                c => new
                    {
                        id_karta = c.Int(nullable: false, identity: true),
                        datum_na_izdavanje = c.DateTime(nullable: false),
                        id_klient = c.Int(nullable: false),
                        id_let = c.Int(nullable: false),
                        destinacija_od = c.String(),
                        destinacija_do = c.String(),
                        vreme_na_poaganje = c.DateTime(nullable: false),
                        cena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_karta);
            
            CreateTable(
                "dbo.Klients",
                c => new
                    {
                        id_klient = c.Int(nullable: false, identity: true),
                        ime = c.String(),
                        username = c.String(),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id_klient);
            
            CreateTable(
                "dbo.Lets",
                c => new
                    {
                        id_let = c.Int(nullable: false, identity: true),
                        destinacija_od = c.String(),
                        destinacija_do = c.String(),
                        datum = c.DateTime(nullable: false),
                        cena = c.Int(nullable: false),
                        id_avio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_let);
            
            CreateTable(
                "dbo.Rezervacijas",
                c => new
                    {
                        id_rezervacija = c.Int(nullable: false, identity: true),
                        vreme_na_rezervacija = c.String(),
                        id_klient = c.String(),
                        id_avio = c.String(),
                    })
                .PrimaryKey(t => t.id_rezervacija);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rezervacijas");
            DropTable("dbo.Lets");
            DropTable("dbo.Klients");
            DropTable("dbo.Kartas");
            DropTable("dbo.Aviokompanijas");
        }
    }
}
