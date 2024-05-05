﻿// <auto-generated />
using System;
using GeziRehberim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeziRehberim.Migrations
{
    [DbContext(typeof(GeziRehberimContext))]
    [Migration("20240307192719_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeziRehberim.Model.AltÖzellik", b =>
                {
                    b.Property<int>("AltÖzellikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AltÖzellikID"), 1L, 1);

                    b.Property<string>("Açıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Başlık")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AltÖzellikID");

                    b.ToTable("AltÖzelliks");
                });

            modelBuilder.Entity("GeziRehberim.Model.BizeUlasın", b =>
                {
                    b.Property<int>("BizeUlasınID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BizeUlasınID"), 1L, 1);

                    b.Property<string>("Baslık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("MailAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MesajTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("İsim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BizeUlasınID");

                    b.ToTable("BizeUlasıns");
                });

            modelBuilder.Entity("GeziRehberim.Model.Duyurular", b =>
                {
                    b.Property<int>("DuyuruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DuyuruID"), 1L, 1);

                    b.Property<string>("Baslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("İcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DuyuruID");

                    b.ToTable("Duyurulars");
                });

            modelBuilder.Entity("GeziRehberim.Model.GidilecekYerler", b =>
                {
                    b.Property<int>("GidilecekYerlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GidilecekYerlerID"), 1L, 1);

                    b.Property<string>("Açıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detay1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detay2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("GündüzGece")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KapakResmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.Property<int?>("RehberID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şehir")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GidilecekYerlerID");

                    b.HasIndex("RehberID");

                    b.ToTable("GidilecekYerlers");
                });

            modelBuilder.Entity("GeziRehberim.Model.HaberBülteni", b =>
                {
                    b.Property<int>("HaberBülteniID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HaberBülteniID"), 1L, 1);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HaberBülteniID");

                    b.ToTable("HaberBültenis");
                });

            modelBuilder.Entity("GeziRehberim.Model.Hakkımzda", b =>
                {
                    b.Property<int>("HakkımzdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HakkımzdaID"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Acıklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslık2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkımzdaID");

                    b.ToTable("Hakkımzdas");
                });

            modelBuilder.Entity("GeziRehberim.Model.Hakkımzda2", b =>
                {
                    b.Property<int>("Hakkımızda2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hakkımızda2ID"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslık1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslık2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Hakkımızda2ID");

                    b.ToTable("Hakkımzda2s");
                });

            modelBuilder.Entity("GeziRehberim.Model.İletisim", b =>
                {
                    b.Property<int>("İletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("İletisimID"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("HaritaLokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("İletisimID");

                    b.ToTable("İletisims");
                });

            modelBuilder.Entity("GeziRehberim.Model.Özellik", b =>
                {
                    b.Property<int>("ÖzellikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ÖzellikID"), 1L, 1);

                    b.Property<string>("Başlık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detaylar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ÖzellikID");

                    b.ToTable("Özelliks");
                });

            modelBuilder.Entity("GeziRehberim.Model.Özellik2", b =>
                {
                    b.Property<int>("Özellik2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Özellik2ID"), 1L, 1);

                    b.Property<string>("Başlık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detaylar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Özellik2ID");

                    b.ToTable("Özellik2s");
                });

            modelBuilder.Entity("GeziRehberim.Model.Referanslar", b =>
                {
                    b.Property<int>("ReferansID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReferansID"), 1L, 1);

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Müşteri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MüşteriResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yorum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferansID");

                    b.ToTable("Referanslars");
                });

            modelBuilder.Entity("GeziRehberim.Model.Rehber", b =>
                {
                    b.Property<int>("RehberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RehberID"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("InstagramURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RehberID");

                    b.ToTable("Rehbers");
                });

            modelBuilder.Entity("GeziRehberim.Model.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervasyonID"), 1L, 1);

                    b.Property<string>("Açıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GidilecekYerlerID")
                        .HasColumnType("int");

                    b.Property<string>("KişiSayısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RezervasyonTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Statu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UygulamaKullanıcısıId")
                        .HasColumnType("int");

                    b.HasKey("RezervasyonID");

                    b.HasIndex("GidilecekYerlerID");

                    b.HasIndex("UygulamaKullanıcısıId");

                    b.ToTable("Rezervasyons");
                });

            modelBuilder.Entity("GeziRehberim.Model.UygulamaKullanıcısı", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GeziRehberim.Model.UygulamaRolü", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("GeziRehberim.Model.Yorumlar", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"), 1L, 1);

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("GidilecekYerlerID")
                        .HasColumnType("int");

                    b.Property<string>("KullanıcıYorum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RehberID")
                        .HasColumnType("int");

                    b.Property<int>("UygulamaKullanıcısıID")
                        .HasColumnType("int");

                    b.Property<DateTime>("YorumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yorumİçerik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("GidilecekYerlerID");

                    b.HasIndex("RehberID");

                    b.HasIndex("UygulamaKullanıcısıID");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GeziRehberim.Model.GidilecekYerler", b =>
                {
                    b.HasOne("GeziRehberim.Model.Rehber", null)
                        .WithMany("GidilecekYerlers")
                        .HasForeignKey("RehberID");
                });

            modelBuilder.Entity("GeziRehberim.Model.Rezervasyon", b =>
                {
                    b.HasOne("GeziRehberim.Model.GidilecekYerler", "GidilecekYerler")
                        .WithMany("Rezervasyons")
                        .HasForeignKey("GidilecekYerlerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", "UygulamaKullanıcısı")
                        .WithMany("Rezervasyons")
                        .HasForeignKey("UygulamaKullanıcısıId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GidilecekYerler");

                    b.Navigation("UygulamaKullanıcısı");
                });

            modelBuilder.Entity("GeziRehberim.Model.Yorumlar", b =>
                {
                    b.HasOne("GeziRehberim.Model.GidilecekYerler", "GidilecekYerler")
                        .WithMany("Yorumlars")
                        .HasForeignKey("GidilecekYerlerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeziRehberim.Model.Rehber", "Rehber")
                        .WithMany()
                        .HasForeignKey("RehberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", "UygulamaKullanıcısı")
                        .WithMany("Yorumlars")
                        .HasForeignKey("UygulamaKullanıcısıID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GidilecekYerler");

                    b.Navigation("Rehber");

                    b.Navigation("UygulamaKullanıcısı");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("GeziRehberim.Model.UygulamaRolü", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("GeziRehberim.Model.UygulamaRolü", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GeziRehberim.Model.UygulamaKullanıcısı", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeziRehberim.Model.GidilecekYerler", b =>
                {
                    b.Navigation("Rezervasyons");

                    b.Navigation("Yorumlars");
                });

            modelBuilder.Entity("GeziRehberim.Model.Rehber", b =>
                {
                    b.Navigation("GidilecekYerlers");
                });

            modelBuilder.Entity("GeziRehberim.Model.UygulamaKullanıcısı", b =>
                {
                    b.Navigation("Rezervasyons");

                    b.Navigation("Yorumlars");
                });
#pragma warning restore 612, 618
        }
    }
}
