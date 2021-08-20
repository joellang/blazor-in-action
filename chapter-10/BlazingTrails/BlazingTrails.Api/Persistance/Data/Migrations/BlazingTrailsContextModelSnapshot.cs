﻿// <auto-generated />
using BlazingTrails.Api.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingTrails.Api.Persistance.Data.Migrations
{
    [DbContext(typeof(BlazingTrailsContext))]
    partial class BlazingTrailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("BlazingTrails.Api.Persistance.Entities.Trail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Trails");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistance.Entities.Waypoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrailId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrailId");

                    b.ToTable("Waypoints");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistance.Entities.Waypoint", b =>
                {
                    b.HasOne("BlazingTrails.Api.Persistance.Entities.Trail", "Trail")
                        .WithMany("Waypoints")
                        .HasForeignKey("TrailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trail");
                });

            modelBuilder.Entity("BlazingTrails.Api.Persistance.Entities.Trail", b =>
                {
                    b.Navigation("Waypoints");
                });
#pragma warning restore 612, 618
        }
    }
}
