using System;
using System.Collections.Generic;

namespace WebApplication1.ModelTest;

public partial class RemittInfo
{
    public string IssuingBranch { get; set; } = null!;

    public string? ApplicantId { get; set; }

    public string? ApplicantName { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? ApplicantCellphone { get; set; }

    public string? PassportNo { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryAddress { get; set; }

    public string? BeneficiaryCellPhone { get; set; }

    public int RemittanceNo { get; set; }

    public string RemittanceType { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public decimal Amount { get; set; }

    public decimal ExchangeRate { get; set; }

    public decimal Famount { get; set; }

    public decimal Commission { get; set; }

    public decimal Vat { get; set; }

    public string IssuePaymentCode { get; set; } = null!;

    public string? TransactionMode { get; set; }

    public string RespondingBranch { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? PaymentType { get; set; }

    public bool? Payment { get; set; }

    public DateTime? DateofPayment { get; set; }

    public string? PaymentBy { get; set; }

    public string? AdviceNo { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? FirstVerifiedDate { get; set; }

    public string? FirstVerifiedBy { get; set; }

    public DateTime? SecondVerifiedDate { get; set; }

    public string? SecondVerifiedBy { get; set; }

    public bool? StopPayment { get; set; }

    public string? SecurityCode { get; set; }

    public string? Remarks { get; set; }

    public string? TestKey { get; set; }

    public DateTime? TestKeyDate { get; set; }

    public string? ExchangeRefference { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public string? PhotoIdType { get; set; }

    public string? PhotoIdNumber { get; set; }

    public string? BankBrInfo { get; set; }

    public string? StopPayReason { get; set; }

    public string? StopPaymentBy { get; set; }

    public DateTime? StopPaymentDate { get; set; }

    public string? OriginatingCountry { get; set; }

    public string? Smsstatus { get; set; }

    public string? RemittancePurpose { get; set; }

    public DateTime? BenificiaryIdIssueDate { get; set; }

    public DateTime? BenificiaryExpireDate { get; set; }

    public DateTime? BenificiaryDob { get; set; }
}
