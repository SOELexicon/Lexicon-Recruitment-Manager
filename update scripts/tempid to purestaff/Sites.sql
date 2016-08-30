set identity_insert sites on

go
DELETE FROM SITES
INSERT INTO Sites
                         (Telephone1, Email, Fax, Category, Address, Town, County, Country, PostalCode, Telephone2, Notes, BranchID, CompanyID, CompanyName, Department, Terms, 
                         CompanyRegNumber, Address2, TempsUsed, CompanySize, NoEmployees, AgenciesUsed, Memo, ClientsVatRegNo, SpecialInvoiceInstructions, [H&SHiVizVest], 
                         SmokingAreaAvailable, CanteenAvailable, [H&SSaftyBoots], DNI, Ltd, PLC, SoleTrader, OrderNumberReq, CreditLimit, BaseLocation, InvoicingMethod, ConvertedBy, 
                         InvoiceTo, InvAddress, InvTown, InvCounty, InvCountry, Archive)
SELECT         Sites_1.Telephone1, Sites_1.Email, Sites_1.Fax, Sites_1.Category, Sites_1.Address, Sites_1.Town, Sites_1.County, Sites_1.Country, Sites_1.PostalCode,
                          Sites_1.Telephone2, Sites_1.Notes, Companies.BranchID, Sites_1.CompanyID, Sites_1.Company, Sites_1.Department, Sites_1.Terms, Sites_1.CompanyRegNumber, 
                         Sites_1.Address2, Sites_1.TempsUsed, Sites_1.CompanySize, Sites_1.NoEmployees, Sites_1.AgenciesUsed, Sites_1.Memo, Sites_1.ClientsVatRegNo, 
                         Sites_1.SpecialInvoiceInstructions, case Sites_1.VisitVizVest when 'Yes' then 1 else 0 end, case Sites_1.VisitSmoking when 'Yes' then 1 else 0 end,case Sites_1.VisitCanteen when 'Yes' then 1 else 0 end,case Sites_1.VisitSafetyBoots when 'Yes' then 1 else 0 end, Sites_1.DNI, Sites_1.Ltd, 
                         Sites_1.PLC, Sites_1.SoleTrader, case Sites_1.OrderNumberReq when 'Yes' then 1 else 0 end, Sites_1.CreditLimit, Sites_1.BaseLocation, Sites_1.InvoicingMethod, Sites_1.ConvertedBy, 
                         PureStaff.dbo.Companies.InvoiceTo AS Expr1, PureStaff.dbo.Companies.InvAddress AS Expr3, PureStaff.dbo.Companies.InvTown AS Expr4, 
                         PureStaff.dbo.Companies.InvCounty AS Expr7, PureStaff.dbo.Companies.InvCountry AS Expr8, PureStaff.dbo.Companies.Archived
FROM            PureStaff.dbo.Sites AS Sites_1 INNER JOIN
                         PureStaff.dbo.Companies ON Sites_1.CompanyID = PureStaff.dbo.Companies.CompanyID