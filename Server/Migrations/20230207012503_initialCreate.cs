using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PF2023.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioRol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermisoParaCrear = table.Column<bool>(type: "bit", nullable: false),
                    PermisoParaEditar = table.Column<bool>(type: "bit", nullable: false),
                    PermisoParaEliminar = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioRol_UsuarioRol_UsuarioRolId",
                        column: x => x.UsuarioRolId,
                        principalTable: "UsuarioRol",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioRolId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NikeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_UsuarioRol_UsuarioRolId",
                        column: x => x.UsuarioRolId,
                        principalTable: "UsuarioRol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioRolId",
                table: "Usuario",
                column: "UsuarioRolId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRol_UsuarioRolId",
                table: "UsuarioRol",
                column: "UsuarioRolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "UsuarioRol");
        }
    }
}
