﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PurchaseInvoiceLine
    {
        public int PurchaseInvoiceLineId { get; set; }
        public int? PurchaseInvoiceHeaderId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public string BuyfromVendorNo { get; set; }
        public int? RecordType { get; set; }
        public string RecordNo { get; set; }
        public string LocationCode { get; set; }
        public string PostingGroup { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitofMeasure { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public decimal? UnitCostLcy { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? LineDiscountPercent { get; set; }
        public decimal? LineDiscountAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountIncludingVat { get; set; }
        public decimal? UnitPriceLcy { get; set; }
        public byte? AllowInvoiceDisc { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? UnitsperParcel { get; set; }
        public decimal? UnitVolume { get; set; }
        public int? AppltoItemEntry { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string JobNo { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public string PaytoVendorNo { get; set; }
        public decimal? InvDiscountAmount { get; set; }
        public string VendorItemNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? VatcalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int? AttachedtoLineNo { get; set; }
        public string EntryPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public byte? UseTax { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string BlanketOrderNo { get; set; }
        public int? BlanketOrderLineNo { get; set; }
        public string ReceiptNo { get; set; }
        public int? ReceiptLineNo { get; set; }
        public string OrderNo { get; set; }
        public int? OrderLineNo { get; set; }
        public decimal? VatbaseAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public decimal? LineAmount { get; set; }
        public decimal? Vatdifference { get; set; }
        public string Vatidentifier { get; set; }
        public int? IcpartnerRefType { get; set; }
        public string IcpartnerReference { get; set; }
        public byte? PrepaymentLine { get; set; }
        public string IcpartnerCode { get; set; }
        public DateTime? PostingDate { get; set; }
        public string JobTaskNo { get; set; }
        public int? JobLineType { get; set; }
        public decimal? JobUnitPrice { get; set; }
        public decimal? JobTotalPrice { get; set; }
        public decimal? JobLineAmount { get; set; }
        public decimal? JobLineDiscountAmount { get; set; }
        public decimal? JobLineDiscountPercent { get; set; }
        public decimal? JobUnitPriceLcy { get; set; }
        public decimal? JobTotalPriceLcy { get; set; }
        public decimal? JobLineAmountLcy { get; set; }
        public decimal? JobLineDiscAmountLcy { get; set; }
        public decimal? JobCurrencyFactor { get; set; }
        public string JobCurrencyCode { get; set; }
        public string ProdOrderNo { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public DateTime? FapostingDate { get; set; }
        public int? FapostingType { get; set; }
        public string DepreciationBookCode { get; set; }
        public decimal? SalvageValue { get; set; }
        public byte? DepruntilFapostingDate { get; set; }
        public byte? DeprAcquisitionCost { get; set; }
        public string MaintenanceCode { get; set; }
        public string InsuranceNo { get; set; }
        public string BudgetedFano { get; set; }
        public string DuplicateinDepreciationBook { get; set; }
        public byte? UseDuplicationList { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string CrossReferenceNo { get; set; }
        public string UnitofMeasureCrossRef { get; set; }
        public int? CrossReferenceType { get; set; }
        public string CrossReferenceTypeNo { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string RoutingNo { get; set; }
        public string OperationNo { get; set; }
        public string WorkCenterNo { get; set; }
        public int? ProdOrderLineNo { get; set; }
        public decimal? OverheadRate { get; set; }
        public int? RoutingReferenceNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
