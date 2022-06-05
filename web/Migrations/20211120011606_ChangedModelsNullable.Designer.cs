﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web.Data;

#nullable disable

namespace web.Migrations
{
    [DbContext(typeof(KnjiznicaContext))]
    [Migration("20211120011606_ChangedModelsNullable")]
    partial class ChangedModelsNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("web.Models.Avtor", b =>
                {
                    b.Property<int>("AvtorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvtorID"), 1L, 1);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priimek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AvtorID");

                    b.ToTable("Avtor", (string)null);
                });

            modelBuilder.Entity("web.Models.Gradivo", b =>
                {
                    b.Property<int>("GradivoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradivoID"), 1L, 1);

                    b.Property<int?>("AvtorID")
                        .HasColumnType("int");

                    b.Property<int?>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<int>("LetoIzdaje")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SteviloStrani")
                        .HasColumnType("int");

                    b.Property<int?>("ZalozbaID")
                        .HasColumnType("int");

                    b.Property<int?>("ZanrID")
                        .HasColumnType("int");

                    b.HasKey("GradivoID");

                    b.HasIndex("AvtorID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("ZalozbaID");

                    b.HasIndex("ZanrID");

                    b.ToTable("Gradivo", (string)null);
                });

            modelBuilder.Entity("web.Models.GradivoIzvod", b =>
                {
                    b.Property<int>("GradivoIzvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradivoIzvodID"), 1L, 1);

                    b.Property<int?>("GradivoID")
                        .HasColumnType("int");

                    b.Property<int?>("IzposojaID")
                        .HasColumnType("int");

                    b.Property<int?>("NakupID")
                        .HasColumnType("int");

                    b.HasKey("GradivoIzvodID");

                    b.HasIndex("GradivoID");

                    b.HasIndex("IzposojaID");

                    b.HasIndex("NakupID");

                    b.ToTable("GradivoIzvod", (string)null);
                });

            modelBuilder.Entity("web.Models.Izposoja", b =>
                {
                    b.Property<int>("IzposojaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IzposojaID"), 1L, 1);

                    b.Property<DateTime>("DatumIzposoje")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVrnitve")
                        .HasColumnType("datetime2");

                    b.Property<string>("UporabnikID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IzposojaID");

                    b.HasIndex("UporabnikID");

                    b.ToTable("Izposoja", (string)null);
                });

            modelBuilder.Entity("web.Models.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategorijaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorija", (string)null);
                });

            modelBuilder.Entity("web.Models.Nakup", b =>
                {
                    b.Property<int>("NakupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NakupID"), 1L, 1);

                    b.Property<string>("Cena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumNakupa")
                        .HasColumnType("datetime2");

                    b.Property<string>("UporabnikID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NakupID");

                    b.HasIndex("UporabnikID");

                    b.ToTable("Nakup", (string)null);
                });

            modelBuilder.Entity("web.Models.Ocena", b =>
                {
                    b.Property<int>("OcenaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OcenaID"), 1L, 1);

                    b.Property<int?>("GradivoID")
                        .HasColumnType("int");

                    b.Property<string>("Mnenje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UporabnikID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Vrednost")
                        .HasColumnType("int");

                    b.HasKey("OcenaID");

                    b.HasIndex("GradivoID");

                    b.HasIndex("UporabnikID");

                    b.ToTable("Ocena", (string)null);
                });

            modelBuilder.Entity("web.Models.Uporabnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CasVpisa")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Priimek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
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

            modelBuilder.Entity("web.Models.Zalozba", b =>
                {
                    b.Property<int>("ZalozbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZalozbaID"), 1L, 1);

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonskaStevilka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZalozbaID");

                    b.ToTable("Zalozba", (string)null);
                });

            modelBuilder.Entity("web.Models.Zanr", b =>
                {
                    b.Property<int>("ZanrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZanrID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZanrID");

                    b.ToTable("Zanr", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("web.Models.Uporabnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("web.Models.Uporabnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web.Models.Uporabnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("web.Models.Uporabnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("web.Models.Gradivo", b =>
                {
                    b.HasOne("web.Models.Avtor", "Avtor")
                        .WithMany("Gradiva")
                        .HasForeignKey("AvtorID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Kategorija", "Kategorija")
                        .WithMany("Gradiva")
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Zalozba", "Zalozba")
                        .WithMany("Gradiva")
                        .HasForeignKey("ZalozbaID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Zanr", "Zanr")
                        .WithMany("Gradiva")
                        .HasForeignKey("ZanrID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Avtor");

                    b.Navigation("Kategorija");

                    b.Navigation("Zalozba");

                    b.Navigation("Zanr");
                });

            modelBuilder.Entity("web.Models.GradivoIzvod", b =>
                {
                    b.HasOne("web.Models.Gradivo", "Gradivo")
                        .WithMany("GradivoIzvodi")
                        .HasForeignKey("GradivoID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Izposoja", "Izposoja")
                        .WithMany("GradivoIzvodi")
                        .HasForeignKey("IzposojaID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Nakup", "Nakup")
                        .WithMany("GradivoIzvodi")
                        .HasForeignKey("NakupID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Gradivo");

                    b.Navigation("Izposoja");

                    b.Navigation("Nakup");
                });

            modelBuilder.Entity("web.Models.Izposoja", b =>
                {
                    b.HasOne("web.Models.Uporabnik", "Uporabnik")
                        .WithMany("Izposoje")
                        .HasForeignKey("UporabnikID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Uporabnik");
                });

            modelBuilder.Entity("web.Models.Nakup", b =>
                {
                    b.HasOne("web.Models.Uporabnik", "Uporabnik")
                        .WithMany("Nakupi")
                        .HasForeignKey("UporabnikID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Uporabnik");
                });

            modelBuilder.Entity("web.Models.Ocena", b =>
                {
                    b.HasOne("web.Models.Gradivo", "Gradivo")
                        .WithMany("Ocene")
                        .HasForeignKey("GradivoID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("web.Models.Uporabnik", "Uporabnik")
                        .WithMany("Ocene")
                        .HasForeignKey("UporabnikID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Gradivo");

                    b.Navigation("Uporabnik");
                });

            modelBuilder.Entity("web.Models.Avtor", b =>
                {
                    b.Navigation("Gradiva");
                });

            modelBuilder.Entity("web.Models.Gradivo", b =>
                {
                    b.Navigation("GradivoIzvodi");

                    b.Navigation("Ocene");
                });

            modelBuilder.Entity("web.Models.Izposoja", b =>
                {
                    b.Navigation("GradivoIzvodi");
                });

            modelBuilder.Entity("web.Models.Kategorija", b =>
                {
                    b.Navigation("Gradiva");
                });

            modelBuilder.Entity("web.Models.Nakup", b =>
                {
                    b.Navigation("GradivoIzvodi");
                });

            modelBuilder.Entity("web.Models.Uporabnik", b =>
                {
                    b.Navigation("Izposoje");

                    b.Navigation("Nakupi");

                    b.Navigation("Ocene");
                });

            modelBuilder.Entity("web.Models.Zalozba", b =>
                {
                    b.Navigation("Gradiva");
                });

            modelBuilder.Entity("web.Models.Zanr", b =>
                {
                    b.Navigation("Gradiva");
                });
#pragma warning restore 612, 618
        }
    }
}
