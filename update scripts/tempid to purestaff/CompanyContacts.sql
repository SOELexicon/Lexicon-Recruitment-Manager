INSERT INTO CompanyContacts
                         (Title, Forename, Surname, Department, Telephone, Email, Fax, DateLastContact, ContactedBy, Address, Town, County, Country, PostalCode, CompanyID, Position, 
                         CostCentre, JobTitle, Category, Category2, Telephone2, Initials,  Notes)
SELECT        Title, Forename, Surname, Department, Telephone, Email, Fax, DateLastContact, ContactedBy, Address, Town, County, Country, PostalCode, CompanyID, Position, 
                         CostCentre, JobTitle, Category, Category2, Telephone2, Initials,
						 Notes
FROM            PureStaff.dbo.CompanyContacts AS CompanyContacts_1