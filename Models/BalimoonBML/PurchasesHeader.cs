﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PurchasesHeader
    {
        public int PurchaseHeaderId { get; set; }
        public int DocumentType { get; set; }
        public string No { get; set; }
        public string BuyfromVendorNo { get; set; }
        public string PaytoVendorNo { get; set; }
        public string PaytoName { get; set; }
        public string PaytoName2 { get; set; }
        public string PaytoAddress { get; set; }
        public string PaytoAddress2 { get; set; }
        public string PaytoCity { get; set; }
        public string PaytoContact { get; set; }
        public string YourReference { get; set; }
        public string ShiptoCode { get; set; }
        public string ShiptoName { get; set; }
        public string ShiptoName2 { get; set; }
        public string ShiptoAddress { get; set; }
        public string ShiptoAddress2 { get; set; }
        public string ShiptoCity { get; set; }
        public string ShiptoContact { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string PostingDescription { get; set; }
        public string PaymentTermsCode { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? PaymentDiscountPercent { get; set; }
        public DateTime? PmtDiscountDate { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string VendorPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public byte? PricesIncludingVat { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string LanguageCode { get; set; }
        public string PurchaserCode { get; set; }
        public string OrderClass { get; set; }
        public int? NoPrinted { get; set; }
        public string OnHold { get; set; }
        public int? AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
        public string BalAccountNo { get; set; }
        public byte? IsReceive { get; set; }
        public byte? IsInvoice { get; set; }
        public string ReceivingNo { get; set; }
        public string PostingNo { get; set; }
        public string LastReceivingNo { get; set; }
        public string LastPostingNo { get; set; }
        public string VendorOrderNo { get; set; }
        public string VendorShipmentNo { get; set; }
        public string VendorInvoiceNo { get; set; }
        public string VendorCrMemoNo { get; set; }
        public string VatregistrationNo { get; set; }
        public string SelltoCustomerNo { get; set; }
        public string ReasonCode { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string Vatcountry { get; set; }
        public string BuyfromVendorName { get; set; }
        public string BuyfromVendorName2 { get; set; }
        public string BuyfromAddress { get; set; }
        public string BuyfromAddress2 { get; set; }
        public string BuyfromCity { get; set; }
        public string BuyfromContact { get; set; }
        public string PaytoPostCode { get; set; }
        public string PaytoCountry { get; set; }
        public string BuyfromPostCode { get; set; }
        public string BuyfromCountry { get; set; }
        public string BuyfromFaxNo { get; set; }
        public string BuyfromPhoneNo { get; set; }
        public string ShiptoPostCode { get; set; }
        public string ShiptoCountry { get; set; }
        public int? BalAccountType { get; set; }
        public string OrderAddressCode { get; set; }
        public string EntryPoint { get; set; }
        public byte? Correction { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string PaymentMethodCode { get; set; }
        public string NoSeries { get; set; }
        public string PostingNoSeries { get; set; }
        public string ReceivingNoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string AppliestoId { get; set; }
        public decimal? VatbaseDiscountPercent { get; set; }
        public int? Status { get; set; }
        public int? InvoiceDiscountCalculation { get; set; }
        public decimal? InvoiceDiscountValue { get; set; }
        public byte? SendIcdocument { get; set; }
        public int? Icstatus { get; set; }
        public string BuyfromIcpartnerCode { get; set; }
        public string PaytoIcpartnerCode { get; set; }
        public int? Icdirection { get; set; }
        public string PrepaymentNo { get; set; }
        public string LastPrepaymentNo { get; set; }
        public string PrepmtCrMemoNo { get; set; }
        public string LastPrepmtCrMemoNo { get; set; }
        public decimal? PrepaymentPercent { get; set; }
        public string PrepaymentNoSeries { get; set; }
        public byte? CompressPrepayment { get; set; }
        public DateTime? PrepaymentDueDate { get; set; }
        public string PrepmtCrMemoNoSeries { get; set; }
        public string PrepmtPostingDescription { get; set; }
        public DateTime? PrepmtPmtDiscountDate { get; set; }
        public string PrepmtPaymentTermsCode { get; set; }
        public decimal? PrepmtPaymentDiscountPercent { get; set; }
        public string QuoteNo { get; set; }
        public int? DocNoOccurrence { get; set; }
        public string CampaignNo { get; set; }
        public string BuyfromContactNo { get; set; }
        public string PaytoContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public int? PostingfromWhseRef { get; set; }
        public DateTime? RequestedReceiptDate { get; set; }
        public DateTime? PromisedReceiptDate { get; set; }
        public string LeadTimeCalculation { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public string VendorAuthorizationNo { get; set; }
        public string ReturnShipmentNo { get; set; }
        public string ReturnShipmentNoSeries { get; set; }
        public byte? Ship { get; set; }
        public string LastReturnShipmentNo { get; set; }
        public string AssignedUserId { get; set; }
        public string StoreNo { get; set; }
        public string ItemRegistrationNo { get; set; }
        public byte? OnlyTwoDimensions { get; set; }
        public int? VersionNo { get; set; }
        public int? RtcfilterField { get; set; }
        public byte? InStoreCreatedEntry { get; set; }
        public int? RetailStatus { get; set; }
        public string RecivingPickingNo { get; set; }
        public DateTime? OwnershipSendDate { get; set; }
        public string BuyerId { get; set; }
        public string BuyerGroupCode { get; set; }
        public string CreatedBySourceCode { get; set; }
        public int? RetailPurchaseDestFilter { get; set; }
        public int? RetailPurchaseSourceFilter { get; set; }
        public string GeneralComments { get; set; }
        public byte? RetailSpecialOrder { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountIncludingVat { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? TimeReceived { get; set; }
        public byte? BizTalkPurchaseQuote { get; set; }
        public byte? BizTalkPurchOrderCnfmn { get; set; }
        public byte? BizTalkPurchaseInvoice { get; set; }
        public byte? BizTalkPurchaseReceipt { get; set; }
        public byte? BizTalkPurchaseCreditMemo { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? TimeSent { get; set; }
        public byte? BizTalkRequestforPurchQte { get; set; }
        public byte? BizTalkPurchaseOrder { get; set; }
        public string VendorQuoteNo { get; set; }
        public byte? BizTalkDocumentSent { get; set; }
        public int? Priority { get; set; }
        public string RefPrno { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
