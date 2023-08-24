using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInvoncie.NilveraApi.Archive
{ 
    public class SendInvoiceRequest
    {
        public class DespatchDocumentReference
        {
            public DateTime IssueDate { get; set; }
            public string Value { get; set; }
        }

        public class OrderReference
        {
            public DateTime IssueDate { get; set; }
            public string Value { get; set; }
        }

        public class Attachment
        {
            public string Base64Data { get; set; }
            public string MimeCode { get; set; }
            public string FileName { get; set; }
        }

        public class Document
        {
            public string ID { get; set; }
            public DateTime IssueDate { get; set; }
            public string DocumentType { get; set; }
            public string DocumentTypeCode { get; set; }
            public string DocumentDescription { get; set; }
            public Attachment Attachment { get; set; }
        }

        public class TaxExemptionReasonInfo
        {
            public string KDVExemptionReasonCode { get; set; }
            public string OTVExemptionReasonCode { get; set; }
            public string AccommodationTaxExemptionReasonCode { get; set; }
        }

        public class PaymentTermsInfo
        {
            public decimal Percent { get; set; }
            public decimal Amount { get; set; }
            public string Note { get; set; }
        }

        public class PaymentMeansInfo
        {
            public string Code { get; set; }
            public string ChannelCode { get; set; }
            public DateTime DueDate { get; set; }
            public string PayeeFinancialAccountID { get; set; }
            public string Note { get; set; }
        }

        public class OKCInfo
        {
            public string ID { get; set; }
            public DateTime IssueDate { get; set; }
            public string Time { get; set; }
            public string ZNo { get; set; }
            public string EndPointID { get; set; }
            public string DocumentDescription { get; set; }
        }

        public class ReturnInvoiceInfo
        {
            public string InvoiceNumber { get; set; }
            public DateTime IssueDate { get; set; }
        }

        public class Expense
        {
            public string ExpenseType { get; set; }
            public decimal Percent { get; set; }
            public decimal Amount { get; set; }
        }

        public class InternetInfo
        {
            public string WebSite { get; set; }
            public string PaymentMethod { get; set; }
            public string PaymentMethodName { get; set; }
            public DateTime PaymentDate { get; set; }
            public string TransporterName { get; set; }
            public string TransporterRegisterNumber { get; set; }
            public DateTime TransportDate { get; set; }
        }

        public class ArchiveInvoice
        {
            public InvoiceInfo InvoiceInfo { get; set; }
            public CompanyInfo CompanyInfo { get; set; }
            public CustomerInfo CustomerInfo { get; set; }
            public List<InvoiceLine> InvoiceLines { get; set; }
            public List<string> Notes { get; set; }
        }

        public class InvoiceInfo
        {
            public string UUID { get; set; }
            public string TemplateUUID { get; set; }
            public string TemplateBase64String { get; set; }
            public string InvoiceType { get; set; }
            public string InvoiceSerieOrNumber { get; set; }
            public DateTime IssueDate { get; set; }
            public string CurrencyCode { get; set; }
            public decimal ExchangeRate { get; set; }
            public List<DespatchDocumentReference> DespatchDocumentReference { get; set; }
            public OrderReference OrderReference { get; set; }
            public Document OrderReferenceDocument { get; set; }
            public List<Document> AdditionalDocumentReferences { get; set; }
            public TaxExemptionReasonInfo TaxExemptionReasonInfo { get; set; }
            public PaymentTermsInfo PaymentTermsInfo { get; set; }
            public PaymentMeansInfo PaymentMeansInfo { get; set; }
            public OKCInfo OKCInfo { get; set; }
            public List<ReturnInvoiceInfo> ReturnInvoiceInfo { get; set; }
            public List<Expense> Expenses { get; set; }
            public bool ISDespatch { get; set; }
            public string SalesPlatform { get; set; }
            public string SendType { get; set; }
            public InternetInfo InternetInfo { get; set; }
            public string AccountingCost { get; set; }
            public decimal LineExtensionAmount { get; set; }
            public decimal GeneralKDV1Total { get; set; }
            public decimal GeneralKDV8Total { get; set; }
            public decimal GeneralKDV18Total { get; set; }
            public decimal GeneralKDV10Total { get; set; }
            public decimal GeneralKDV20Total { get; set; }
            public decimal GeneralAllowanceTotal { get; set; }
            public decimal PayableAmount { get; set; }
            public decimal KdvTotal { get; set; }
        }

        public class CompanyInfo
        {
            public string TaxNumber { get; set; }
            public string Name { get; set; }
            public string TaxOffice { get; set; }
            public List<PartyIdentification> PartyIdentifications { get; set; }
            public List<AgentPartyIdentification> AgentPartyIdentifications { get; set; }
            public string Address { get; set; }
            public string District { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string PostalCode { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string Mail { get; set; }
            public string WebSite { get; set; }
        }

        public class CustomerInfo
        {
            public string TaxNumber { get; set; }
            public string Name { get; set; }
            public string TaxOffice { get; set; }
            public List<PartyIdentification> PartyIdentifications { get; set; }
            public List<AgentPartyIdentification> AgentPartyIdentifications { get; set; }
            public string Address { get; set; }
            public string District { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string PostalCode { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string Mail { get; set; }
            public string WebSite { get; set; }
        }

        public class InvoiceLine
        {
            public string Index { get; set; }
            public string SellerCode { get; set; }
            public string BuyerCode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Quantity { get; set; }
            public string UnitType { get; set; }
            public decimal Price { get; set; }
            public decimal AllowanceTotal { get; set; }
            public decimal KDVPercent { get; set; }
            public decimal KDVTotal { get; set; }
            public List<Tax> Taxes { get; set; }
            public string ManufacturerCode { get; set; }
            public string BrandName { get; set; }
            public string ModelName { get; set; }
            public string Note { get; set; }
            public string OzelMatrahReason { get; set; }
            public decimal OzelMatrahTotal { get; set; }
            public decimal VatAmountWithoutTevkifat { get; set; }
            public AdditionalItemIdentification AdditionalItemIdentification { get; set; }
        }

        public class PartyIdentification
        {
            public string SchemeID { get; set; }
            public string Value { get; set; }
        }

        public class AgentPartyIdentification
        {
            public string SchemeID { get; set; }
            public string Value { get; set; }
        }

        public class Tax
        {
            public string TaxCode { get; set; }
            public decimal Total { get; set; }
            public decimal Percent { get; set; }
            public string ReasonCode { get; set; }
            public string ReasonDesc { get; set; }
        }

        public class AdditionalItemIdentification
        {
            public string TagNumber { get; set; }
            public string OwnerName { get; set; }
            public string OwnerTaxNumber { get; set; }
        }
    }

}
