using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class repararlocalidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 35, 42, 193, DateTimeKind.Unspecified).AddTicks(6604), new TimeSpan(0, -3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 35, 42, 193, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, -3, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 35, 42, 193, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, -3, 0, 0, 0)), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 37, 51, 565, DateTimeKind.Unspecified).AddTicks(8547), new TimeSpan(0, -3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 37, 51, 565, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, -3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 8, 26, 18, 37, 51, 565, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, -3, 0, 0, 0)), 0 });
        }
    }
}
