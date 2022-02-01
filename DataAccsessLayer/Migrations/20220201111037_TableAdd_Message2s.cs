using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class TableAdd_Message2s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    Message2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message2SenderID = table.Column<int>(type: "int", nullable: true),
                    Message2ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Message2Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message2Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message2Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message2Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.Message2ID);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Message2ReceiverID",
                        column: x => x.Message2ReceiverID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Message2SenderID",
                        column: x => x.Message2SenderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Message2ReceiverID",
                table: "Message2s",
                column: "Message2ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Message2SenderID",
                table: "Message2s",
                column: "Message2SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");
        }
    }
}
