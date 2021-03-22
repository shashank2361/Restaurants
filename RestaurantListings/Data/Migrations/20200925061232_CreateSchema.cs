using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantListings.Data.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: true),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    PhotoUri = table.Column<string>(nullable: true),
                    FamilyFriendly = table.Column<bool>(nullable: false),
                    VeganFriendly = table.Column<bool>(nullable: false),
                    Tags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 1, "331 Roundhay Road, Harehills, Leeds, LS8 4HT", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent condimentum convallis arcu, vel iaculis tortor. Pellentesque eu ex libero. Vestibulum sit amet lacus lacinia, sagittis odio sit amet, bibendum ipsum. Quisque bibendum rutrum feugiat. Aenean sodales finibus posuere. Cras aliquam a elit vel sagittis. Donec ac libero ex. Quisque nec sapien augue. Vivamus non ipsum a dolor mollis tincidunt vel eget enim. Sed consectetur sem tempus euismod ultricies.", false, "Yokohama", "+44-011-355-5011", "/images/yokohama.jpg", 5.0m, "[\"Japanese\",\"Asian\",\"Healthy\"]", true });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 2, "50 Briggate, Leeds, LS1 6HD", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare mauris sed tortor sodales, sed dapibus mauris maximus. Aliquam quis consectetur nisl. Pellentesque nec lacus erat. In nec tristique justo, at pulvinar quam. Suspendisse finibus mi sit amet rhoncus pharetra. Phasellus finibus augue ac molestie imperdiet. Quisque ac rhoncus lorem, sed vestibulum felis. Maecenas pharetra enim justo, et faucibus ex aliquet ut. Integer congue malesuada luctus. Donec egestas, libero eu consequat consequat, orci magna dictum erat, at auctor magna sem et lectus. Mauris vehicula ornare risus eget posuere. Curabitur eget ultricies purus. Pellentesque ac justo vehicula, congue arcu sed, varius sapien.", true, "Falafel Guys", "+44-011-355-5337", "/images/falafel.jpg", 4.5m, "[\"Fast food\",\"Healthy\",\"British\"]", true });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 3, "65 Haddon Road, Burley, Leeds, LS4 2JE", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dictum justo eget massa rutrum, at scelerisque ipsum fringilla. Curabitur aliquam augue tellus, ac feugiat massa volutpat eget. Praesent fringilla accumsan purus, vitae interdum eros tempus vitae. Sed malesuada pharetra tristique. Sed vel consectetur nunc. Fusce mattis egestas libero non auctor. Phasellus aliquam ex eu accumsan rhoncus. Sed sed ex ut massa facilisis finibus. Vestibulum sed mauris eget sapien vestibulum viverra at nec ex. Integer eleifend malesuada rhoncus.", true, "Bengal Brasserie", "+44-011-355-5564", "/images/bengal.jpg", 4.0m, "[\"Indian\",\"Asian\",\"Bar\"]", true });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 4, "21-22 Park Row, Leeds, LS1 5JF", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus venenatis venenatis velit. In hac habitasse platea dictumst. Vivamus a venenatis dui. Praesent non magna consectetur, tristique mi in, volutpat nulla. Proin risus mauris, ultricies nec fermentum ac, pretium in turpis. Aliquam erat volutpat. Fusce semper neque urna, nec lobortis lorem placerat dictum. Sed ac lobortis lectus. Proin pharetra neque quis purus blandit vestibulum. Aenean lobortis, libero fringilla cursus malesuada, dolor nisl pulvinar felis, quis mollis lacus nisl fringilla arcu. Donec eget maximus urna. Etiam vitae velit nulla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In tristique non dui ac pretium. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", false, "Gaucho", "+44-011-355-5456", "/images/gaucho.jpg", 3.0m, "[\"Steakhouse\",\"Argentinian\",\"Bar\"]", false });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 5, "342 Kirkstall Road, Leeds, LS4 2DS", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sagittis tortor vel sem blandit, eget dignissim dolor porttitor. Morbi elementum lectus vitae velit elementum, quis porta purus porta. Morbi a tincidunt risus. Nam vitae enim sit amet metus imperdiet finibus. Duis id nisl sed nunc bibendum condimentum. Nunc faucibus porta leo. Ut hendrerit odio sed elit lobortis, eu euismod lacus egestas. Vivamus lacus odio, laoreet non turpis in, porttitor luctus tortor.", true, "Viva Cuba", "+44-011-355-5894", "/images/viva.jpg", 4.2m, "[\"Latin\",\"Spanish\",\"Cuban\"]", true });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FamilyFriendly", "Name", "PhoneNumber", "PhotoUri", "Rating", "Tags", "VeganFriendly" },
                values: new object[] { 6, "82 North Street, Leeds, LS2 7PN", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam egestas sapien vel augue consectetur laoreet. Aliquam consequat purus non nibh euismod sollicitudin vitae id eros. Donec vehicula odio eu malesuada sollicitudin. Cras pulvinar elit nec urna sagittis, id convallis arcu tristique. Mauris vulputate sem in ornare vulputate. Donec dictum est sit amet neque laoreet, in dictum ex facilisis. Quisque porta lectus ac libero sodales consectetur. Nullam non pharetra eros, in scelerisque diam. Sed malesuada tellus in risus gravida, eu sagittis nibh pretium.", true, "The Brunswick", "+44-011-355-5955", "/images/brunswick.jpg", 3.7m, "[\"Bar\",\"British\",\"Pub\"]", true });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
