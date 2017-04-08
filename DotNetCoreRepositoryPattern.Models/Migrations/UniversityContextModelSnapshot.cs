using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotNetCoreRepositoryPattern.Models.Infrastructure.Data;

namespace DotNetCoreRepositoryPattern.Models.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreRepositoryPattern.Models.Domain.Model.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<bool>("SoftDelete");

                    b.HasKey("Id");

                    b.ToTable("Lecture");
                });

            modelBuilder.Entity("DotNetCoreRepositoryPattern.Models.Domain.Model.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<bool>("SoftDelete");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("DotNetCoreRepositoryPattern.Models.Domain.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsFaculty");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<long>("Number");

                    b.Property<bool>("SoftDelete");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DotNetCoreRepositoryPattern.Models.Domain.Model.UserSubjectMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<bool>("SoftDelete");

                    b.Property<int>("SubjectId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSubjectMapping");
                });

            modelBuilder.Entity("DotNetCoreRepositoryPattern.Models.Domain.Model.UserSubjectMapping", b =>
                {
                    b.HasOne("DotNetCoreRepositoryPattern.Models.Domain.Model.Subject", "Subject")
                        .WithMany("UserSubjectMappings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreRepositoryPattern.Models.Domain.Model.User", "User")
                        .WithMany("UserSubjectMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
