using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTag = table.Column<string>(type: "TEXT", nullable: true),
                    NombreTag = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    EdadUsuario = table.Column<int>(type: "INTEGER", nullable: true),
                    SexoUsuario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreComentario = table.Column<string>(type: "TEXT", nullable: true),
                    ContenidoComentario = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreEntrada = table.Column<string>(type: "TEXT", nullable: true),
                    ContenidoEntrada = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entradas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetalleComentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComentarioId = table.Column<int>(type: "INTEGER", nullable: true),
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleComentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleComentarios_Comentarios_ComentarioId",
                        column: x => x.ComentarioId,
                        principalTable: "Comentarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetalleComentarios_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetalleTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagId = table.Column<int>(type: "INTEGER", nullable: true),
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleTags_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetalleTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleComentarios_ComentarioId",
                table: "DetalleComentarios",
                column: "ComentarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleComentarios_EntradaId",
                table: "DetalleComentarios",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTags_EntradaId",
                table: "DetalleTags",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTags_TagId",
                table: "DetalleTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_UsuarioId",
                table: "Entradas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleComentarios");

            migrationBuilder.DropTable(
                name: "DetalleTags");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
