﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgil.WebAPI.Data;

namespace ProAgil.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200521162809_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProAgil.WebAPI.Model.Evento", b =>
                {
                    b.Property<int>("EventoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEvento");

                    b.Property<string>("ImagemURL");

                    b.Property<string>("Local");

                    b.Property<string>("Lote");

                    b.Property<int>("QtdePessoas");

                    b.Property<string>("Tema");

                    b.HasKey("EventoID");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
