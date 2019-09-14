﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDKWebPortalWebAPI.Models;

namespace SDKWebPortalWebAPI.Migrations
{
    [DbContext(typeof(SDKWebPortalWebAPIContex))]
    partial class SDKWebPortalWebAPIContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.FamilyMembers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<int>("TC");

                    b.HasKey("Id");

                    b.HasAlternateKey("TC")
                        .HasName("AlternateKey_TC");

                    b.ToTable("FamilyMembers");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("CellPhone");

                    b.Property<int>("HomePhone");

                    b.HasKey("Id");

                    b.ToTable("House");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.HouseAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answers");

                    b.Property<int>("HouseId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("HouseAnswers");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.HouseQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("Questions");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("HouseQuestions");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.ObservationAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answers");

                    b.Property<int>("HouseId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("ObservationAnswers");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.ObservationQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("Questions");

                    b.HasKey("Id");

                    b.ToTable("ObservationQuestions");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.PersonelAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answers");

                    b.Property<int>("FamilyMemberId");

                    b.Property<int>("HouseId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("PersonelAnswers");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.PersonelQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("Questions");

                    b.HasKey("Id");

                    b.ToTable("PersonelQuestions");
                });

            modelBuilder.Entity("SDKWebPortalWebAPI.Models.HouseQuestions", b =>
                {
                    b.HasOne("SDKWebPortalWebAPI.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
