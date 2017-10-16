﻿// <auto-generated />
using Drake.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Drake.Core.Migrations
{
    [DbContext(typeof(DrakeContext))]
    partial class DrakeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Drake.Core.File", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Commits");

                    b.Property<string>("Path");

                    b.Property<int>("RepositoryId");

                    b.HasKey("FileId");

                    b.HasIndex("RepositoryId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Drake.Core.Repository", b =>
                {
                    b.Property<int>("RepositoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("LastPullTime");

                    b.Property<string>("RepositoryUri");

                    b.HasKey("RepositoryId");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("Drake.Core.File", b =>
                {
                    b.HasOne("Drake.Core.Repository", "Repository")
                        .WithMany("Files")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
