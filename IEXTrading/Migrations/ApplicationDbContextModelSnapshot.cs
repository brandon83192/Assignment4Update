﻿// <auto-generated />
using GHI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GHI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GHI.Models.Company", b =>
                {
                    b.Property<string>("hospital_name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("state");

                    b.Property<string>("city");

                    b.Property<string>("phone_number");

                    b.HasKey("hospital_name");

                    b.ToTable("HospitalInfo");
                });

            
#pragma warning restore 612, 618
        }
    }
}
