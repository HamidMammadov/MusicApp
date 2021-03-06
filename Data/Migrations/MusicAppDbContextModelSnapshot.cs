﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MusicAppDbContext))]
    partial class MusicAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Albom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("AddedBy")
                        .HasMaxLength(100);

                    b.Property<int>("ArtistId");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Alboms");
                });

            modelBuilder.Entity("Core.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("AddedBy")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Core.Models.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedAt");

                    b.Property<string>("AddedBy")
                        .HasMaxLength(100);

                    b.Property<int>("AlbomId");

                    b.Property<bool>("CanDownload")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<TimeSpan>("Duration");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("ListenCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("AlbomId");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("Core.Models.Albom", b =>
                {
                    b.HasOne("Core.Models.Artist", "Artist")
                        .WithMany("Alboms")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Models.Music", b =>
                {
                    b.HasOne("Core.Models.Albom", "Albom")
                        .WithMany("Musics")
                        .HasForeignKey("AlbomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
