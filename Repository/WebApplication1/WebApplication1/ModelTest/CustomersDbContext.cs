using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.ModelTest;

public partial class CustomersDbContext : DbContext
{
    public CustomersDbContext()
    {
    }

    public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customer1> Customers1 { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<RemittInfo> RemittInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ITFIP61\\SQLEXPRESS;Database=CustomersDb;Initial Catalog=CustomersDb;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8714987B3");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer1>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8F909FE79");

            entity.ToTable("Customers");

            entity.Property(e => e.CustomerEmail).HasMaxLength(90);
            entity.Property(e => e.CustomerName).HasMaxLength(90);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07BF7B94E5");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CDC9CE7683");

            entity.Property(e => e.MfgDate).HasColumnType("date");
            entity.Property(e => e.ProductName).HasMaxLength(70);

            entity.HasOne(d => d.Customer).WithMany(p => p.Products)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__Custom__51300E55");
        });

        modelBuilder.Entity<RemittInfo>(entity =>
        {
            entity.HasKey(e => new { e.IssuingBranch, e.RemittanceNo, e.RemittanceType });

            entity.ToTable("RemittInfo");

            entity.Property(e => e.IssuingBranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemittanceNo).ValueGeneratedOnAdd();
            entity.Property(e => e.RemittanceType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AdviceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApplicantAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantCellphone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankBrInfo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryAddress)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryCellPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BenificiaryDob)
                .HasColumnType("date")
                .HasColumnName("BenificiaryDOB");
            entity.Property(e => e.BenificiaryExpireDate).HasColumnType("date");
            entity.Property(e => e.BenificiaryIdIssueDate).HasColumnType("date");
            entity.Property(e => e.Commission).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateofPayment).HasColumnType("date");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.ExchangeRefference)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Famount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FAmount");
            entity.Property(e => e.FirstVerifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstVerifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IssuePaymentCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.OriginatingCountry)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PassportNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhotoIdNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PhotoIdType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RemittancePurpose)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RespondingBranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondVerifiedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecondVerifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SecurityCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Smsstatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('0000')")
                .IsFixedLength()
                .HasColumnName("SMSStatus");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StopPayReason)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StopPaymentBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StopPaymentDate).HasColumnType("date");
            entity.Property(e => e.TestKey)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TestKeyDate).HasColumnType("date");
            entity.Property(e => e.TransDate).HasColumnType("date");
            entity.Property(e => e.TransactionMode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("VAT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
