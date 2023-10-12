create database SUV
go
use SUV
go
CREATE TABLE Type
(
  TypeID VARCHAR NOT NULL,
  TypeName NVARCHAR NOT NULL,
  PRIMARY KEY (TypeID)
);

CREATE TABLE Product
(
  ProductID VARCHAR NOT NULL,
  ProductName NVARCHAR NOT NULL,
  ProductDescription NVARCHAR NOT NULL,
  ProductSold INT NOT NULL,
  ProductLastUpdate DATE NOT NULL,
  TypeID VARCHAR NOT NULL,
  PRIMARY KEY (ProductID),
  FOREIGN KEY (TypeID) REFERENCES Type(TypeID)
);

CREATE TABLE Discount
(
  DiscountID VARCHAR NOT NULL,
  DiscountName NVARCHAR NOT NULL,
  DiscountCalUnit NVARCHAR NOT NULL,
  DiscountCondition INT NOT NULL,
  DiscountMaxValue INT NOT NULL,
  DiscountRemark NVARCHAR NOT NULL,
  DiscountAvailableFrom DATE NOT NULL,
  DiscountAvailableUntil DATE NOT NULL,
  DiscountValue INT NOT NULL,
  PRIMARY KEY (DiscountID)
);

CREATE TABLE DetailedProduct
(
  DetaledProductPrice INT NOT NULL,
  DetailedProductQuantity INT NOT NULL,
  DetailedProductID VARCHAR NOT NULL,
  DetailedProductName CHAR NOT NULL,
  ProductID VARCHAR NOT NULL,
  PRIMARY KEY (DetailedProductID),
  FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE Status
(
  StatusID VARCHAR NOT NULL,
  StatusName INT NOT NULL,
  PRIMARY KEY (StatusID)
);

CREATE TABLE TermOfPayment
(
  PaymentID VARCHAR NOT NULL,
  PaymentName NVARCHAR NOT NULL,
  PRIMARY KEY (PaymentID)
);

CREATE TABLE Bill
(
  BillID VARCHAR NOT NULL,
  BillPhoneNumber NVARCHAR NOT NULL,
  BillLastName NVARCHAR NOT NULL,
  BillNote NVARCHAR NOT NULL,
  BillFirstName NVARCHAR NOT NULL,
  BillAddress NVARCHAR NOT NULL,
  BillPostcode NVARCHAR NOT NULL,
  BillEmail NVARCHAR NOT NULL,
  BillProvince NVARCHAR NOT NULL,
  BillPrice INT NOT NULL,
  BillOldPrice INT NOT NULL,
  BillWard NVARCHAR NOT NULL,
  BillTaxAmount INT NOT NULL,
  BillUpdatedAt DATE NOT NULL,
  BillCreatedAt DATE NOT NULL,
  BillSequenceNumber INT NOT NULL,
  BillFinalPrice INT NOT NULL,
  BillDiscountAmount INT NOT NULL,
  BillStatus VARCHAR NOT NULL,
  BillTermOfPayment VARCHAR NOT NULL,
  PRIMARY KEY (BillID),
  FOREIGN KEY (BillStatus) REFERENCES Status(StatusID),
  FOREIGN KEY (BillTermOfPayment) REFERENCES TermOfPayment(PaymentID)
);

CREATE TABLE BillProduct
(
  BillID VARCHAR NOT NULL,
  DetailedProductID VARCHAR NOT NULL,
  Amount INT NOT NULL,
  DetailedProductSequenceNumber INT NOT NULL,
  PRIMARY KEY (BillID, DetailedProductID),
  FOREIGN KEY (BillID) REFERENCES Bill(BillID),
  FOREIGN KEY (DetailedProductID) REFERENCES DetailedProduct(DetailedProductID)
);

CREATE TABLE DiscountUse
(
  DiscountID VARCHAR NOT NULL,
  BillID VARCHAR NOT NULL,
  UsedAt DATE NOT NULL,
  PRIMARY KEY (DiscountID, BillID),
  FOREIGN KEY (DiscountID) REFERENCES Discount(DiscountID),
  FOREIGN KEY (BillID) REFERENCES Bill(BillID)
);