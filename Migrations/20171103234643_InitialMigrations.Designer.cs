﻿// <auto-generated />
using app_financas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace app_financas.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20171103234643_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("app_financas.Models.Financas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("data");

                    b.Property<string>("grupo_despesa");

                    b.Property<string>("local_compra");

                    b.Property<string>("numero_doc");

                    b.Property<float>("valor");

                    b.HasKey("id");

                    b.ToTable("financas");
                });
#pragma warning restore 612, 618
        }
    }
}
