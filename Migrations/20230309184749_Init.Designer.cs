﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using huigma.Data;

#nullable disable

namespace huigma.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230309184749_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("huigma.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FolderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("huigma.Models.Folder", b =>
                {
                    b.HasOne("huigma.Models.Folder", null)
                        .WithMany("InnerFolders")
                        .HasForeignKey("FolderId");
                });

            modelBuilder.Entity("huigma.Models.Folder", b =>
                {
                    b.Navigation("InnerFolders");
                });
#pragma warning restore 612, 618
        }
    }
}