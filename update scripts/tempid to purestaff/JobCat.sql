/****** Script for SelectTopNRows command from SSMS  ******/
SET IDENTITY_INSERT dbo.JobCategory off
GO
INSERT INTO JobCategory
                         ( JobCategory, ShiftName, PBasicPay, POT3, POT2, PSaturday, PSunday, PBankHol, CBasicPay, COT3, COT2, COT1, CSaturday, CSunday, CBankHol, 
                         PNightsOut, CNightsOut, TypicalStartTime, TypicalEndTime, BreakEntitlement, MinChargePerDay, RulesorDetails, P2BasicPay, P2OT3, P2OT2, P2OT1, P2Saturday, 
                         P2Sunday, P2BankHol, C2BasicPay, C2OT3, C2OT2, C2OT1, C2Saturday, C2BankHol, C2Sunday, P2NightsOut, C2NightsOut, SWH, CompanyID)
SELECT         PureStaff.dbo.EmployeeJobCategory.JobCategory, PureStaff.dbo.CompanyRates.Shift, 
                         PureStaff.dbo.CompanyRates.PayRate, PureStaff.dbo.CompanyRates.PayT3, PureStaff.dbo.CompanyRates.PayT2, PureStaff.dbo.CompanyRates.PaySat, 
                         PureStaff.dbo.CompanyRates.PaySun, PureStaff.dbo.CompanyRates.PayBank, PureStaff.dbo.CompanyRates.ChargeRate, PureStaff.dbo.CompanyRates.ChargeT3, 
                         PureStaff.dbo.CompanyRates.ChargeT2, PureStaff.dbo.CompanyRates.ChargeDouble, PureStaff.dbo.CompanyRates.ChargeSat, 
                         PureStaff.dbo.CompanyRates.ChargeSun, PureStaff.dbo.CompanyRates.ChargeBank, PureStaff.dbo.CompanyRates.PayNightOut, 
                         PureStaff.dbo.CompanyRates.ChargeNightOut, PureStaff.dbo.CompanyRates.Shift_Starttime, PureStaff.dbo.CompanyRates.Shift_Endtime, 
                         PureStaff.dbo.CompanyRates.BreakTime, PureStaff.dbo.CompanyRates.MinChargePerDay, PureStaff.dbo.CompanyRates.OTrulesAndDetails, 
                         PureStaff.dbo.CompanyRates.PayRate_Wk12, PureStaff.dbo.CompanyRates.PayT3_Wk12, PureStaff.dbo.CompanyRates.PayT2_Wk12, 
                         PureStaff.dbo.CompanyRates.PayDouble_Wk12, PureStaff.dbo.CompanyRates.PaySat_Wk12, PureStaff.dbo.CompanyRates.PaySun_Wk12, 
                         PureStaff.dbo.CompanyRates.PayBank_Wk12, PureStaff.dbo.CompanyRates.ChargeRate_Wk12, PureStaff.dbo.CompanyRates.ChargeT3_Wk12, 
                         PureStaff.dbo.CompanyRates.ChargeT2_Wk12, PureStaff.dbo.CompanyRates.ChargeDouble_Wk12, PureStaff.dbo.CompanyRates.ChargeSat_Wk12, 
                         PureStaff.dbo.CompanyRates.ChargeBank_Wk12, PureStaff.dbo.CompanyRates.ChargeSun_Wk12, PureStaff.dbo.CompanyRates.PayNightOut_Wk12, 
                         PureStaff.dbo.CompanyRates.ChargeNightOut_Wk12, PureStaff.dbo.CompanyRates.StandardWkHrs, PureStaff.dbo.CompanyRates.CompanyID
FROM            PureStaff.dbo.EmployeeJobCategory INNER JOIN
                         PureStaff.dbo.CompanyRates ON PureStaff.dbo.EmployeeJobCategory.JobCatID = PureStaff.dbo.CompanyRates.JobcatID