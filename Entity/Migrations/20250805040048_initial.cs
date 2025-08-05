using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Damage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FireDamage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ElectricDamage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CrtiticalDamage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PoisionDamage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MagicDamage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asset = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentRound = table.Column<int>(type: "int", nullable: true),
                    Asset = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<bool>(type: "bit", nullable: false),
                    Asset = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamePlayerId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    IsEarned = table.Column<bool>(type: "bit", nullable: true),
                    Asset = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decks_GamePlayers_GamePlayerId",
                        column: x => x.GamePlayerId,
                        principalTable: "GamePlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Asset", "Code", "CreatedAt", "CrtiticalDamage", "Damage", "ElectricDamage", "FireDamage", "Image", "IsDeleted", "MagicDamage", "Name", "PoisionDamage" },
                values: new object[,]
                {
                    { 1, true, "A1", null, 72.0m, 65m, 63.0m, 67.5m, "assets/armas.png", false, 10m, "Espada Larga", 31.5m },
                    { 2, true, "A2", null, 81.0m, 85m, 76.5m, 45.0m, "assets/armas.png", false, 20m, "Claymore", 63.0m },
                    { 3, true, "A3", null, 54.0m, 45m, 27.0m, 85.5m, "assets/armas.png", false, 10m, "Daga de Bandido", 13.5m },
                    { 4, true, "A4", null, 76.5m, 90m, 49.5m, 40.5m, "assets/armas.png", false, 20m, "Hacha de Batalla", 58.5m },
                    { 5, true, "A5", null, 67.5m, 70m, 81.0m, 58.5m, "assets/armas.png", false, 20m, "Lanza de Plata", 40.5m },
                    { 6, true, "A6", null, 63.0m, 60m, 90.0m, 36.0m, "assets/armas.png", false, 10m, "Arco Largo", 27.0m },
                    { 7, true, "A7", null, 85.5m, 95m, 54.0m, 31.5m, "assets/armas.png", false, 30m, "Martillo de Guerra", 76.5m },
                    { 8, true, "A8", null, 58.5m, 75m, 58.5m, 76.5m, "assets/armas.png", false, 20m, "Katana de Uchigatana", 36.0m },
                    { 9, true, "B1", null, 45.0m, 80m, 67.5m, 54.0m, "assets/armas.png", false, 30m, "Bastón del Hechicero", 22.5m },
                    { 10, true, "B2", null, 76.5m, 100m, 72.0m, 27.0m, "assets/armas.png", false, 40m, "Espadón Negro", 81.0m },
                    { 11, true, "B3", null, 63.0m, 55m, 45.0m, 81.0m, "assets/armas.png", false, 10m, "Cimitarra", 22.5m },
                    { 12, true, "B4", null, 54.0m, 95m, 85.5m, 45.0m, "assets/armas.png", false, 40m, "Lanza del Dragón", 49.5m },
                    { 13, true, "B5", null, 72.0m, 85m, 81.0m, 22.5m, "assets/armas.png", false, 20m, "Ballesta Pesada", 54.0m },
                    { 14, true, "B6", null, 49.5m, 40m, 22.5m, 90.0m, "assets/armas.png", false, 20m, "Daga de Parry", 9.0m },
                    { 15, true, "B7", null, 67.5m, 80m, 67.5m, 49.5m, "assets/armas.png", false, 30m, "Espada Flamberge", 45.0m },
                    { 16, true, "B8", null, 81.0m, 105m, 45.0m, 36.0m, "assets/armas.png", false, 40m, "Hacha Demoniaca", 72.0m },
                    { 17, true, "C1", null, 58.5m, 70m, 85.5m, 54.0m, "assets/armas.png", false, 20m, "Arco Compuesto", 31.5m },
                    { 18, true, "C2", null, 81.0m, 75m, 40.5m, 45.0m, "assets/armas.png", false, 10m, "Maza de Hierro", 49.5m },
                    { 19, true, "C3", null, 22.5m, 110m, 63.0m, 58.5m, "assets/armas.png", false, 40m, "Espada Cristalina", 40.5m },
                    { 20, true, "C4", null, 58.5m, 60m, 31.5m, 76.5m, "assets/armas.png", false, 20m, "Garra de Lobo", 18.0m },
                    { 21, true, "C5", null, 40.5m, 85m, 72.0m, 49.5m, "assets/armas.png", false, 30m, "Bastón de Llamas", 27.0m },
                    { 22, true, "C6", null, 72.0m, 95m, 67.5m, 40.5m, "assets/armas.png", false, 30m, "Espada del Caballero Negro", 58.5m },
                    { 23, true, "C7", null, 54.0m, 50m, 27.0m, 85.5m, "assets/armas.png", false, 20m, "Puñales Gemelos", 18.0m },
                    { 24, true, "C8", null, 63.0m, 90m, 76.5m, 54.0m, "assets/armas.png", false, 30m, "Lanza de Plata Divina", 45.0m },
                    { 25, true, "D1", null, 90.0m, 120m, 49.5m, 18.0m, "assets/armas.png", false, 40m, "Martillo del Titán", 90.0m },
                    { 26, true, "D2", null, 67.5m, 65m, 76.5m, 63.0m, "assets/armas.png", false, 10m, "Arco de Cazador", 22.5m },
                    { 27, true, "D3", null, 36.0m, 100m, 58.5m, 63.0m, "assets/armas.png", false, 40m, "Espada Maldita", 40.5m },
                    { 28, true, "D4", null, 76.5m, 85m, 90.0m, 36.0m, "assets/armas.png", false, 20m, "Alabarda", 67.5m },
                    { 29, true, "D5", null, 58.5m, 55m, 63.0m, 72.0m, "assets/armas.png", false, 10m, "Estoque", 22.5m },
                    { 30, true, "D6", null, 85.5m, 110m, 54.0m, 22.5m, "assets/armas.png", false, 30m, "Hacha Gigante", 85.5m },
                    { 31, true, "D7", null, 49.5m, 75m, 67.5m, 58.5m, "assets/armas.png", false, 20m, "Bastón de Hielo", 27.0m },
                    { 32, true, "D8", null, 27.0m, 45m, 54.0m, 81.0m, "assets/armas.png", false, 10m, "Cuchillo Arrojadizo", 13.5m },
                    { 33, true, "E1", null, 54.0m, 105m, 72.0m, 54.0m, "assets/armas.png", false, 40m, "Espada de Moonlight", 49.5m },
                    { 34, true, "E2", null, 63.0m, 70m, 76.5m, 67.5m, "assets/armas.png", false, 30m, "Lanza Alada", 36.0m },
                    { 35, true, "E3", null, 76.5m, 115m, 45.0m, 27.0m, "assets/armas.png", false, 40m, "Martillo del Caos", 81.0m },
                    { 36, true, "E4", null, 63.0m, 60m, 72.0m, 63.0m, "assets/armas.png", false, 10m, "Ballesta Ligera", 31.5m },
                    { 37, true, "E5", null, 67.5m, 65m, 49.5m, 76.5m, "assets/armas.png", false, 20m, "Espada Curva", 31.5m },
                    { 38, true, "E6", null, 45.0m, 55m, 85.5m, 67.5m, "assets/armas.png", false, 20m, "Látigo Espinoso", 27.0m },
                    { 39, true, "E7", null, 36.0m, 95m, 76.5m, 45.0m, "assets/armas.png", false, 40m, "Bastón del Archimago", 31.5m },
                    { 40, true, "E8", null, 81.0m, 100m, 58.5m, 31.5m, "assets/armas.png", false, 30m, "Hacha de Ejecutor", 72.0m },
                    { 41, true, "F1", null, 49.5m, 50m, 31.5m, 81.0m, "assets/armas.png", false, 20m, "Daga Venenosa", 18.0m },
                    { 42, true, "F2", null, 58.5m, 90m, 90.0m, 40.5m, "assets/armas.png", false, 40m, "Arco del Cazador de Dragones", 45.0m },
                    { 43, true, "F3", null, 63.0m, 85m, 63.0m, 63.0m, "assets/armas.png", false, 30m, "Espada del Crepúsculo", 40.5m },
                    { 44, true, "F4", null, 67.5m, 80m, 81.0m, 54.0m, "assets/armas.png", false, 30m, "Tridente de Poseidón", 49.5m },
                    { 45, true, "F5", null, 76.5m, 70m, 45.0m, 49.5m, "assets/armas.png", false, 20m, "Maza de Plata", 45.0m },
                    { 46, true, "F6", null, 54.0m, 90m, 58.5m, 58.5m, "assets/armas.png", false, 30m, "Espada de Llamas", 36.0m },
                    { 47, true, "F7", null, 72.0m, 75m, 85.5m, 45.0m, "assets/armas.png", false, 20m, "Guja", 54.0m },
                    { 48, true, "F8", null, 76.5m, 80m, 67.5m, 54.0m, "assets/armas.png", false, 20m, "Espada Bastarda", 49.5m },
                    { 49, true, "G1", null, 45.0m, 75m, 76.5m, 72.0m, "assets/armas.png", false, 30m, "Ballesta del Asesino", 27.0m },
                    { 50, true, "G2", null, 81.0m, 105m, 49.5m, 36.0m, "assets/armas.png", false, 40m, "Martillo de Tormenta", 76.5m },
                    { 51, true, "G3", null, 40.5m, 60m, 36.0m, 85.5m, "assets/armas.png", false, 30m, "Daga de Sombras", 16.2m },
                    { 52, true, "G4", null, 45.0m, 110m, 67.5m, 49.5m, "assets/armas.png", false, 40m, "Espada del Alma", 45.0m },
                    { 53, true, "G5", null, 54.0m, 65m, 76.5m, 63.0m, "assets/armas.png", false, 20m, "Lanza de Hueso", 31.5m },
                    { 54, true, "G6", null, 31.5m, 100m, 81.0m, 40.5m, "assets/armas.png", false, 40m, "Bastón de Rayo", 36.0m },
                    { 55, true, "G7", null, 72.0m, 95m, 40.5m, 45.0m, "assets/armas.png", false, 30m, "Hacha de Carnicero", 63.0m },
                    { 56, true, "G8", null, 63.0m, 120m, 72.0m, 45.0m, "assets/armas.png", false, 40m, "Espada del Destino", 54.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Decks_CardId",
                table: "Decks",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_GamePlayerId",
                table: "Decks",
                column: "GamePlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_PlayerId",
                table: "GamePlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_RoomId",
                table: "GamePlayers",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "GamePlayers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
