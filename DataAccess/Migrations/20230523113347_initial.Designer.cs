﻿// <auto-generated />
using System;
using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ImperiumDBContext))]
    [Migration("20230523113347_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Entities.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieListID")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("MovieListID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Entities.MovieList", b =>
                {
                    b.Property<int>("MovieListID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieListID");

                    b.ToTable("MovieLists");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieListID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.HasIndex("MovieListID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Movie", b =>
                {
                    b.HasOne("Entities.MovieList", null)
                        .WithMany("Movies")
                        .HasForeignKey("MovieListID");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.HasOne("Entities.MovieList", "MovieList")
                        .WithMany()
                        .HasForeignKey("MovieListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieList");
                });

            modelBuilder.Entity("Entities.MovieList", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
