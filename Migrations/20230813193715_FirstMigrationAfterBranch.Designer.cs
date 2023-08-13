﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Work_Tool;

#nullable disable

namespace Work_Tool.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230813193715_FirstMigrationAfterBranch")]
    partial class FirstMigrationAfterBranch
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("W_Tool_LibreriaClassi.Idea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LabelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.ToTable("Ideas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Idea");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Label_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ambit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LabelColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Ptompt_Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ToDoItem");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("LabelId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TopicId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.HasIndex("TopicId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Work_Tool.WorkToll_libreria_di_classi.Progetto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EstimatedEnd")
                        .HasColumnType("TEXT");

                    b.Property<int>("LabelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Progress")
                        .HasColumnType("REAL");

                    b.Property<TimeSpan>("RollingTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StarData")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.ToTable("Progetto");
                });

            modelBuilder.Entity("Work_Tool.WorkToll_libreria_di_classi.Task_", b =>
                {
                    b.HasBaseType("W_Tool_LibreriaClassi.Idea");

                    b.Property<DateTime>("EndData")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProgettoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartingData")
                        .HasColumnType("TEXT");

                    b.Property<int>("StattusTask")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("TimeSpan")
                        .HasColumnType("TEXT");

                    b.HasIndex("ProgettoId");

                    b.HasDiscriminator().HasValue("Task_");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Idea", b =>
                {
                    b.HasOne("W_Tool_LibreriaClassi.Label_", "Label")
                        .WithMany()
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Topic", b =>
                {
                    b.HasOne("W_Tool_LibreriaClassi.Label_", "Label")
                        .WithMany()
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("W_Tool_LibreriaClassi.Topic", null)
                        .WithMany("SubTopic")
                        .HasForeignKey("TopicId");

                    b.Navigation("Label");
                });

            modelBuilder.Entity("Work_Tool.WorkToll_libreria_di_classi.Progetto", b =>
                {
                    b.HasOne("W_Tool_LibreriaClassi.Label_", "Label")
                        .WithMany()
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");
                });

            modelBuilder.Entity("Work_Tool.WorkToll_libreria_di_classi.Task_", b =>
                {
                    b.HasOne("Work_Tool.WorkToll_libreria_di_classi.Progetto", "Progetto")
                        .WithMany("Tasks")
                        .HasForeignKey("ProgettoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Progetto");
                });

            modelBuilder.Entity("W_Tool_LibreriaClassi.Topic", b =>
                {
                    b.Navigation("SubTopic");
                });

            modelBuilder.Entity("Work_Tool.WorkToll_libreria_di_classi.Progetto", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
