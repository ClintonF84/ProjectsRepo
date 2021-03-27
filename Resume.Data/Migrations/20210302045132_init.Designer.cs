﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resume.Data;

namespace Resume.Data.Migrations
{
    [DbContext(typeof(ResumeDb))]
    [Migration("20210302045132_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Data.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YearGraduatedFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("Resume.Data.ResumeSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.HasIndex("SkillId");

                    b.ToTable("ResumeSkills");
                });

            modelBuilder.Entity("Resume.Data.ResumeWorkHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("int");

                    b.Property<int>("ReusmeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkHistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.HasIndex("WorkHistoryId");

                    b.ToTable("ResumeWorkHistories");
                });

            modelBuilder.Entity("Resume.Data.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillTypeId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Resume.Data.SkillType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SkillType");
                });

            modelBuilder.Entity("Resume.Data.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Resume.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Resume.Data.WorkHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkHistory");
                });

            modelBuilder.Entity("Resume.Data.WorkHistorySkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("WorkHistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("WorkHistoryId");

                    b.ToTable("WorkHistorySkills");
                });

            modelBuilder.Entity("Resume.Data.WorkHistoryTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("WorkHistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("WorkHistoryId");

                    b.ToTable("WorkHistoryTasks");
                });

            modelBuilder.Entity("Resume.Data.ResumeSkill", b =>
                {
                    b.HasOne("Resume.Data.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Data.Skill", "Skill")
                        .WithMany("ResumeSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Resume.Data.ResumeWorkHistory", b =>
                {
                    b.HasOne("Resume.Data.Resume", "Resume")
                        .WithMany("WorkHistory")
                        .HasForeignKey("ResumeId");

                    b.HasOne("Resume.Data.WorkHistory", "WorkHistory")
                        .WithMany()
                        .HasForeignKey("WorkHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");

                    b.Navigation("WorkHistory");
                });

            modelBuilder.Entity("Resume.Data.Skill", b =>
                {
                    b.HasOne("Resume.Data.SkillType", "SkillType")
                        .WithMany()
                        .HasForeignKey("SkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkillType");
                });

            modelBuilder.Entity("Resume.Data.User", b =>
                {
                    b.HasOne("Resume.Data.Resume", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("Resume.Data.WorkHistorySkill", b =>
                {
                    b.HasOne("Resume.Data.Skill", "Skill")
                        .WithMany("WorkHistorySkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Data.WorkHistory", "WorkHistory")
                        .WithMany("Skills")
                        .HasForeignKey("WorkHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("WorkHistory");
                });

            modelBuilder.Entity("Resume.Data.WorkHistoryTask", b =>
                {
                    b.HasOne("Resume.Data.Task", "Task")
                        .WithMany("WorkHistoryTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Data.WorkHistory", "WorkHistory")
                        .WithMany("Tasks")
                        .HasForeignKey("WorkHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("WorkHistory");
                });

            modelBuilder.Entity("Resume.Data.Resume", b =>
                {
                    b.Navigation("Skills");

                    b.Navigation("WorkHistory");
                });

            modelBuilder.Entity("Resume.Data.Skill", b =>
                {
                    b.Navigation("ResumeSkills");

                    b.Navigation("WorkHistorySkills");
                });

            modelBuilder.Entity("Resume.Data.Task", b =>
                {
                    b.Navigation("WorkHistoryTasks");
                });

            modelBuilder.Entity("Resume.Data.WorkHistory", b =>
                {
                    b.Navigation("Skills");

                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
