﻿// <auto-generated />
using System;
using GaziLibrary.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace GaziLibrary.Migrations
{
    [DbContext(typeof(OracleContext))]
    [Migration("20220817123518_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Image")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("TypeId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TypeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.BorrowedBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Text")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PositionId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Book", b =>
                {
                    b.HasOne("GaziLibrary.Entities.Concrete.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GaziLibrary.Entities.Concrete.Type", "Type")
                        .WithMany("Books")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.BorrowedBook", b =>
                {
                    b.HasOne("GaziLibrary.Entities.Concrete.Book", "Book")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GaziLibrary.Entities.Concrete.User", "User")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Message", b =>
                {
                    b.HasOne("GaziLibrary.Entities.Concrete.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.User", b =>
                {
                    b.HasOne("GaziLibrary.Entities.Concrete.Position", "Position")
                        .WithMany("Users")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Book", b =>
                {
                    b.Navigation("BorrowedBooks");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Position", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.Type", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("GaziLibrary.Entities.Concrete.User", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
