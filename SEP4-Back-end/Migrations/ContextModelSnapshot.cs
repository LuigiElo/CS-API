﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEP4_Back_end.Model;

namespace SEP4_Back_end.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEP4_Back_end.Model.CO2", b =>
                {
                    b.Property<int>("CO2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CO2_value")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("CO2ID");

                    b.ToTable("CO2");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.CO2List", b =>
                {
                    b.Property<int>("CO2_ID")
                        .HasColumnType("int");

                    b.Property<int>("ROOM_ID")
                        .HasColumnType("int");

                    b.HasKey("CO2_ID", "ROOM_ID");

                    b.HasIndex("ROOM_ID");

                    b.ToTable("CO2List");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.Humidity", b =>
                {
                    b.Property<int>("HUM_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("HUM_value")
                        .HasColumnType("real");

                    b.HasKey("HUM_ID");

                    b.ToTable("Humidity");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.HumidityList", b =>
                {
                    b.Property<int>("HUM_ID")
                        .HasColumnType("int");

                    b.Property<int>("ROOM_ID")
                        .HasColumnType("int");

                    b.HasKey("HUM_ID", "ROOM_ID");

                    b.HasIndex("ROOM_ID");

                    b.ToTable("HumidityList");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.Servo", b =>
                {
                    b.Property<int>("SERV_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Spinning")
                        .HasColumnType("bit");

                    b.HasKey("SERV_ID");

                    b.ToTable("Servo");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.ServoList", b =>
                {
                    b.Property<int>("SERV_ID")
                        .HasColumnType("int");

                    b.Property<int>("ROOM_ID")
                        .HasColumnType("int");

                    b.HasKey("SERV_ID", "ROOM_ID");

                    b.HasIndex("ROOM_ID");

                    b.ToTable("ServoList");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.Temperature", b =>
                {
                    b.Property<int>("TEMP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("TEMP_value")
                        .HasColumnType("real");

                    b.HasKey("TEMP_ID");

                    b.ToTable("Temperature");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.TemperatureList", b =>
                {
                    b.Property<int>("TEMP_ID")
                        .HasColumnType("int");

                    b.Property<int>("ROOM_ID")
                        .HasColumnType("int");

                    b.HasKey("TEMP_ID", "ROOM_ID");

                    b.HasIndex("ROOM_ID");

                    b.ToTable("TemperatureList");
                });

            modelBuilder.Entity("SEP4_Back_end.Model.CO2List", b =>
                {
                    b.HasOne("SEP4_Back_end.Model.CO2", "CO2")
                        .WithMany()
                        .HasForeignKey("CO2_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP4_Back_end.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("ROOM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP4_Back_end.Model.HumidityList", b =>
                {
                    b.HasOne("SEP4_Back_end.Model.Humidity", "Humidity")
                        .WithMany()
                        .HasForeignKey("HUM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP4_Back_end.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("ROOM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP4_Back_end.Model.ServoList", b =>
                {
                    b.HasOne("SEP4_Back_end.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("ROOM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP4_Back_end.Model.Servo", "Servo")
                        .WithMany()
                        .HasForeignKey("SERV_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP4_Back_end.Model.TemperatureList", b =>
                {
                    b.HasOne("SEP4_Back_end.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("ROOM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP4_Back_end.Model.Temperature", "Temperature")
                        .WithMany()
                        .HasForeignKey("TEMP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
