// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Razor_PizzaWeb.Data;

#nullable disable

namespace Razor_PizzaWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220628124029_updateOrderModelToppingsV3")]
    partial class updateOrderModelToppingsV3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Razor_PizzaWeb.Models.AdminModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminModels");
                });

            modelBuilder.Entity("Razor_PizzaWeb.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BasePrize")
                        .HasColumnType("real");

                    b.Property<float>("FinalPrize")
                        .HasColumnType("real");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toppings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PizzaOrders");
                });

            modelBuilder.Entity("Razor_PizzaWeb.Models.PizzaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("BasePrize")
                        .HasColumnType("real");

                    b.Property<bool>("Cheese")
                        .HasColumnType("bit");

                    b.Property<float>("FinalPrize")
                        .HasColumnType("real");

                    b.Property<bool>("Ham")
                        .HasColumnType("bit");

                    b.Property<bool>("Mushroom")
                        .HasColumnType("bit");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SalamiPeperoni")
                        .HasColumnType("bit");

                    b.Property<bool>("TomatoSauce")
                        .HasColumnType("bit");

                    b.Property<bool>("Tuna")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PizzaModels");
                });
#pragma warning restore 612, 618
        }
    }
}
