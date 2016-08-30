 SET ANSI_WARNINGS off
INSERT INTO Employees
                         ( Title, Forename, Surname, Address1, Telephone, Interviewer, Status, StatusReason, Town, County, PostCode, Mobile, MaritalStatus, Gender, 
                         DateRegistered, Notes, CreatedDate, LastModifiedDate,  CV, JobTitle, Shift, BranchID, Email, Bank, AccountNo, AccountInTheNameOf, EmployeeCode, 
                         SortCode, DOB, NINumber, PaymentFrequency, TaxCode, Address2,   EthnicOrigin,SchemeID,EmailPayslip,Communication,Taxdetails,TaxCategory)
SELECT         Title, Forename, Surname, isnull(Address,''), Telephone1, Consultant, NotSuitable, Archive, isnull(Town,''), County, isnull(PostalCode,''), isnull(Telephone2,''), MaritalStatus, Sex, 
                         isnull(RegisteredDate,''), isnull(Notes,''), CreatedDate, LastUpdateDate,  CV, Position, Shift, isnull(BranchID,1), Email, Bank, AccountNumber, AccountName, PayrollNumber, 
                         SortCode, isnull(birthdate,DOB), isnull(NInumber,''), PaymentFreq, EmployeeTaxCode, Address2,   Nationality,1,0,'',isnull(EmployeeTaxCode,''),isnull(NICategory,'')
FROM            PureStaff.dbo.Employees AS Employees_1 where  isnull(birthdate,DOB) is not null