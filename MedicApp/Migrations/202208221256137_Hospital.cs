using System.Data.Entity.Migrations.Model;

namespace MedicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Hospital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Casos",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Paciente_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                        Fecha_entrada = c.DateTime(nullable: false),
                        Fecha_salida = c.DateTime(nullable: false)
                    })
                .PrimaryKey(t => new { t.Id, })
                .ForeignKey("Medicos", t => t.Doctor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id, cascadeDelete: true)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Paciente_Id);



            CreateTable(
                    "dbo.Pacientes",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 128),
                        Cedula = c.String(nullable: false, maxLength: 13),
                        Seguro = c.String(nullable: false, maxLength: 128),
                        Fecha_entrada = c.DateTime(nullable: false),
                        Fecha_salida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id });
               
        
            CreateTable(
                    "Medicos",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Especialidad = c.String(nullable: false, maxLength: 100),
                        Paciente_actual = c.String(nullable: false, maxLength: 100),
                        id_role = c.Int(nullable: false),
                        hora_entrada = c.DateTime(nullable: false),
                        hora_salida = c.DateTime(nullable: false),
                        Caso_id = c.Int(nullable: true)
                    })
                .PrimaryKey(t => new { t.Id })
                .ForeignKey("dbo.Casos", t => t.Caso_id)
                .Index(t => t.Caso_id);





        }

        public override void Down()
        {
         
        }
    }
}
