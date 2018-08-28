﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Witanra.Web.Models.DatabaseContext;

namespace Witanra.Web.Migrations
{
    [DbContext(typeof(WitanraDBContext))]
    [Migration("20180828184635_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Witanra.Web.Models.DatabaseContext.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Value");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Witanra.Web.Models.DatabaseContext.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
