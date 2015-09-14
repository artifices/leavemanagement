namespace Licencias_Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        Email = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Licencias",
                c => new
                    {
                        LicenciaId = c.Int(nullable: false, identity: true),
                        fechaAlta = c.DateTime(nullable: false),
                        Desde = c.DateTime(nullable: false),
                        Hasta = c.DateTime(nullable: false),
                        UltimaModificacion = c.DateTime(nullable: false),
                        Estado = c.String(),
                        Comentario = c.String(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.LicenciaId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Usuario_Roles",
                c => new
                    {
                        Usuario_RolId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Usuario_RolId);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        Superior_UsuarioId = c.Int(),
                        diasDeLicenciaXAnio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId)
                .ForeignKey("dbo.Usuarios", t => t.Superior_UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.Superior_UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "Superior_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Empleados", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Licencias", "Usuario_UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Empleados", new[] { "Superior_UsuarioId" });
            DropIndex("dbo.Empleados", new[] { "UsuarioId" });
            DropIndex("dbo.Licencias", new[] { "Usuario_UsuarioId" });
            DropTable("dbo.Empleados");
            DropTable("dbo.Usuario_Roles");
            DropTable("dbo.Roles");
            DropTable("dbo.Licencias");
            DropTable("dbo.Usuarios");
        }
    }
}
