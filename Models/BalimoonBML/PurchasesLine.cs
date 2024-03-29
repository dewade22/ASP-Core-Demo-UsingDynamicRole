﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PurchasesLine
    {
        public int PurchaseLineId { get; set; }
        public int PurchaseHeaderId { get; set; }
        public int DocumentType { get; set; }
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
        public decimal? OutstandingQuantity { get; set; }
        public decimal? QtytoInvoice { get; set; }
        public decimal? QtytoReceive { get; set; }
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
        public decimal? OutstandingAmount { get; set; }
        public decimal? QtyRcdNotInvoiced { get; set; }
        public decimal? AmtRcdNotInvoiced { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public string ReceiptNo { get; set; }
        public int? ReceiptSeqLineNo { get; set; }
        public decimal? ProfitPercent { get; set; }
        public string PaytoVendorNo { get; set; }
        public decimal? InvDiscountAmount { get; set; }
        public string VendorItemNo { get; set; }
        public string SalesOrderNo { get; set; }
        public int? SalesOrderSeqLineNo { get; set; }
        public byte? DropShipment { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? VatcalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int? AttachedtoSeqLineNo { get; set; }
        public string EntryPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public byte? UseTax { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? OutstandingAmountLcy { get; set; }
        public decimal? AmtRcdNotInvoicedLcy { get; set; }
        public string BlanketOrderNo { get; set; }
        public int? BlanketOrderSeqLineNo { get; set; }
        public decimal? VatbaseAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public decimal? LineAmount { get; set; }
        public decimal? Vatdifference { get; set; }
        public decimal? InvDiscAmounttoInvoice { get; set; }
        public string Vatidentifier { get; set; }
        public int? IcpartnerRefType { get; set; }
        public string IcpartnerReference { get; set; }
        public decimal? PrepaymentPercent { get; set; }
        public decimal? PrepmtLineAmount { get; set; }
        public decimal? PrepmtAmtInv { get; set; }
        public decimal? PrepmtAmtInclVat { get; set; }
        public decimal? PrepaymentAmount { get; set; }
        public decimal? PrepmtVatbaseAmt { get; set; }
        public decimal? PrepaymentVatpercent { get; set; }
        public int? PrepmtVatcalcType { get; set; }
        public string PrepaymentVatidentifier { get; set; }
        public string PrepaymentTaxAreaCode { get; set; }
        public byte? PrepaymentTaxLiable { get; set; }
        public string PrepaymentTaxGroupCode { get; set; }
        public decimal? PrepmtAmttoDeduct { get; set; }
        public decimal? PrepmtAmtDeducted { get; set; }
        public byte? PrepaymentLine { get; set; }
        public decimal? PrepmtAmountInvInclVat { get; set; }
        public decimal? PrepmtAmountInvLcy { get; set; }
        public string IcpartnerCode { get; set; }
        public decimal? PrepaymentVatdifference { get; set; }
        public decimal? PrepmtVatdifftoDeduct { get; set; }
        public decimal? PrepmtVatdiffDeducted { get; set; }
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
        public decimal? OutstandingQtyBase { get; set; }
        public decimal? QtytoInvoiceBase { get; set; }
        public decimal? QtytoReceiveBase { get; set; }
        public decimal? QtyRcdNotInvoicedBase { get; set; }
        public decimal? QtyReceivedBase { get; set; }
        public decimal? QtyInvoicedBase { get; set; }
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
        public byte? SpecialOrder { get; set; }
        public string SpecialOrderSalesNo { get; set; }
        public int? SpecialOrderSalesSeqLineNo { get; set; }
        public byte? CompletelyReceived { get; set; }
        public DateTime? RequestedReceiptDate { get; set; }
        public DateTime? PromisedReceiptDate { get; set; }
        public string LeadTimeCalculation { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public DateTime? PlannedReceiptDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public byte? AllowItemChargeAssignment { get; set; }
        public decimal? ReturnQtytoShip { get; set; }
        public decimal? ReturnQtytoShipBase { get; set; }
        public decimal? ReturnQtyShippedNotInvd { get; set; }
        public decimal? RetQtyShpdNotInvdBase { get; set; }
        public decimal? ReturnShpdNotInvd { get; set; }
        public decimal? ReturnShpdNotInvdLcy { get; set; }
        public decimal? ReturnQtyShipped { get; set; }
        public decimal? ReturnQtyShippedBase { get; set; }
        public string ReturnShipmentNo { get; set; }
        public int? ReturnShipmentSeqLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public string Division { get; set; }
        public decimal? OriginalQuantity { get; set; }
        public decimal? OriginalQuantitybase { get; set; }
        public decimal? QuantityDifference { get; set; }
        public decimal? CrossDocDifference { get; set; }
        public string ReservedForLocationCode { get; set; }
        public string ConfigurationId { get; set; }
        public decimal? UnitRetailValue { get; set; }
        public string RoutingNo { get; set; }
        public string OperationNo { get; set; }
        public string WorkCenterNo { get; set; }
        public byte? Finished { get; set; }
        public int? ProdOrderSeqLineNo { get; set; }
        public decimal? OverheadRate { get; set; }
        public byte? Mpsorder { get; set; }
        public int? PlanningFlexibility { get; set; }
        public string SafetyLeadTime { get; set; }
        public int? RoutingReferenceNo { get; set; }
        public string RefPrno { get; set; }
        public int? RefPrlineNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
