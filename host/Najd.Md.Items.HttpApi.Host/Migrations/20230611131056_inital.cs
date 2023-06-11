using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Najd.Md.Items.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "item_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    name = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    lineorder = table.Column<int>(name: "line_order", type: "integer", nullable: true),
                    creationtime = table.Column<DateTime>(name: "creation_time", type: "timestamp without time zone", nullable: false),
                    creatorid = table.Column<Guid>(name: "creator_id", type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    isdeleted = table.Column<bool>(name: "is_deleted", type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    serial = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    itemtypeid = table.Column<Guid>(name: "item_type_id", type: "uuid", nullable: false),
                    shortdescription = table.Column<string>(name: "short_description", type: "character varying(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    thumbnail = table.Column<string>(type: "text", nullable: true),
                    ative = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    creationtime = table.Column<DateTime>(name: "creation_time", type: "timestamp without time zone", nullable: false),
                    creatorid = table.Column<Guid>(name: "creator_id", type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    isdeleted = table.Column<bool>(name: "is_deleted", type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_item_type_item_type_id",
                        column: x => x.itemtypeid,
                        principalTable: "item_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "item_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    categoryid = table.Column<Guid>(name: "category_id", type: "uuid", nullable: false),
                    itemid = table.Column<Guid>(name: "item_id", type: "uuid", nullable: false),
                    creationtime = table.Column<DateTime>(name: "creation_time", type: "timestamp without time zone", nullable: false),
                    creatorid = table.Column<Guid>(name: "creator_id", type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    isdeleted = table.Column<bool>(name: "is_deleted", type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_category", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_category_item_item_id",
                        column: x => x.itemid,
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "item_price",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    itemid = table.Column<Guid>(name: "item_id", type: "uuid", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    agentprice = table.Column<decimal>(name: "agent_price", type: "numeric", nullable: false),
                    cost = table.Column<decimal>(type: "numeric", nullable: false),
                    fromdate = table.Column<DateTime>(name: "from_date", type: "timestamp without time zone", nullable: true),
                    todate = table.Column<DateTime>(name: "to_date", type: "timestamp without time zone", nullable: true),
                    creationtime = table.Column<DateTime>(name: "creation_time", type: "timestamp without time zone", nullable: false),
                    creatorid = table.Column<Guid>(name: "creator_id", type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    isdeleted = table.Column<bool>(name: "is_deleted", type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_price", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_price_item_item_id",
                        column: x => x.itemid,
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_item_type_id",
                table: "item",
                column: "item_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_category_item_id",
                table: "item_category",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_price_item_id",
                table: "item_price",
                column: "item_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item_category");

            migrationBuilder.DropTable(
                name: "item_price");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "item_type");
        }
    }
}
