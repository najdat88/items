﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Najd.Md.Items.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace Najd.Md.Items.Migrations
{
    [DbContext(typeof(ItemsHttpApiHostMigrationsDbContext))]
    partial class ItemsHttpApiHostMigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Najd.Md.Items.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ative")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("ative");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("code");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("creation_time");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("creator_id");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("ItemType_Id")
                        .HasColumnType("uuid")
                        .HasColumnName("item_type_id");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("name");

                    b.Property<int>("Serial")
                        .HasColumnType("integer")
                        .HasColumnName("serial");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("short_description");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("text")
                        .HasColumnName("thumbnail");

                    b.HasKey("Id");

                    b.HasIndex("ItemType_Id");

                    b.ToTable("item", (string)null);
                });

            modelBuilder.Entity("Najd.Md.Items.ItemCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("Category_Id")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("creation_time");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("creator_id");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("Item_Id")
                        .HasColumnType("uuid")
                        .HasColumnName("item_id");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.HasKey("Id");

                    b.HasIndex("Item_Id");

                    b.ToTable("item_category", (string)null);
                });

            modelBuilder.Entity("Najd.Md.Items.ItemPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("AgentPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("agent_price");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric")
                        .HasColumnName("cost");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("creation_time");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("creator_id");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<DateTime?>("FromDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("from_date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid?>("Item_Id")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("item_id");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("to_date");

                    b.HasKey("Id");

                    b.HasIndex("Item_Id");

                    b.ToTable("item_price", (string)null);
                });

            modelBuilder.Entity("Najd.Md.Items.ItemType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("code");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("creation_time");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("creator_id");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<int?>("LineOrder")
                        .HasColumnType("integer")
                        .HasColumnName("line_order");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("item_type", (string)null);
                });

            modelBuilder.Entity("Najd.Md.Items.Item", b =>
                {
                    b.HasOne("Najd.Md.Items.ItemType", "ItemType")
                        .WithMany("Items")
                        .HasForeignKey("ItemType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("Najd.Md.Items.ItemCategory", b =>
                {
                    b.HasOne("Najd.Md.Items.Item", "Item")
                        .WithMany("ItemCategories")
                        .HasForeignKey("Item_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Najd.Md.Items.ItemPrice", b =>
                {
                    b.HasOne("Najd.Md.Items.Item", "Item")
                        .WithMany("ItemPrices")
                        .HasForeignKey("Item_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Najd.Md.Items.Item", b =>
                {
                    b.Navigation("ItemCategories");

                    b.Navigation("ItemPrices");
                });

            modelBuilder.Entity("Najd.Md.Items.ItemType", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
