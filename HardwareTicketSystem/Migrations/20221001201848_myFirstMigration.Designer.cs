﻿// <auto-generated />
using HardwareTicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HardwareTicketSystem.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221001201848_myFirstMigration")]
    partial class myFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HardwareTicketSystem.Models.Ticket", b =>
                {
                    b.Property<int>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ticketId");

                    b.ToTable("TicketTable");

                    b.HasData(
                        new
                        {
                            ticketId = 111,
                            description = "Environment update",
                            empAddress = "sharath@firstam.com",
                            empName = "Sharath",
                            status = "Opened",
                            type = "Technical"
                        },
                        new
                        {
                            ticketId = 112,
                            description = "Update Windows",
                            empAddress = "dhanu@firstam.com",
                            empName = "Dhanu",
                            status = "Closed",
                            type = "Software"
                        },
                        new
                        {
                            ticketId = 113,
                            description = "Networking",
                            empAddress = "rahul@firstam.com",
                            empName = "Rahul",
                            status = "Processing",
                            type = "Hardware"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
