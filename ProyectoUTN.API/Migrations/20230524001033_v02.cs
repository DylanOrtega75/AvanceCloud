using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoUTN.API.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaCodigoCategoria",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCodigoCategoria",
                table: "Productos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaCodigoCategoria",
                table: "Productos",
                column: "CategoriaCodigoCategoria",
                principalTable: "Categorias",
                principalColumn: "CodigoCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaCodigoCategoria",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCodigoCategoria",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaCodigoCategoria",
                table: "Productos",
                column: "CategoriaCodigoCategoria",
                principalTable: "Categorias",
                principalColumn: "CodigoCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
