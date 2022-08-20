namespace MedicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "Medico",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false, maxLength: 100),
                    Apellido = c.String(nullable: false, maxLength: 100),
                    Especialidad = c.String(nullable: false, maxLength: 100),
                    Paciente_actual = c.String(nullable: false, maxLength: 100),
                    id_role = c.String(nullable: false),
                    hora_entrada = c.DateTime(nullable: false),
                    hora_salida = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => new { t.Id })
                .ForeignKey("dbo.AspNetRoles", t => t.id_role, cascadeDelete: true);


        }

        public override void Down()
        {
            DropTable("Medicos");
        }
    }
}
