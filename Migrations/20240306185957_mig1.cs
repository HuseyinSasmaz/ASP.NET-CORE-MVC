using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeziRehberim.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AltÖzelliks",
                columns: table => new
                {
                    AltÖzellikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Başlık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltÖzelliks", x => x.AltÖzellikID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BizeUlasıns",
                columns: table => new
                {
                    BizeUlasınID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BizeUlasıns", x => x.BizeUlasınID);
                });

            migrationBuilder.CreateTable(
                name: "Duyurulars",
                columns: table => new
                {
                    DuyuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurulars", x => x.DuyuruID);
                });

            migrationBuilder.CreateTable(
                name: "GidilecekYerlers",
                columns: table => new
                {
                    GidilecekYerlerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Şehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GündüzGece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    KapakResmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detay1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detay2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GidilecekYerlers", x => x.GidilecekYerlerID);
                });

            migrationBuilder.CreateTable(
                name: "HaberBültenis",
                columns: table => new
                {
                    HaberBülteniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaberBültenis", x => x.HaberBülteniID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkımzda2s",
                columns: table => new
                {
                    Hakkımızda2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslık1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslık2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkımzda2s", x => x.Hakkımızda2ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkımzdas",
                columns: table => new
                {
                    HakkımzdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslık2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkımzdas", x => x.HakkımzdaID);
                });

            migrationBuilder.CreateTable(
                name: "İletisims",
                columns: table => new
                {
                    İletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaritaLokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisims", x => x.İletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Özellik2s",
                columns: table => new
                {
                    Özellik2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Başlık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detaylar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Özellik2s", x => x.Özellik2ID);
                });

            migrationBuilder.CreateTable(
                name: "Özelliks",
                columns: table => new
                {
                    ÖzellikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Başlık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detaylar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Özelliks", x => x.ÖzellikID);
                });

            migrationBuilder.CreateTable(
                name: "Referanslars",
                columns: table => new
                {
                    ReferansID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Müşteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MüşteriResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referanslars", x => x.ReferansID);
                });

            migrationBuilder.CreateTable(
                name: "Rehbers",
                columns: table => new
                {
                    RehberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehbers", x => x.RehberID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Rezervasyons",
                columns: table => new
                {
                    RezervasyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UygulamaKullanıcısıId = table.Column<int>(type: "int", nullable: false),
                    GidilecekYerlerID = table.Column<int>(type: "int", nullable: false),
                    KişiSayısı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RezervasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyons", x => x.RezervasyonID);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_AspNetUsers_UygulamaKullanıcısıId",
                        column: x => x.UygulamaKullanıcısıId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_GidilecekYerlers_GidilecekYerlerID",
                        column: x => x.GidilecekYerlerID,
                        principalTable: "GidilecekYerlers",
                        principalColumn: "GidilecekYerlerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıYorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yorumİçerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    GidilecekYerlerID = table.Column<int>(type: "int", nullable: false),
                    UygulamaKullanıcısıID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_AspNetUsers_UygulamaKullanıcısıID",
                        column: x => x.UygulamaKullanıcısıID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorumlars_GidilecekYerlers_GidilecekYerlerID",
                        column: x => x.GidilecekYerlerID,
                        principalTable: "GidilecekYerlers",
                        principalColumn: "GidilecekYerlerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_GidilecekYerlerID",
                table: "Rezervasyons",
                column: "GidilecekYerlerID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_UygulamaKullanıcısıId",
                table: "Rezervasyons",
                column: "UygulamaKullanıcısıId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_GidilecekYerlerID",
                table: "Yorumlars",
                column: "GidilecekYerlerID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_UygulamaKullanıcısıID",
                table: "Yorumlars",
                column: "UygulamaKullanıcısıID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltÖzelliks");

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
                name: "BizeUlasıns");

            migrationBuilder.DropTable(
                name: "Duyurulars");

            migrationBuilder.DropTable(
                name: "HaberBültenis");

            migrationBuilder.DropTable(
                name: "Hakkımzda2s");

            migrationBuilder.DropTable(
                name: "Hakkımzdas");

            migrationBuilder.DropTable(
                name: "İletisims");

            migrationBuilder.DropTable(
                name: "Özellik2s");

            migrationBuilder.DropTable(
                name: "Özelliks");

            migrationBuilder.DropTable(
                name: "Referanslars");

            migrationBuilder.DropTable(
                name: "Rehbers");

            migrationBuilder.DropTable(
                name: "Rezervasyons");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "GidilecekYerlers");
        }
    }
}
