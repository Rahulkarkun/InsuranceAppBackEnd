﻿// <auto-generated />
using System;
using InsuranceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceApp.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231124180312_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceApp.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<double>("CommissionEarned")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AgentId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("InsuranceApp.Models.Claim", b =>
                {
                    b.Property<int>("ClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaimId"));

                    b.Property<double>("BankAccountNumber")
                        .HasColumnType("float");

                    b.Property<string>("BankIfscCode")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<double>("ClaimAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PolicyNo")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClaimId");

                    b.HasIndex("PolicyNo");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nominee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomineeRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("AgentId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InsuranceApp.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<byte[]>("DocumentFile")
                        .IsRequired()
                        .HasMaxLength(10485760)
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DocumentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("InsuranceApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PlanId");

                    b.ToTable("InsurancePlans");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePolicy", b =>
                {
                    b.Property<int>("PolicyNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicyNo"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaturityDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<double>("PremiumAmount")
                        .HasColumnType("float");

                    b.Property<string>("PremiumType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchemeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SumAssured")
                        .HasColumnType("float");

                    b.HasKey("PolicyNo");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.HasIndex("SchemeId");

                    b.ToTable("InsurancePolicies");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.Property<int>("SchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchemeId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<string>("SchemeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SchemeId");

                    b.HasIndex("PlanId");

                    b.ToTable("InsuranceSchemes");
                });

            modelBuilder.Entity("InsuranceApp.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("TotalPayment")
                        .HasColumnType("float");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("InsuranceApp.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("InsuranceApp.Models.SchemeDetails", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("InstallmentCommRatio")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<double>("MaxAmount")
                        .HasColumnType("float");

                    b.Property<int>("MaxInvestmentTime")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<double>("MinAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinInvestmentTime")
                        .HasColumnType("int");

                    b.Property<double>("ProfitRatio")
                        .HasColumnType("float");

                    b.Property<double>("RegistrationCommRatio")
                        .HasColumnType("float");

                    b.Property<int>("SchemeId")
                        .HasColumnType("int");

                    b.Property<string>("SchemeImage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DetailId");

                    b.HasIndex("SchemeId")
                        .IsUnique();

                    b.ToTable("SchemeDetails");
                });

            modelBuilder.Entity("InsuranceApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InsuranceApp.Models.Admin", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("InsuranceApp.Models.Admin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithOne("Agent")
                        .HasForeignKey("InsuranceApp.Models.Agent", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.Claim", b =>
                {
                    b.HasOne("InsuranceApp.Models.InsurancePolicy", "InsurancePolicy")
                        .WithMany("Claims")
                        .HasForeignKey("PolicyNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsurancePolicy");
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.HasOne("InsuranceApp.Models.Agent", "Agent")
                        .WithMany("Customers")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("InsuranceApp.Models.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.Document", b =>
                {
                    b.HasOne("InsuranceApp.Models.Customer", "Customer")
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InsuranceApp.Models.Employee", b =>
                {
                    b.HasOne("InsuranceApp.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("InsuranceApp.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePolicy", b =>
                {
                    b.HasOne("InsuranceApp.Models.Customer", "Customer")
                        .WithMany("InsurancePolicies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.Payment", "Payment")
                        .WithOne("InsurancePolicy")
                        .HasForeignKey("InsuranceApp.Models.InsurancePolicy", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceApp.Models.InsuranceScheme", "InsuranceScheme")
                        .WithMany("Policies")
                        .HasForeignKey("SchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("InsuranceScheme");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.HasOne("InsuranceApp.Models.InsurancePlan", "InsurancePlan")
                        .WithMany("InsuranceSchemes")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsurancePlan");
                });

            modelBuilder.Entity("InsuranceApp.Models.SchemeDetails", b =>
                {
                    b.HasOne("InsuranceApp.Models.InsuranceScheme", "InsuranceScheme")
                        .WithOne("SchemeDetails")
                        .HasForeignKey("InsuranceApp.Models.SchemeDetails", "SchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceScheme");
                });

            modelBuilder.Entity("InsuranceApp.Models.User", b =>
                {
                    b.HasOne("InsuranceApp.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("InsuranceApp.Models.Agent", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("InsuranceApp.Models.Customer", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("InsurancePolicies");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePlan", b =>
                {
                    b.Navigation("InsuranceSchemes");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsurancePolicy", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceScheme", b =>
                {
                    b.Navigation("Policies");

                    b.Navigation("SchemeDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceApp.Models.Payment", b =>
                {
                    b.Navigation("InsurancePolicy")
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceApp.Models.User", b =>
                {
                    b.Navigation("Admin")
                        .IsRequired();

                    b.Navigation("Agent")
                        .IsRequired();

                    b.Navigation("Customer")
                        .IsRequired();

                    b.Navigation("Employee")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
