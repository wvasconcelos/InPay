using System.Collections.Generic;

namespace InPay
{
    public class ApiOrder
    {
        public string orderID { get; set; }
        public string poNumber { get; set; }
        public string orderDate { get; set; }
        public string accountID { get; set; }
        public string qbListID { get; set; }
        public string qbFullName { get; set; }
        public string billToCompany { get; set; }
        public string billToName { get; set; }
        public string billToAddress1 { get; set; }
        public string billToAddress2 { get; set; }
        public string billToAddress3 { get; set; }
        public string billToCity { get; set; }
        public string billToState { get; set; }
        public string billToCountry { get; set; }
        public string billToZipCode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string shipToCompany { get; set; }
        public string shipToName { get; set; }
        public string shipToAddress1 { get; set; }
        public string shipToAddress2 { get; set; }
        public string shipToAddress3 { get; set; }
        public string shipToCity { get; set; }
        public string shipToState { get; set; }
        public string shipToCountry { get; set; }
        public string shipToZipCode { get; set; }
        public string shipCost { get; set; }
        public string shipMethod { get; set; }
        public string shipCustomerAcct { get; set; }
        public string taxCost { get; set; }
        public string coupon { get; set; }
        public string subtotal { get; set; }
        public string total { get; set; }
        public string giftCertificate { get; set; }
        public string discount { get; set; }
        public string payMethod { get; set; }
        public string ccType { get; set; }
        public string currency { get; set; }
        public string createBy { get; set; }
        public string updateDate { get; set; }
        public string orderStatus { get; set; }
        public string memo { get; set; }
        public bool ready { get; set; }
        public List<ApiOrderItem> cart = new List<ApiOrderItem>();
    } //END: API ORDER CLASS

    public class ApiOrderItem
    {
        public int index { get; set; }
        public string listingID { get; set; }
        public string sku { get; set; }
        public string mpn { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string manufacturer { get; set; }
        public string unitPrice { get; set; }
        public string unitDiscount { get; set; }
        public string quantity { get; set; }
        public string subtotal { get; set; }
        public string unitWeight { get; set; }
        public string unitWidth { get; set; }
        public string unitLength { get; set; }
        public string unitHeight { get; set; }
        public string options { get; set; }
    } //END: API ORDER ITEM CLASS
}