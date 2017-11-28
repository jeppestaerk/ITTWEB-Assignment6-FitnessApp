﻿// <auto-generated />
using ITTWEB_Assignment6_FitnessApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ITTWEBAssignment6FitnessApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171128211742_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ITTWEB_Assignment6_FitnessApp.Models.Exercise", b =>
                {
                    b.Property<double>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Reps");

                    b.Property<int>("Sets");

                    b.Property<double?>("WorkoutId");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ITTWEB_Assignment6_FitnessApp.Models.User", b =>
                {
                    b.Property<double>("Id");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ITTWEB_Assignment6_FitnessApp.Models.Workout", b =>
                {
                    b.Property<double>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("ITTWEB_Assignment6_FitnessApp.Models.Exercise", b =>
                {
                    b.HasOne("ITTWEB_Assignment6_FitnessApp.Models.Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId");
                });

            modelBuilder.Entity("ITTWEB_Assignment6_FitnessApp.Models.Workout", b =>
                {
                    b.HasOne("ITTWEB_Assignment6_FitnessApp.Models.User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
