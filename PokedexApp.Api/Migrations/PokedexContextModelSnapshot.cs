﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokedexApp.Data;

#nullable disable

namespace PokedexApp.Migrations
{
    [DbContext(typeof(PokedexContext))]
    partial class PokedexContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("PokedexApp.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("BaseExperience")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "base_experience");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "height");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "weight");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokedexApp.Models.PokemonStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseStat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Effort")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("StatId");

                    b.ToTable("PokemonStats");
                });

            modelBuilder.Entity("PokedexApp.Models.PokemonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

                    b.HasIndex("TypeId");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("PokedexApp.Models.StatInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StatInfos");
                });

            modelBuilder.Entity("PokedexApp.Models.TypeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeInfos");
                });

            modelBuilder.Entity("PokedexApp.Models.PokemonStat", b =>
                {
                    b.HasOne("PokedexApp.Models.Pokemon", null)
                        .WithMany("Stats")
                        .HasForeignKey("PokemonId");

                    b.HasOne("PokedexApp.Models.StatInfo", "Stat")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("PokedexApp.Models.PokemonType", b =>
                {
                    b.HasOne("PokedexApp.Models.Pokemon", null)
                        .WithMany("Types")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokedexApp.Models.TypeInfo", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("PokedexApp.Models.Pokemon", b =>
                {
                    b.Navigation("Stats");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}
