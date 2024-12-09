﻿// <auto-generated />
using System;
using Gestion_de_restaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestion_de_restaurant.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20241209123607_premiére migration")]
    partial class premiéremigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestion_de_restaurant.Models.ArticleCommande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CommandeId");

                    b.ToTable("ArticlesCommande");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Articles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrixTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Panier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.PanierItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("PanierId")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("PanierId");

                    b.ToTable("PanierItems");
                });

            modelBuilder.Entity("Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.ArticleCommande", b =>
                {
                    b.HasOne("Gestion_de_restaurant.Models.Articles", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion_de_restaurant.Models.Commande", "Commande")
                        .WithMany("ArticlesCommande")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Commande");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Articles", b =>
                {
                    b.HasOne("Gestion_de_restaurant.Models.Categories", "Categories")
                        .WithMany("Articles")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Commande", b =>
                {
                    b.HasOne("Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Panier", b =>
                {
                    b.HasOne("Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.PanierItem", b =>
                {
                    b.HasOne("Gestion_de_restaurant.Models.Articles", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion_de_restaurant.Models.Panier", "Panier")
                        .WithMany("PanierItems")
                        .HasForeignKey("PanierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Panier");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Categories", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Commande", b =>
                {
                    b.Navigation("ArticlesCommande");
                });

            modelBuilder.Entity("Gestion_de_restaurant.Models.Panier", b =>
                {
                    b.Navigation("PanierItems");
                });
#pragma warning restore 612, 618
        }
    }
}
