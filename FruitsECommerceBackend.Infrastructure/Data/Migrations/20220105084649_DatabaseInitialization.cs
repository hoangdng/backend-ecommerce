using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FruitsECommerceBackend.Infrastructure.Data.Migrations
{
    public partial class DatabaseInitialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "FruitsECommerce");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "varchar(1023)", maxLength: 1023, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "varchar(1023)", maxLength: 1023, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingSessions",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShoppingSessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingSessions_ShoppingSessionId",
                        column: x => x.ShoppingSessionId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "ShoppingSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Level = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ShoppingSessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_ShoppingSessions_ShoppingSessionId",
                        column: x => x.ShoppingSessionId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "ShoppingSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryAddresses",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "char(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    District = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Ward = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Note = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValueSql: "getutcdate()"),
                    State = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "FruitsECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "FruitsECommerce",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                schema: "FruitsECommerce",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingSessionId",
                schema: "FruitsECommerce",
                table: "CartItems",
                column: "ShoppingSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                schema: "FruitsECommerce",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ShoppingSessionId",
                schema: "FruitsECommerce",
                table: "Customers",
                column: "ShoppingSessionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Username",
                schema: "FruitsECommerce",
                table: "Customers",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryAddresses_CustomerId",
                schema: "FruitsECommerce",
                table: "DeliveryAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                schema: "FruitsECommerce",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                schema: "FruitsECommerce",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                schema: "FruitsECommerce",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                schema: "FruitsECommerce",
                table: "ProductCategories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "DeliveryAddresses",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "FruitsECommerce");

            migrationBuilder.DropTable(
                name: "ShoppingSessions",
                schema: "FruitsECommerce");
        }
    }
}
