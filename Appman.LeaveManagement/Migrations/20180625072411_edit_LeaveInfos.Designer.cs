﻿// <auto-generated />
using System;
using Appman.LeaveManagement.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Appman.LeaveManagement.Migrations
{
    [DbContext(typeof(LeaveManagementDbContext))]
    [Migration("20180625072411_edit_LeaveInfos")]
    partial class edit_LeaveInfos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Appman.LeaveManagement.DatabaseContext.Model.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<DateTime>("StartWorkingDate");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Appman.LeaveManagement.DatabaseContext.Model.LeaveInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApprovedBy");

                    b.Property<DateTime>("AprroveTime");

                    b.Property<byte[]>("AttachedFile");

                    b.Property<string>("Comment");

                    b.Property<Guid>("EmployeeId");

                    b.Property<int>("HoursEndDate");

                    b.Property<int>("HoursStartDate");

                    b.Property<bool>("Status");

                    b.Property<string>("Type");

                    b.Property<DateTime>("endDateTime");

                    b.Property<DateTime>("startDateTime");

                    b.HasKey("Id");

                    b.ToTable("LeaveInfos");
                });

            modelBuilder.Entity("Appman.LeaveManagement.DatabaseContext.Model.MdGender", b =>
                {
                    b.Property<string>("GenderCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EN");

                    b.Property<string>("TH");

                    b.HasKey("GenderCode");

                    b.ToTable("MdGenders");
                });

            modelBuilder.Entity("Appman.LeaveManagement.DatabaseContext.Model.RemainingHours", b =>
                {
                    b.Property<Guid>("EmployeeId");

                    b.Property<string>("Year");

                    b.Property<int>("AnnualHours");

                    b.Property<int>("LWPHours");

                    b.Property<int>("SickHours");

                    b.HasKey("EmployeeId", "Year");

                    b.ToTable("RemainingHours");
                });

            modelBuilder.Entity("Appman.LeaveManagement.DatabaseContext.Model.Reporting", b =>
                {
                    b.Property<Guid>("EmployeeId");

                    b.Property<Guid>("ReportingTo");

                    b.HasKey("EmployeeId", "ReportingTo");

                    b.ToTable("Reportings");
                });
#pragma warning restore 612, 618
        }
    }
}
