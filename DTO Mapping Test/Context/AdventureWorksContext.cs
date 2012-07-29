using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using DTO_Mapping_Test_Entities;

namespace DTO_Mapping_Test.Context
{
    class AdventureWorksContext : ObjectContext
    {
        public const string ConnectionString = "name=AdventureWorksContainer";
        public const string ContainerName = "AdventureWorksContainer";
    
        #region Constructors
    
        public AdventureWorksContext()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            this.ContextOptions.ProxyCreationEnabled = false;
        }
    
        public AdventureWorksContext(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            this.ContextOptions.ProxyCreationEnabled = false;
        }

        public AdventureWorksContext(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            this.ContextOptions.ProxyCreationEnabled = false;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<AWBuildVersion> AWBuildVersions
        {
            get { return _aWBuildVersions  ?? (_aWBuildVersions = CreateObjectSet<AWBuildVersion>("AWBuildVersions")); }
        }
        private ObjectSet<AWBuildVersion> _aWBuildVersions;
    
        public ObjectSet<DatabaseLog> DatabaseLogs
        {
            get { return _databaseLogs  ?? (_databaseLogs = CreateObjectSet<DatabaseLog>("DatabaseLogs")); }
        }
        private ObjectSet<DatabaseLog> _databaseLogs;
    
        public ObjectSet<ErrorLog> ErrorLogs
        {
            get { return _errorLogs  ?? (_errorLogs = CreateObjectSet<ErrorLog>("ErrorLogs")); }
        }
        private ObjectSet<ErrorLog> _errorLogs;
    
        public ObjectSet<Department> Departments
        {
            get { return _departments  ?? (_departments = CreateObjectSet<Department>("Departments")); }
        }
        private ObjectSet<Department> _departments;
    
        public ObjectSet<Employee> Employees
        {
            get { return _employees  ?? (_employees = CreateObjectSet<Employee>("Employees")); }
        }
        private ObjectSet<Employee> _employees;
    
        public ObjectSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get { return _employeeDepartmentHistories  ?? (_employeeDepartmentHistories = CreateObjectSet<EmployeeDepartmentHistory>("EmployeeDepartmentHistories")); }
        }
        private ObjectSet<EmployeeDepartmentHistory> _employeeDepartmentHistories;
    
        public ObjectSet<EmployeePayHistory> EmployeePayHistories
        {
            get { return _employeePayHistories  ?? (_employeePayHistories = CreateObjectSet<EmployeePayHistory>("EmployeePayHistories")); }
        }
        private ObjectSet<EmployeePayHistory> _employeePayHistories;
    
        public ObjectSet<JobCandidate> JobCandidates
        {
            get { return _jobCandidates  ?? (_jobCandidates = CreateObjectSet<JobCandidate>("JobCandidates")); }
        }
        private ObjectSet<JobCandidate> _jobCandidates;
    
        public ObjectSet<Shift> Shifts
        {
            get { return _shifts  ?? (_shifts = CreateObjectSet<Shift>("Shifts")); }
        }
        private ObjectSet<Shift> _shifts;
    
        public ObjectSet<Address> Addresses
        {
            get { return _addresses  ?? (_addresses = CreateObjectSet<Address>("Addresses")); }
        }
        private ObjectSet<Address> _addresses;
    
        public ObjectSet<AddressType> AddressTypes
        {
            get { return _addressTypes  ?? (_addressTypes = CreateObjectSet<AddressType>("AddressTypes")); }
        }
        private ObjectSet<AddressType> _addressTypes;
    
        public ObjectSet<BusinessEntity> BusinessEntities
        {
            get { return _businessEntities  ?? (_businessEntities = CreateObjectSet<BusinessEntity>("BusinessEntities")); }
        }
        private ObjectSet<BusinessEntity> _businessEntities;
    
        public ObjectSet<BusinessEntityAddress> BusinessEntityAddresses
        {
            get { return _businessEntityAddresses  ?? (_businessEntityAddresses = CreateObjectSet<BusinessEntityAddress>("BusinessEntityAddresses")); }
        }
        private ObjectSet<BusinessEntityAddress> _businessEntityAddresses;
    
        public ObjectSet<BusinessEntityContact> BusinessEntityContacts
        {
            get { return _businessEntityContacts  ?? (_businessEntityContacts = CreateObjectSet<BusinessEntityContact>("BusinessEntityContacts")); }
        }
        private ObjectSet<BusinessEntityContact> _businessEntityContacts;
    
        public ObjectSet<ContactType> ContactTypes
        {
            get { return _contactTypes  ?? (_contactTypes = CreateObjectSet<ContactType>("ContactTypes")); }
        }
        private ObjectSet<ContactType> _contactTypes;
    
        public ObjectSet<CountryRegion> CountryRegions
        {
            get { return _countryRegions  ?? (_countryRegions = CreateObjectSet<CountryRegion>("CountryRegions")); }
        }
        private ObjectSet<CountryRegion> _countryRegions;
    
        public ObjectSet<EmailAddress> EmailAddresses
        {
            get { return _emailAddresses  ?? (_emailAddresses = CreateObjectSet<EmailAddress>("EmailAddresses")); }
        }
        private ObjectSet<EmailAddress> _emailAddresses;
    
        public ObjectSet<Password> Passwords
        {
            get { return _passwords  ?? (_passwords = CreateObjectSet<Password>("Passwords")); }
        }
        private ObjectSet<Password> _passwords;
    
        public ObjectSet<Person> People
        {
            get { return _people  ?? (_people = CreateObjectSet<Person>("People")); }
        }
        private ObjectSet<Person> _people;
    
        public ObjectSet<PersonPhone> PersonPhones
        {
            get { return _personPhones  ?? (_personPhones = CreateObjectSet<PersonPhone>("PersonPhones")); }
        }
        private ObjectSet<PersonPhone> _personPhones;
    
        public ObjectSet<PhoneNumberType> PhoneNumberTypes
        {
            get { return _phoneNumberTypes  ?? (_phoneNumberTypes = CreateObjectSet<PhoneNumberType>("PhoneNumberTypes")); }
        }
        private ObjectSet<PhoneNumberType> _phoneNumberTypes;
    
        public ObjectSet<StateProvince> StateProvinces
        {
            get { return _stateProvinces  ?? (_stateProvinces = CreateObjectSet<StateProvince>("StateProvinces")); }
        }
        private ObjectSet<StateProvince> _stateProvinces;
    
        public ObjectSet<BillOfMaterial> BillOfMaterials
        {
            get { return _billOfMaterials  ?? (_billOfMaterials = CreateObjectSet<BillOfMaterial>("BillOfMaterials")); }
        }
        private ObjectSet<BillOfMaterial> _billOfMaterials;
    
        public ObjectSet<Culture> Cultures
        {
            get { return _cultures  ?? (_cultures = CreateObjectSet<Culture>("Cultures")); }
        }
        private ObjectSet<Culture> _cultures;
    
        public ObjectSet<Illustration> Illustrations
        {
            get { return _illustrations  ?? (_illustrations = CreateObjectSet<Illustration>("Illustrations")); }
        }
        private ObjectSet<Illustration> _illustrations;
    
        public ObjectSet<Location> Locations
        {
            get { return _locations  ?? (_locations = CreateObjectSet<Location>("Locations")); }
        }
        private ObjectSet<Location> _locations;
    
        public ObjectSet<Product> Products
        {
            get { return _products  ?? (_products = CreateObjectSet<Product>("Products")); }
        }
        private ObjectSet<Product> _products;
    
        public ObjectSet<ProductCategory> ProductCategories
        {
            get { return _productCategories  ?? (_productCategories = CreateObjectSet<ProductCategory>("ProductCategories")); }
        }
        private ObjectSet<ProductCategory> _productCategories;
    
        public ObjectSet<ProductCostHistory> ProductCostHistories
        {
            get { return _productCostHistories  ?? (_productCostHistories = CreateObjectSet<ProductCostHistory>("ProductCostHistories")); }
        }
        private ObjectSet<ProductCostHistory> _productCostHistories;
    
        public ObjectSet<ProductDescription> ProductDescriptions
        {
            get { return _productDescriptions  ?? (_productDescriptions = CreateObjectSet<ProductDescription>("ProductDescriptions")); }
        }
        private ObjectSet<ProductDescription> _productDescriptions;
    
        public ObjectSet<ProductDocument> ProductDocuments
        {
            get { return _productDocuments  ?? (_productDocuments = CreateObjectSet<ProductDocument>("ProductDocuments")); }
        }
        private ObjectSet<ProductDocument> _productDocuments;
    
        public ObjectSet<ProductInventory> ProductInventories
        {
            get { return _productInventories  ?? (_productInventories = CreateObjectSet<ProductInventory>("ProductInventories")); }
        }
        private ObjectSet<ProductInventory> _productInventories;
    
        public ObjectSet<ProductListPriceHistory> ProductListPriceHistories
        {
            get { return _productListPriceHistories  ?? (_productListPriceHistories = CreateObjectSet<ProductListPriceHistory>("ProductListPriceHistories")); }
        }
        private ObjectSet<ProductListPriceHistory> _productListPriceHistories;
    
        public ObjectSet<ProductModel> ProductModels
        {
            get { return _productModels  ?? (_productModels = CreateObjectSet<ProductModel>("ProductModels")); }
        }
        private ObjectSet<ProductModel> _productModels;
    
        public ObjectSet<ProductModelIllustration> ProductModelIllustrations
        {
            get { return _productModelIllustrations  ?? (_productModelIllustrations = CreateObjectSet<ProductModelIllustration>("ProductModelIllustrations")); }
        }
        private ObjectSet<ProductModelIllustration> _productModelIllustrations;
    
        public ObjectSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get { return _productModelProductDescriptionCultures  ?? (_productModelProductDescriptionCultures = CreateObjectSet<ProductModelProductDescriptionCulture>("ProductModelProductDescriptionCultures")); }
        }
        private ObjectSet<ProductModelProductDescriptionCulture> _productModelProductDescriptionCultures;
    
        public ObjectSet<ProductPhoto> ProductPhotoes
        {
            get { return _productPhotoes  ?? (_productPhotoes = CreateObjectSet<ProductPhoto>("ProductPhotoes")); }
        }
        private ObjectSet<ProductPhoto> _productPhotoes;
    
        public ObjectSet<ProductProductPhoto> ProductProductPhotoes
        {
            get { return _productProductPhotoes  ?? (_productProductPhotoes = CreateObjectSet<ProductProductPhoto>("ProductProductPhotoes")); }
        }
        private ObjectSet<ProductProductPhoto> _productProductPhotoes;
    
        public ObjectSet<ProductReview> ProductReviews
        {
            get { return _productReviews  ?? (_productReviews = CreateObjectSet<ProductReview>("ProductReviews")); }
        }
        private ObjectSet<ProductReview> _productReviews;
    
        public ObjectSet<ProductSubcategory> ProductSubcategories
        {
            get { return _productSubcategories  ?? (_productSubcategories = CreateObjectSet<ProductSubcategory>("ProductSubcategories")); }
        }
        private ObjectSet<ProductSubcategory> _productSubcategories;
    
        public ObjectSet<ScrapReason> ScrapReasons
        {
            get { return _scrapReasons  ?? (_scrapReasons = CreateObjectSet<ScrapReason>("ScrapReasons")); }
        }
        private ObjectSet<ScrapReason> _scrapReasons;
    
        public ObjectSet<TransactionHistory> TransactionHistories
        {
            get { return _transactionHistories  ?? (_transactionHistories = CreateObjectSet<TransactionHistory>("TransactionHistories")); }
        }
        private ObjectSet<TransactionHistory> _transactionHistories;
    
        public ObjectSet<TransactionHistoryArchive> TransactionHistoryArchives
        {
            get { return _transactionHistoryArchives  ?? (_transactionHistoryArchives = CreateObjectSet<TransactionHistoryArchive>("TransactionHistoryArchives")); }
        }
        private ObjectSet<TransactionHistoryArchive> _transactionHistoryArchives;
    
        public ObjectSet<UnitMeasure> UnitMeasures
        {
            get { return _unitMeasures  ?? (_unitMeasures = CreateObjectSet<UnitMeasure>("UnitMeasures")); }
        }
        private ObjectSet<UnitMeasure> _unitMeasures;
    
        public ObjectSet<WorkOrder> WorkOrders
        {
            get { return _workOrders  ?? (_workOrders = CreateObjectSet<WorkOrder>("WorkOrders")); }
        }
        private ObjectSet<WorkOrder> _workOrders;
    
        public ObjectSet<WorkOrderRouting> WorkOrderRoutings
        {
            get { return _workOrderRoutings  ?? (_workOrderRoutings = CreateObjectSet<WorkOrderRouting>("WorkOrderRoutings")); }
        }
        private ObjectSet<WorkOrderRouting> _workOrderRoutings;
    
        public ObjectSet<ProductVendor> ProductVendors
        {
            get { return _productVendors  ?? (_productVendors = CreateObjectSet<ProductVendor>("ProductVendors")); }
        }
        private ObjectSet<ProductVendor> _productVendors;
    
        public ObjectSet<PurchaseOrderDetail> PurchaseOrderDetails
        {
            get { return _purchaseOrderDetails  ?? (_purchaseOrderDetails = CreateObjectSet<PurchaseOrderDetail>("PurchaseOrderDetails")); }
        }
        private ObjectSet<PurchaseOrderDetail> _purchaseOrderDetails;
    
        public ObjectSet<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get { return _purchaseOrderHeaders  ?? (_purchaseOrderHeaders = CreateObjectSet<PurchaseOrderHeader>("PurchaseOrderHeaders")); }
        }
        private ObjectSet<PurchaseOrderHeader> _purchaseOrderHeaders;
    
        public ObjectSet<ShipMethod> ShipMethods
        {
            get { return _shipMethods  ?? (_shipMethods = CreateObjectSet<ShipMethod>("ShipMethods")); }
        }
        private ObjectSet<ShipMethod> _shipMethods;
    
        public ObjectSet<Vendor> Vendors
        {
            get { return _vendors  ?? (_vendors = CreateObjectSet<Vendor>("Vendors")); }
        }
        private ObjectSet<Vendor> _vendors;
    
        public ObjectSet<CountryRegionCurrency> CountryRegionCurrencies
        {
            get { return _countryRegionCurrencies  ?? (_countryRegionCurrencies = CreateObjectSet<CountryRegionCurrency>("CountryRegionCurrencies")); }
        }
        private ObjectSet<CountryRegionCurrency> _countryRegionCurrencies;
    
        public ObjectSet<CreditCard> CreditCards
        {
            get { return _creditCards  ?? (_creditCards = CreateObjectSet<CreditCard>("CreditCards")); }
        }
        private ObjectSet<CreditCard> _creditCards;
    
        public ObjectSet<Currency> Currencies
        {
            get { return _currencies  ?? (_currencies = CreateObjectSet<Currency>("Currencies")); }
        }
        private ObjectSet<Currency> _currencies;
    
        public ObjectSet<CurrencyRate> CurrencyRates
        {
            get { return _currencyRates  ?? (_currencyRates = CreateObjectSet<CurrencyRate>("CurrencyRates")); }
        }
        private ObjectSet<CurrencyRate> _currencyRates;
    
        public ObjectSet<Customer> Customers
        {
            get { return _customers  ?? (_customers = CreateObjectSet<Customer>("Customers")); }
        }
        private ObjectSet<Customer> _customers;
    
        public ObjectSet<PersonCreditCard> PersonCreditCards
        {
            get { return _personCreditCards  ?? (_personCreditCards = CreateObjectSet<PersonCreditCard>("PersonCreditCards")); }
        }
        private ObjectSet<PersonCreditCard> _personCreditCards;
    
        public ObjectSet<SalesOrderDetail> SalesOrderDetails
        {
            get { return _salesOrderDetails  ?? (_salesOrderDetails = CreateObjectSet<SalesOrderDetail>("SalesOrderDetails")); }
        }
        private ObjectSet<SalesOrderDetail> _salesOrderDetails;
    
        public ObjectSet<SalesOrderHeader> SalesOrderHeaders
        {
            get { return _salesOrderHeaders  ?? (_salesOrderHeaders = CreateObjectSet<SalesOrderHeader>("SalesOrderHeaders")); }
        }
        private ObjectSet<SalesOrderHeader> _salesOrderHeaders;
    
        public ObjectSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
        {
            get { return _salesOrderHeaderSalesReasons  ?? (_salesOrderHeaderSalesReasons = CreateObjectSet<SalesOrderHeaderSalesReason>("SalesOrderHeaderSalesReasons")); }
        }
        private ObjectSet<SalesOrderHeaderSalesReason> _salesOrderHeaderSalesReasons;
    
        public ObjectSet<SalesPerson> SalesPersons
        {
            get { return _salesPersons  ?? (_salesPersons = CreateObjectSet<SalesPerson>("SalesPersons")); }
        }
        private ObjectSet<SalesPerson> _salesPersons;
    
        public ObjectSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories
        {
            get { return _salesPersonQuotaHistories  ?? (_salesPersonQuotaHistories = CreateObjectSet<SalesPersonQuotaHistory>("SalesPersonQuotaHistories")); }
        }
        private ObjectSet<SalesPersonQuotaHistory> _salesPersonQuotaHistories;
    
        public ObjectSet<SalesReason> SalesReasons
        {
            get { return _salesReasons  ?? (_salesReasons = CreateObjectSet<SalesReason>("SalesReasons")); }
        }
        private ObjectSet<SalesReason> _salesReasons;
    
        public ObjectSet<SalesTaxRate> SalesTaxRates
        {
            get { return _salesTaxRates  ?? (_salesTaxRates = CreateObjectSet<SalesTaxRate>("SalesTaxRates")); }
        }
        private ObjectSet<SalesTaxRate> _salesTaxRates;
    
        public ObjectSet<SalesTerritory> SalesTerritories
        {
            get { return _salesTerritories  ?? (_salesTerritories = CreateObjectSet<SalesTerritory>("SalesTerritories")); }
        }
        private ObjectSet<SalesTerritory> _salesTerritories;
    
        public ObjectSet<SalesTerritoryHistory> SalesTerritoryHistories
        {
            get { return _salesTerritoryHistories  ?? (_salesTerritoryHistories = CreateObjectSet<SalesTerritoryHistory>("SalesTerritoryHistories")); }
        }
        private ObjectSet<SalesTerritoryHistory> _salesTerritoryHistories;
    
        public ObjectSet<ShoppingCartItem> ShoppingCartItems
        {
            get { return _shoppingCartItems  ?? (_shoppingCartItems = CreateObjectSet<ShoppingCartItem>("ShoppingCartItems")); }
        }
        private ObjectSet<ShoppingCartItem> _shoppingCartItems;
    
        public ObjectSet<SpecialOffer> SpecialOffers
        {
            get { return _specialOffers  ?? (_specialOffers = CreateObjectSet<SpecialOffer>("SpecialOffers")); }
        }
        private ObjectSet<SpecialOffer> _specialOffers;
    
        public ObjectSet<SpecialOfferProduct> SpecialOfferProducts
        {
            get { return _specialOfferProducts  ?? (_specialOfferProducts = CreateObjectSet<SpecialOfferProduct>("SpecialOfferProducts")); }
        }
        private ObjectSet<SpecialOfferProduct> _specialOfferProducts;
    
        public ObjectSet<Store> Stores
        {
            get { return _stores  ?? (_stores = CreateObjectSet<Store>("Stores")); }
        }
        private ObjectSet<Store> _stores;

        #endregion
    }
}
