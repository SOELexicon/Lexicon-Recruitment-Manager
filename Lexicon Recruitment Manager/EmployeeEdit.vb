Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports DevExpress.XtraGrid.EditForm.Helpers.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class EmployeeEdit
    Public ident As Integer
    Public bigint As Int64
    Public NiNumberSelect As String
    Dim da3 As SqlDataAdapter
    Dim Dset3 As New DataTable
    Public Function GetSecurityInfo2(area As String, application As String)
        da3 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset3 IsNot Nothing Then
            Dset3.Clear()
        End If
        da3.Fill(Dset3)
        Return Dset3.Rows(0)(0).ToString()


    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim Validatoin As String
        Dim Validatoinchoice As String
        Try

            Validatoin = "The following fields are mandatory; "

            Validatoinchoice = "The following fields are Invalid; "

            If NiNumber.ReadOnly = False Then
                Dim dc As New DataClasses1DataContext
                If EmployeeID.Text = "" Then
                    Dim EmployeeLinqNICheck = (From Employees In dc.GetTable(Of LinqEmployee)() Where Employees.NINumber = NiNumber.Text Order By Employees.EmployeeID Descending).FirstOrDefault

                    If EmployeeLinqNICheck IsNot Nothing Then
                        If EmployeeLinqNICheck.EmployeeCode IsNot Nothing Then
                            Select Case EmployeeLinqNICheck.Status
                                Case "Archive"
                                    If EmployeeLinqNICheck.LastWorkedDate > DateAdd(DateInterval.Month, -6, Now()) Then
                                        MsgBox("Archived Employee Worked In Past 6 Months and NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                        Validatoin = Validatoin + "NiNumber ¦ "
                                        NiNumber.Focus()
                                    Else
                                        MsgBox("Archived Employee Not Worked In Past 6 Months:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    End If
                                Case "N/S"
                                    MsgBox("Employee Previously N/S:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                Case "Cloned"
                                    MsgBox("Employee Previously Cloned:" + EmployeeLinqNICheck.EmployeeCode.ToString)

                                Case "Blacklisted"
                                    MsgBox("Employee Previously BlackListed:" + EmployeeLinqNICheck.EmployeeCode.ToString)


                                Case "TOT"
                                    MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    Validatoin = Validatoin + "NiNumber ¦ "
                                    NiNumber.Focus()
                                Case Else
                                    MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    Validatoin = Validatoin + "NiNumber ¦ "
                                    NiNumber.Focus()
                            End Select



                        End If
                    End If
                Else
                    Dim EmployeeLinqNICheck = (From Employees In dc.GetTable(Of LinqEmployee)() Where Employees.NINumber = NiNumber.Text And Employees.EmployeeID <> EmployeeID.Text Order By Employees.EmployeeID Descending).FirstOrDefault

                    If EmployeeLinqNICheck IsNot Nothing Then
                        If EmployeeLinqNICheck.EmployeeCode IsNot Nothing Then
                            Select Case EmployeeLinqNICheck.Status
                                Case "Archive"
                                    If EmployeeLinqNICheck.LastWorkedDate > DateAdd(DateInterval.Month, -6, Now()) Then
                                        MsgBox("Archived Employee Worked In Past 6 Months and NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                        Validatoin = Validatoin + "NiNumber ¦ "
                                        NiNumber.Focus()
                                    Else
                                        MsgBox("Archived Employee Not Worked In Past 6 Months:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    End If
                                Case "N/S"
                                    MsgBox("Employee Previously N/S:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                Case "Cloned"
                                    MsgBox("Employee Previously Cloned:" + EmployeeLinqNICheck.EmployeeCode.ToString)

                                Case "Blacklisted"
                                    MsgBox("Employee Previously BlackListed:" + EmployeeLinqNICheck.EmployeeCode.ToString)


                                Case "TOT"
                                    MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    Validatoin = Validatoin + "NiNumber ¦ "
                                    NiNumber.Focus()
                                Case Else
                                    MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    Validatoin = Validatoin + "NiNumber ¦ "
                                    NiNumber.Focus()
                            End Select



                        End If
                    End If
                End If


            End If
            If Passport.Checked = True And PassportExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "Passport Expiry Date is Default ¦ "
            End If
            If Visa.Checked = True And VisaExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "Visa Expiry Date is Default ¦ "
            End If
            If DrivingLicense.Checked = True And DrivingExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "Driving Expiry Date is Default ¦ "
            End If
            If DrivingLicense.Checked = True And DrivingExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "Driving Expiry Date is Default ¦ "
            End If
            If DigiCard.Checked = True And DigiCardExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "DigiCard Expiry Date is Default ¦ "
            End If
            If CPCM1.Checked = True And DQCExpiryDate.EditValue = "1/1/1900" Then
                Validatoin = Validatoin + "Drivers Qualification Card Expiry Date is Default ¦ "
            End If
            If NiNumber.Text = "" Then
                Validatoin = Validatoin + "NiNumber is blank ¦ "
            End If
            If Scheme.Text = "" Then
                Validatoin = Validatoin + "SchemeID is blank ¦ "
            End If
            If Scheme.Tag Is Nothing Then
                Validatoinchoice = Validatoinchoice + "SchemeID is blank ¦ "
            End If
            If Branch.Tag Is Nothing Then
                Validatoinchoice = Validatoinchoice + "Branch is blank ¦ "
            End If
            If Branch.Text = "" Then
                Validatoin = Validatoin + "Branch is blank ¦ "
            End If
            If Title.Text = "" Then
                Validatoin = Validatoin + "Title is blank ¦ "
            End If
            If Forename.Text = "" Then
                Validatoin = Validatoin + "Forename is blank ¦ "
            End If
            If Surname.Text = "" Then
                Validatoin = Validatoin + "Surname is blank ¦ "
            End If
            If Address1.Text = "" Then
                Validatoin = Validatoin + "Address1 is blank ¦ "
            End If
            If City.Text = "" Then
                Validatoin = Validatoin + "Town/City is blank ¦ "
            End If
            If County.Text = "" Then
                Validatoin = Validatoin + "County is blank ¦ "
            End If
            If PostCode.Text = "" Then
                Validatoin = Validatoin + "PostCode is blank ¦ "
            Else
                PostCode.Text = PostCode.Text.ToUpper
            End If
            If Mobile.Text = "" Then
                Validatoin = Validatoin + "Mobile is blank ¦ "
            End If
            If Telephone.Text = "" Then
                Validatoin = Validatoin + "Telephone is blank ¦ "
            End If
            If EmergencyContact.Text = "" Then
                Validatoin = Validatoin + "Emergency Contact is blank ¦ "
            End If
            If EmergencyTelephone.Text = "" Then
                Validatoin = Validatoin + "Emergency Telephone is blank ¦ "
            End If
            If EthnicOrigin.Text = "" Then
                Validatoin = Validatoin + "Emergency Telephone is blank ¦ "
            End If
            If Sortcode.Text = "" Then
                Validatoin = Validatoin + "Sort code is blank ¦ "
            End If
            If AccountNo.Text = "" Then
                Validatoin = Validatoin + "Account No is blank ¦ "
            End If
            If AccountInTheNameOf.Text = "" Then
                Validatoin = Validatoin + "Account In The Name Of is blank ¦ "
            End If
            If Bank.Text = "" Then
                Validatoin = Validatoin + "Bank is blank ¦ "
            End If
            If TaxDetails.Text = "" Then
                Validatoin = Validatoin + "Tax Details is blank ¦ "
            End If
            If PaymentFrequency.Text = "" Then
                Validatoin = Validatoin + "Payment Frequency is blank ¦ "
            End If
            If TaxCategory.Text = "" Then
                Validatoin = Validatoin + "TaxCat is blank ¦ "
            End If
            If AgencyName.Text = "" Then
                Validatoin = Validatoin + "Agency Name (work History 1) is blank ¦ "
            End If
            If AgencyName2.Text = "" Then
                Validatoin = Validatoin + "Agency Name (work History 2) is blank ¦ "
            End If
            If AgencyName3.Text = "" Then
                Validatoin = Validatoin + "Agency Name (work History 3) is blank ¦ "
            End If
            If (boolToInt(Passport.Checked) + boolToInt(NatIdCard.Checked) + boolToInt(ProofOfNi.Checked) + boolToInt(BirthCert.Checked) + boolToInt(NiCard.Checked) + boolToInt(UtilityBill.Checked) + boolToInt(CV.Checked) + boolToInt(Visa.Checked) + boolToInt(CSCSCard.Checked) _
            + boolToInt(CPCSCard.Checked) + boolToInt(DrivingLicense.Checked) + boolToInt(DigiCard.Checked) + boolToInt(CPCM1.Checked) + boolToInt(CPCM2.Checked) + boolToInt(CPCM3.Checked) + boolToInt(CPCM4.Checked) + boolToInt(CPCM5.Checked)) <= 0 Then
                Validatoin = Validatoin + "No Proof Of ID ¦ "
            End If
            If ((boolToInt(Assembler.Checked) + boolToInt(Production.Checked) + boolToInt(Warehouse.Checked) + boolToInt(Groundwork.Checked) + boolToInt(TrafficMngt.Checked) + boolToInt(MigWelder.Checked) + boolToInt(GeneralOp.Checked) + boolToInt(MachineOp.Checked) + boolToInt(PressOp.Checked) _
        + boolToInt(OrderPicker.Checked) + boolToInt(Labourer.Checked) + boolToInt(Joiner.Checked) + boolToInt(TigWelder.Checked) + boolToInt(QInspector.Checked) + boolToInt(Setter.Checked) + boolToInt(Driving.Checked) + boolToInt(Packer.Checked) _
        + boolToInt(Cleaner.Checked) + boolToInt(Admin.Checked) + boolToInt(Braize.Checked) + boolToInt(FSA.Checked) + boolToInt(FLTRT.Checked) + boolToInt(FLTNA.Checked) + boolToInt(FLTBendi.Checked) + boolToInt(FLTCB.Checked)) + _
    (boolToInt(CE.Checked) + boolToInt(C.Checked) + boolToInt(Tonn75.Checked) + boolToInt(Van.Checked) + boolToInt(Hiab.Checked) + boolToInt(Moffat.Checked) + boolToInt(Tipper1.Checked) + boolToInt(Tipper2.Checked) + boolToInt(Tipper75T.Checked) _
      + boolToInt(RollOnOff.Checked) + boolToInt(MultiLift.Checked) + boolToInt(PVC.Checked) + boolToInt(MB.Checked) + boolToInt(AFrame.Checked) + boolToInt(CloseCoupled.Checked) + boolToInt(CurtainBox.Checked) + boolToInt(FlatFridge.Checked) _
       + boolToInt(Lowloader.Checked) + boolToInt(Container1.Checked) + boolToInt(DeMounts.Checked) + boolToInt(DoubleDeck.Checked) + boolToInt(WalkingFloor.Checked) + boolToInt(ChainnDog.Checked) + boolToInt(Strap.Checked) + boolToInt(Rope.Checked) _
        + boolToInt(Sheet.Checked) + boolToInt(SteelShunter.Checked) + boolToInt(HBall.Checked) + boolToInt(TLift.Checked) + boolToInt(FLT.Checked) + boolToInt(ADRTanks.Checked) + boolToInt(ADRPackages.Checked))) <= 0 Then
                Validatoin = Validatoin + "Industrial/Driving Not Filled in ¦ "
            End If
            If Interviewer.Text = "" Then
                Validatoin = Validatoin + "Interviewer is Blank ¦ "
            End If
            If Status.Text = "" Then
                Validatoin = Validatoin + "Status is Blank ¦ "
            End If
            If Notes.Text = "" Then
                Validatoin = Validatoin + "Notes is Blank ¦ "
            End If

            If Scheme.Text = "LTD" Then
                If IsNumeric(CoRegistrationNumber.Text) = False And CoRegistrationNumber.Text <> "" Then
                    Validatoin = Validatoin + "CoRegNumber is not a number ¦ "

                End If
                If CoRegistrationNumber.Text = "" Then
                    Validatoin = Validatoin + "CoRegNumber is Blank ¦ "

                End If
                If CorporationCertCopied.Checked = False Then
                    Validatoin = Validatoin + "CorporationCertCopied is Blank ¦ "

                End If

                If LtdCompanyName.Text = "" Then
                    Validatoin = Validatoin + "LtdCompanyName is Blank ¦ "

                End If
                If VatRegistered.Checked = True Then

                    If VatNumber.Text = "" Then
                        Validatoin = Validatoin + "VATNumber is blank ¦ "
                    End If
                    If IsNumeric(VatNumber.Text) = False And VatNumber.Text <> "" Then
                        Validatoin = Validatoin + "VATNumber is not a number ¦ "
                    End If
                End If
            End If
            If Validatoin <> "The following fields are mandatory; " And Validatoinchoice <> "The following fields are Invalid; " Then
                Throw New Exception(String.Format(Validatoin + Environment.NewLine + Validatoinchoice))
            End If
            If Validatoin <> "The following fields are mandatory; " And Validatoinchoice = "The following fields are Invalid; " Then
                Throw New Exception(Validatoin)
            End If
            If Validatoin = "The following fields are mandatory; " And Validatoinchoice <> "The following fields are Invalid; " Then
                Throw New Exception(Validatoinchoice)
            End If
            Select Case ident
                Case 0
                    EmployeeAdd()
                    NiNumberSelect = NiNumber.Text
                Case 1
                    EmployeeModify()
                    Me.EmployeesMoneyOwedTableAdapter.Update(Me.Sites.EmployeesMoneyOwed)
                    If Status.Text <> "TOT" Then

                        Select Case systemtypeTb.Text

                            Case "R"


                            Case Else
                                lblStatus.Text = "Status: Registered"
                                lblStatus.ForeColor = Color.Black
                                Dim updatestatusstr As String = "   Update Employees set   SystemType = " + "'R'" + " WHERE(EmployeeID = " + bigint.ToString + ")"
                                adSQLAdapter2 = New SqlDataAdapter(updatestatusstr, Main.con)
                                If Dset.Tables("UpdateEmployee") IsNot Nothing Then
                                    Dset.Tables("UpdateEmployee").Clear()
                                End If
                                adSQLAdapter2.Fill(Dset, "UpdateEmployee")


                        End Select


                    End If
            End Select
            Me.Tag = NiNumberSelect
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)

        End Try

    End Sub
    Private Function boolToInt(b As [Boolean]) As Integer
        Return b.CompareTo(False)
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Dim adSQLAdapter2 As SqlDataAdapter
    Dim Dset As New DataSet
    Public Sub EmployeeAdd()
        Try
            Dim dc As New DataClasses1DataContext

            If Pay.Text = "" Then
                Pay.Text = 0
            End If
            If Pay2.Text = "" Then
                Pay2.Text = 0

            End If
            If Pay3.Text = "" Then
                Pay3.Text = 0
            End If
            '        Dim datesdrivingchecked, DrivingExpiryDate2, VisaExpiryDate2, PassportExpiryDate2, DigiCardExpiryDate2, DQCExpiryDate2 As Date
            '        If DateDrivingLicenceLastChecked.EditValue = "" Then
            '            datesdrivingchecked = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DateDrivingLicenceLastChecked.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, datesdrivingchecked)
            '        End If
            '        If DrivingExpiryDate.Text = "" Then
            '            DrivingExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DrivingExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DrivingExpiryDate2)
            '        End If
            '        If VisaExpiryDate.Text = "" Then
            '            VisaExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(VisaExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, VisaExpiryDate2)
            '        End If
            '        If PassportExpiryDate.Text = "" Then
            '            PassportExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(PassportExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, PassportExpiryDate2)
            '        End If
            '        If DigiCardExpiryDate.Text = "" Then
            '            DigiCardExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DigiCardExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DigiCardExpiryDate2)
            '        End If
            '        If DQCExpiryDate.Text = "" Then
            '            DQCExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DQCExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DQCExpiryDate2)
            '        End If

            dc.LinqEmployeeAdd(0, NiNumber.Text, Scheme.Tag, Convert.ToInt32(Branch.Tag), EmployeeCode.Text, Title.Text, _
 Forename.Text, Surname.Text, MaritalStatus.Text, Gender.Text, Address1.Text, Address2.Text, City.Text _
 , County.Text, PostCode.Text, DOB.Value, Telephone.Text, Mobile.Text, EmergencyContact.Text, EmergencyTelephone.Text, _
 EthnicOrigin.Text, Sortcode.Text, AccountNo.Text, AccountInTheNameOf.Text, Bank.Text, Email.Checked, Tb_Email.Text, _
 PaymentFrequency.Text, WorkFrom.Value, WorkTo.Value, WorkedVia.Text, AgencyName.Text, CompanyName1.Text, Location1.Text, _
 JobTitle.Text, Shift.Text, Decimal.Parse(Pay.Text), ReasonForLeaving.Text, Manager.Text, RefAvailable.Checked, _
 ContactNumber.Text, ContactNumber2.Text, WorkFrom2.Value, WorkTo2.Value, WorkedVia2.Text, AgencyName2.Text, CompanyName2.Text, _
 Location2.Text, JobTitle2.Text, Shift2.Text, Decimal.Parse(Pay2.Text), ReasonForLeaving2.Text, Manager2.Text, RefAvailable1.Checked, _
 ContactNumber3.Text, WorkFrom3.Value, WorkTo3.Value, WorkedVia3.Text, AgencyName3.Text, CompanyName3.Text, Location3.Text, JobTitle3.Text, _
 Shift3.Text, Decimal.Parse(Pay3.Text), ReasonForLeaving3.Text, Manager3.Text, RefAvailable2.Checked, Passport.Checked, NatIdCard.Checked, _
 ProofOfNi.Checked, BirthCert.Checked, NiCard.Checked, UtilityBill.Checked, CV.Checked, Visa.Checked, CSCSCard.Checked, CPCSCard.Checked, _
 DrivingLicense.Checked, DigiCard.Checked, CPCM1.Checked, CPCM2.Checked, CPCM3.Checked, CPCM4.Checked, CPCM5.Checked, Assembler.Checked, _
 Production.Checked, Warehouse.Checked, Groundwork.Checked, TrafficMngt.Checked, MigWelder.Checked, GeneralOp.Checked, MachineOp.Checked, _
 PressOp.Checked, OrderPicker.Checked, Labourer.Checked, Joiner.Checked, TigWelder.Checked, QInspector.Checked, Setter.Checked, Driving.Checked, _
 Packer.Checked, Cleaner.Checked, Admin.Checked, Braize.Checked, FSA.Checked, FLTCB.Checked, FLTRT.Checked, FLTNA.Checked, FLTBendi.Checked, CE.Checked, _
 C.Checked, Tonn75.Checked, Van.Checked, Hiab.Checked, Moffat.Checked, Tipper1.Checked, Tipper2.Checked, Tipper75T.Checked, RollOnOff.Checked, _
 MultiLift.Checked, PVC.Checked, MB.Checked, AFrame.Checked, CloseCoupled.Checked, CurtainBox.Checked, FlatFridge.Checked, Lowloader.Checked, _
 Container1.Checked, DeMounts.Checked, DoubleDeck.Checked, WalkingFloor.Checked, ChainnDog.Checked, Strap.Checked, Rope.Checked, Sheet.Checked, _
 SteelShunter.Checked, HBall.Checked, TLift.Checked, FLT.Checked, ADRTanks.Checked, ADRPackages.Checked, LtdCompanyName.Text, CoRegistrationNumber.Text, _
 CorporationCertCopied.Checked, VatRegistered.Checked, VatNumber.Text, Communication.Text, Interviewer.Text, DateRegistered.Value, Status.Text, _
 StatusReason.Text, Notes.Text, TaxDetails.Text, TaxCategory.Text, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), _
 Now(), System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), Now(), StudentLoan.Checked, CBCardArchived.Checked, DriverLicenseCheckConsentFormCompleteCB.Checked, DateDrivingLicenceLastChecked.Text, SageRef.Text, PriorRefTE.Text, StatusChangeDateTb.Text, _
 BankReference.Text, DrivingExpiryDate.Text, VisaExpiryDate.Text, PassportExpiryDate.Text, DigiCardExpiryDate.Text, DQCExpiryDate.Text, LoyaltyCard.Checked, LoyaltyPoints.EditValue, LoyaltyRank.Text)



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'Main.con.Close()
        End Try
    End Sub
    Public Sub EmployeeModify()
        Try
            Dim dc As New DataClasses1DataContext
            If Pay.Text = "" Then
                Pay.Text = 0
            End If
            If Pay2.Text = "" Then
                Pay2.Text = 0

            End If
            If Pay3.Text = "" Then
                Pay3.Text = 0

            End If
            Dim datesdrivingchecked, DrivingExpiryDate2, VisaExpiryDate2, PassportExpiryDate2, DigiCardExpiryDate2, DQCExpiryDate2 As Date
            If DateDrivingLicenceLastChecked.Text = "" Then
                datesdrivingchecked = "1 january 1900"
            Else
                Date.TryParseExact(DateDrivingLicenceLastChecked.Text, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
    Globalization.DateTimeStyles.None, datesdrivingchecked)
            End If
            '        If DrivingExpiryDate.Text = "" Then
            '            DrivingExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DrivingExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DrivingExpiryDate2)
            '        End If
            '        If VisaExpiryDate.Text = "" Then
            '            VisaExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(VisaExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, VisaExpiryDate2)
            '        End If
            '        If PassportExpiryDate.Text = "" Then
            '            PassportExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(PassportExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, PassportExpiryDate2)
            '        End If
            '        If DigiCardExpiryDate.Text = "" Then
            '            DigiCardExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DigiCardExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DigiCardExpiryDate2)
            '        End If
            '        If DQCExpiryDate.Text = "" Then
            '            DQCExpiryDate2 = "1 january 1900"
            '        Else
            '            Date.TryParseExact(DQCExpiryDate.EditValue, "dd MMMM yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo,
            'Globalization.DateTimeStyles.None, DQCExpiryDate2)
            '        End If

            dc.LinqEmployeeAdd(bigint, NiNumber.Text, Scheme.Tag, Convert.ToInt32(Branch.Tag), EmployeeCode.Text, Title.Text, _
Forename.Text, Surname.Text, MaritalStatus.Text, Gender.Text, Address1.Text, Address2.Text, City.Text _
, County.Text, PostCode.Text, DOB.Value, Telephone.Text, Mobile.Text, EmergencyContact.Text, EmergencyTelephone.Text, _
EthnicOrigin.Text, Sortcode.Text, AccountNo.Text, AccountInTheNameOf.Text, Bank.Text, Email.Checked, Tb_Email.Text, _
PaymentFrequency.Text, WorkFrom.Value, WorkTo.Value, WorkedVia.Text, AgencyName.Text, CompanyName1.Text, Location1.Text, _
JobTitle.Text, Shift.Text, Decimal.Parse(Pay.Text), ReasonForLeaving.Text, Manager.Text, RefAvailable.Checked, _
ContactNumber.Text, ContactNumber2.Text, WorkFrom2.Value, WorkTo2.Value, WorkedVia2.Text, AgencyName2.Text, CompanyName2.Text, _
Location2.Text, JobTitle2.Text, Shift2.Text, Decimal.Parse(Pay2.Text), ReasonForLeaving2.Text, Manager2.Text, RefAvailable1.Checked, _
ContactNumber3.Text, WorkFrom3.Value, WorkTo3.Value, WorkedVia3.Text, AgencyName3.Text, CompanyName3.Text, Location3.Text, JobTitle3.Text, _
Shift3.Text, Decimal.Parse(Pay3.Text), ReasonForLeaving3.Text, Manager3.Text, RefAvailable2.Checked, Passport.Checked, NatIdCard.Checked, _
ProofOfNi.Checked, BirthCert.Checked, NiCard.Checked, UtilityBill.Checked, CV.Checked, Visa.Checked, CSCSCard.Checked, CPCSCard.Checked, _
DrivingLicense.Checked, DigiCard.Checked, CPCM1.Checked, CPCM2.Checked, CPCM3.Checked, CPCM4.Checked, CPCM5.Checked, Assembler.Checked, _
Production.Checked, Warehouse.Checked, Groundwork.Checked, TrafficMngt.Checked, MigWelder.Checked, GeneralOp.Checked, MachineOp.Checked, _
PressOp.Checked, OrderPicker.Checked, Labourer.Checked, Joiner.Checked, TigWelder.Checked, QInspector.Checked, Setter.Checked, Driving.Checked, _
Packer.Checked, Cleaner.Checked, Admin.Checked, Braize.Checked, FSA.Checked, FLTCB.Checked, FLTRT.Checked, FLTNA.Checked, FLTBendi.Checked, CE.Checked, _
C.Checked, Tonn75.Checked, Van.Checked, Hiab.Checked, Moffat.Checked, Tipper1.Checked, Tipper2.Checked, Tipper75T.Checked, RollOnOff.Checked, _
MultiLift.Checked, PVC.Checked, MB.Checked, AFrame.Checked, CloseCoupled.Checked, CurtainBox.Checked, FlatFridge.Checked, Lowloader.Checked, _
Container1.Checked, DeMounts.Checked, DoubleDeck.Checked, WalkingFloor.Checked, ChainnDog.Checked, Strap.Checked, Rope.Checked, Sheet.Checked, _
SteelShunter.Checked, HBall.Checked, TLift.Checked, FLT.Checked, ADRTanks.Checked, ADRPackages.Checked, LtdCompanyName.Text, CoRegistrationNumber.Text, _
CorporationCertCopied.Checked, VatRegistered.Checked, VatNumber.Text, Communication.Text, Interviewer.Text, DateRegistered.Value, Status.Text, _
StatusReason.Text, Notes.Text, TaxDetails.Text, TaxCategory.Text, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), _
Now(), System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString(), Now(), StudentLoan.Checked, CBCardArchived.Checked, DriverLicenseCheckConsentFormCompleteCB.Checked, DateDrivingLicenceLastChecked.Text, SageRef.Text, PriorRefTE.Text, StatusChangeDateTb.Text, _
BankReference.Text, DrivingExpiryDate.Text, VisaExpiryDate.Text, PassportExpiryDate.Text, DigiCardExpiryDate.Text, DQCExpiryDate.Text,
 _LoyaltyCard.Checked, LoyaltyPoints.EditValue.ToString, LoyaltyRank.Text)



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'Main.con.Close()
        End Try
    End Sub

    'below fetches the data for relevant controls
    Public Sub FetchData()

        Dim dc As New DataClasses1DataContext
        Dim LinqBranchPick = (From branches In dc.GetTable(Of LinqCV_BranchDropdown)()).ToList

        For i = 0 To LinqBranchPick.Count - 1
            Branch.Items.Add(LinqBranchPick.Item(i).Expr1)
        Next


        Dim LinqSchemePick = (From Schemes In dc.GetTable(Of LinqCV_SchemeDropdown)()).ToList


        For i = 0 To LinqSchemePick.Count - 1
            Scheme.Items.Add(LinqSchemePick.Item(i).Expr1)
        Next
        Try
            Select Case ident

                Case 0
                    StatusChangeDateTb.Text = "1/1/1900"
                    DrivingExpiryDate.DateTime = "1/1/1900"
                    DigiCardExpiryDate.DateTime = "1/1/1900"
                    PassportExpiryDate.DateTime = "1/1/1900"
                    VisaExpiryDate.DateTime = "1/1/1900"
                    DQCExpiryDate.DateTime = "1/1/1900"
                    DateDrivingLicenceLastChecked.DateTime = "1/1/1900"
                    If Passport.Checked = True Then
                        PassportExpiryDate.Enabled = True
                    Else
                        PassportExpiryDate.Enabled = False
                    End If

                    If Visa.Checked = True Then
                        VisaExpiryDate.Enabled = True
                    Else
                        VisaExpiryDate.Enabled = False
                    End If

                    If DrivingLicense.Checked = True Then
                        DrivingExpiryDate.Enabled = True
                    Else
                        DrivingExpiryDate.Enabled = False
                    End If
                    If DigiCard.Checked = True Then
                        DigiCardExpiryDate.Enabled = True
                    Else
                        DigiCardExpiryDate.Enabled = False
                    End If
                    If CPCM1.Checked = True Then
                        DQCExpiryDate.Enabled = True
                    Else
                        DQCExpiryDate.Enabled = False
                    End If
                Case 1


                    Dim EmployeeModifyLinq = (From Employees In dc.GetTable(Of LinqEmployeeModify)() Where Employees.EmployeeID = bigint.ToString).SingleOrDefault
                    Me.EmployeesMoneyOwedTableAdapter.Fill(Me.Sites.EmployeesMoneyOwed, CType(bigint.ToString, Long))
                    Try
                        Dim EmployeeLinqNICheck2 = (From Employees In dc.GetTable(Of LinqEmployee)() Where Employees.EmployeeID = bigint.ToString Order By Employees.EmployeeID Descending).FirstOrDefault
                        LastWorkedDateTb.Text = EmployeeLinqNICheck2.LastWorkedDate
                    Catch ex As Exception
                        LastWorkedDateTb.Text = "No Date"
                    End Try
                    EmployeeID.Text = EmployeeModifyLinq.EmployeeID.ToString

                    NiNumber.Text = EmployeeModifyLinq.NINumber.ToString
                    Scheme.Tag = EmployeeModifyLinq.SchemeID
                    Scheme.Text = EmployeeModifyLinq.Scheme.ToString
                    Branch.Tag = EmployeeModifyLinq.BranchID
                    Branch.Text = EmployeeModifyLinq.Branch.ToString

                    EmployeeCode.Text = EmployeeModifyLinq.EmployeeCode.ToString
                    Title.Text = EmployeeModifyLinq.Title.ToString
                    Forename.Text = EmployeeModifyLinq.Forename.ToString
                    Surname.Text = EmployeeModifyLinq.Surname.ToString
                    Address1.Text = EmployeeModifyLinq.Address1.ToString
                    Address2.Text = EmployeeModifyLinq.Address2.ToString
                    City.Text = EmployeeModifyLinq.Town.ToString
                    County.Text = EmployeeModifyLinq.County.ToString
                    PostCode.Text = EmployeeModifyLinq.PostCode.ToString
                    DOB.Value = EmployeeModifyLinq.DOB
                    Telephone.Text = EmployeeModifyLinq.Telephone.ToString
                    Mobile.Text = EmployeeModifyLinq.Mobile.ToString
                    EmergencyContact.Text = EmployeeModifyLinq.EmergencyContact.ToString
                    EmergencyTelephone.Text = EmployeeModifyLinq.EmergencyContactTel
                    EthnicOrigin.Text = EmployeeModifyLinq.EthnicOrigin.ToString
                    Sortcode.Text = EmployeeModifyLinq.SortCode.ToString
                    AccountNo.Text = EmployeeModifyLinq.AccountNo.ToString
                    AccountInTheNameOf.Text = EmployeeModifyLinq.AccountInTheNameOf.ToString
                    Bank.Text = EmployeeModifyLinq.Bank.ToString
                    Email.Checked = EmployeeModifyLinq.EmailPayslip
                    Tb_Email.Text = EmployeeModifyLinq.Email.ToString

                    If EmployeeModifyLinq.WorkFrom Is Nothing Then
                        WorkFrom.Value = "1/1/1900"
                    Else
                        WorkFrom.Value = EmployeeModifyLinq.WorkFrom
                    End If

                    If EmployeeModifyLinq.WorkTo Is Nothing Then
                        WorkTo.Value = "1/1/1900"
                    Else
                        WorkTo.Value = EmployeeModifyLinq.WorkTo
                    End If

                    WorkedVia.Text = EmployeeModifyLinq.WorkedVia
                    AgencyName.Text = EmployeeModifyLinq.AgencyName
                    CompanyName1.Text = EmployeeModifyLinq.CompanyName
                    Location1.Text = EmployeeModifyLinq.Location
                    JobTitle.Text = EmployeeModifyLinq.JobTitle
                    Shift.Text = EmployeeModifyLinq.Shift
                    Pay.Text = EmployeeModifyLinq.Pay.ToString
                    ReasonForLeaving.Text = EmployeeModifyLinq.ReasonForLeaving
                    Manager.Text = EmployeeModifyLinq.Manager

                    If EmployeeModifyLinq.RefAvailable Is Nothing Then
                        RefAvailable.Checked = False
                    Else
                        RefAvailable.Checked = EmployeeModifyLinq.RefAvailable
                    End If

                    ContactNumber.Text = EmployeeModifyLinq.ContactNumber
                    ContactNumber2.Text = EmployeeModifyLinq.ContactNumber1

                    If EmployeeModifyLinq.WorkFrom1 IsNot Nothing Then
                        WorkFrom2.Value = EmployeeModifyLinq.WorkFrom1
                    End If

                    If EmployeeModifyLinq.WorkTo1 IsNot Nothing Then
                        WorkTo2.Value = EmployeeModifyLinq.WorkTo1
                    End If

                    If Passport.Checked = True Then
                        PassportExpiryDate.Enabled = True
                    Else
                        PassportExpiryDate.Enabled = False
                    End If

                    If Visa.Checked = True Then
                        VisaExpiryDate.Enabled = True
                    Else
                        VisaExpiryDate.Enabled = False
                    End If
                    If DigiCard.Checked = True Then
                        DigiCardExpiryDate.Enabled = True
                    Else
                        DigiCardExpiryDate.Enabled = False
                    End If
                    If CPCM1.Checked = True Then
                        DQCExpiryDate.Enabled = True
                    Else
                        DQCExpiryDate.Enabled = False
                    End If
                    If DrivingLicense.Checked = True Then
                        DrivingExpiryDate.Enabled = True
                    Else
                        DrivingExpiryDate.Enabled = False
                    End If

                    If EmployeeModifyLinq.VisaExpiryDate Is Nothing Then
                        VisaExpiryDate.EditValue = "1/1/1900"
                        VisaExpiryDate.DateTime = "1/1/1900"
                    Else
                        VisaExpiryDate.EditValue = CType(EmployeeModifyLinq.VisaExpiryDate, Date).ToShortDateString
                        VisaExpiryDate.DateTime = CType(EmployeeModifyLinq.VisaExpiryDate, Date).ToShortDateString
                    End If

                    If EmployeeModifyLinq.DrivingLicenceExpiryDate Is Nothing Then
                        DrivingExpiryDate.EditValue = "1/1/1900"
                        DrivingExpiryDate.DateTime = "1/1/1900"
                    Else
                        DrivingExpiryDate.EditValue = CType(EmployeeModifyLinq.DrivingLicenceExpiryDate, Date).ToShortDateString
                        DrivingExpiryDate.DateTime = CType(EmployeeModifyLinq.DrivingLicenceExpiryDate, Date).ToShortDateString
                    End If

                    If EmployeeModifyLinq.PassportExpiryDate Is Nothing Then
                        PassportExpiryDate.EditValue = "1/1/1900"
                        PassportExpiryDate.DateTime = "1/1/1900"
                    Else
                        PassportExpiryDate.EditValue = CType(EmployeeModifyLinq.PassportExpiryDate, Date).ToShortDateString
                        PassportExpiryDate.DateTime = CType(EmployeeModifyLinq.PassportExpiryDate, Date).ToShortDateString
                    End If
                    If EmployeeModifyLinq.DigicardExpiryDate Is Nothing Then
                        DigiCardExpiryDate.EditValue = "1/1/1900"
                        DigiCardExpiryDate.DateTime = "1/1/1900"
                    Else
                        DigiCardExpiryDate.EditValue = CType(EmployeeModifyLinq.DigicardExpiryDate, Date).ToShortDateString

                        DigiCardExpiryDate.DateTime = CType(EmployeeModifyLinq.DigicardExpiryDate, Date).ToShortDateString
                    End If

                    If EmployeeModifyLinq.DriversQualificationCardExpiryDate Is Nothing Then
                        DQCExpiryDate.EditValue = "1/1/1900"
                        DQCExpiryDate.DateTime = "1/1/1900"
                    Else
                        DQCExpiryDate.EditValue = CType(EmployeeModifyLinq.DriversQualificationCardExpiryDate, Date).ToShortDateString
                        DQCExpiryDate.DateTime = CType(EmployeeModifyLinq.DriversQualificationCardExpiryDate, Date).ToShortDateString
                    End If


                    BankReference.Text = EmployeeModifyLinq.BankReference
                    WorkedVia2.Text = EmployeeModifyLinq.WorkedVia1
                    AgencyName2.Text = EmployeeModifyLinq.AgencyName1
                    CompanyName2.Text = EmployeeModifyLinq.CompanyName1
                    Location2.Text = EmployeeModifyLinq.Location1
                    JobTitle2.Text = EmployeeModifyLinq.JobTitle1
                    Shift2.Text = EmployeeModifyLinq.Shift1
                    Pay2.Text = EmployeeModifyLinq.Pay1.ToString
                    ReasonForLeaving2.Text = EmployeeModifyLinq.ReasonForLeaving1
                    Manager2.Text = EmployeeModifyLinq.Manager1
                    If EmployeeModifyLinq.RefAvailable1 Is Nothing Then



                        RefAvailable1.Checked = False
                    Else
                        RefAvailable1.Checked = EmployeeModifyLinq.RefAvailable1
                    End If

                    ContactNumber3.Text = EmployeeModifyLinq.ContactNumber2
                    If EmployeeModifyLinq.WorkFrom2 IsNot Nothing Then
                        WorkFrom3.Value = EmployeeModifyLinq.WorkFrom2
                    End If
                    If EmployeeModifyLinq.WorkTo2 IsNot Nothing Then
                        WorkTo3.Value = EmployeeModifyLinq.WorkTo2
                    End If

                    WorkedVia3.Text = EmployeeModifyLinq.WorkedVia2
                    AgencyName3.Text = EmployeeModifyLinq.AgencyName2
                    CompanyName3.Text = EmployeeModifyLinq.CompanyName2
                    Location3.Text = EmployeeModifyLinq.Location2
                    JobTitle3.Text = EmployeeModifyLinq.JobTitle2
                    Shift3.Text = EmployeeModifyLinq.Shift2
                    Pay3.Text = EmployeeModifyLinq.Pay2.ToString
                    ReasonForLeaving3.Text = EmployeeModifyLinq.ReasonForLeaving2
                    Manager3.Text = EmployeeModifyLinq.Manager2
                    If EmployeeModifyLinq.RefAvailable2 Is Nothing Then

                        RefAvailable2.Checked = False
                    Else
                        RefAvailable2.Checked = EmployeeModifyLinq.RefAvailable2

                    End If

                    If EmployeeModifyLinq.Passport Is Nothing Then

                        Passport.Checked = False
                    Else
                        Passport.Checked = EmployeeModifyLinq.Passport

                    End If

                    If EmployeeModifyLinq.NatIDCard Is Nothing Then

                        NatIdCard.Checked = False
                    Else
                        NatIdCard.Checked = EmployeeModifyLinq.NatIDCard
                    End If

                    If EmployeeModifyLinq.ProofOfNi Is Nothing Then

                        ProofOfNi.Checked = False
                    Else
                        ProofOfNi.Checked = EmployeeModifyLinq.ProofOfNi
                    End If

                    If EmployeeModifyLinq.BirthCert Is Nothing Then



                        BirthCert.Checked = False
                    Else
                        BirthCert.Checked = EmployeeModifyLinq.BirthCert
                    End If


                    If EmployeeModifyLinq.NiCard Is Nothing Then

                        NiCard.Checked = False
                    Else
                        NiCard.Checked = EmployeeModifyLinq.NiCard
                    End If

                    If EmployeeModifyLinq.UtilityBill Is Nothing Then

                        UtilityBill.Checked = False
                    Else
                        UtilityBill.Checked = EmployeeModifyLinq.UtilityBill
                    End If
                    If EmployeeModifyLinq.CV Is Nothing Then
                        CV.Checked = False
                    Else
                        CV.Checked = EmployeeModifyLinq.CV
                    End If
                    If EmployeeModifyLinq.Visa Is Nothing Then

                        Visa.Checked = False
                    Else
                        Visa.Checked = EmployeeModifyLinq.Visa
                    End If

                    If EmployeeModifyLinq.CSCSCard Is Nothing Then

                        CSCSCard.Checked = False
                    Else
                        CSCSCard.Checked = EmployeeModifyLinq.CSCSCard
                    End If


                    If EmployeeModifyLinq.CPCSCard Is Nothing Then

                        CPCSCard.Checked = False
                    Else
                        CPCSCard.Checked = EmployeeModifyLinq.CPCSCard
                    End If


                    If EmployeeModifyLinq.DrivingLic Is Nothing Then
                        DrivingLicense.Checked = False
                    Else
                        DrivingLicense.Checked = EmployeeModifyLinq.DrivingLic


                    End If
                    If EmployeeModifyLinq.DigiCard Is Nothing Then

                        DigiCard.Checked = False
                    Else

                        DigiCard.Checked = EmployeeModifyLinq.DigiCard

                    End If
                    If EmployeeModifyLinq.CPCM1 Is Nothing Then

                        CPCM1.Checked = False
                    Else
                        CPCM1.Checked = EmployeeModifyLinq.CPCM1
                    End If
                    If EmployeeModifyLinq.CPCM2 Is Nothing Then

                        CPCM2.Checked = False
                    Else

                        CPCM2.Checked = EmployeeModifyLinq.CPCM2
                    End If

                    If EmployeeModifyLinq.CPCM3 Is Nothing Then

                        CPCM3.Checked = False
                    Else
                        CPCM3.Checked = EmployeeModifyLinq.CPCM3

                    End If

                    If EmployeeModifyLinq.CPCM4 Is Nothing Then
                        CPCM4.Checked = False
                    Else

                        CPCM4.Checked = EmployeeModifyLinq.CPCM4
                    End If
                    If EmployeeModifyLinq.CPCM5 Is Nothing Then
                        CPCM5.Checked = False
                    Else

                        CPCM5.Checked = EmployeeModifyLinq.CPCM5
                    End If

                    If EmployeeModifyLinq.Assembler Is Nothing Then
                        Assembler.Checked = False
                    Else
                        Assembler.Checked = EmployeeModifyLinq.Assembler
                    End If
                    If EmployeeModifyLinq.Production IsNot Nothing Then
                        Production.Checked = EmployeeModifyLinq.Production
                    End If
                    If EmployeeModifyLinq.Warehouse IsNot Nothing Then
                        Warehouse.Checked = EmployeeModifyLinq.Warehouse
                    End If
                    If EmployeeModifyLinq.Groundwork IsNot Nothing Then

                        Groundwork.Checked = EmployeeModifyLinq.Groundwork
                    End If
                    If EmployeeModifyLinq.TrafficMngt IsNot Nothing Then

                        TrafficMngt.Checked = EmployeeModifyLinq.TrafficMngt
                    End If
                    If EmployeeModifyLinq.MigWelder IsNot Nothing Then

                        MigWelder.Checked = EmployeeModifyLinq.MigWelder
                    End If
                    If EmployeeModifyLinq.MachineOp IsNot Nothing Then

                        MachineOp.Checked = EmployeeModifyLinq.MachineOp
                    End If
                    If EmployeeModifyLinq.GeneralOp IsNot Nothing Then

                        GeneralOp.Checked = EmployeeModifyLinq.GeneralOp
                    End If
                    If EmployeeModifyLinq.PressOp IsNot Nothing Then

                        PressOp.Checked = EmployeeModifyLinq.PressOp
                    End If
                    If EmployeeModifyLinq.OrderPicker IsNot Nothing Then

                        OrderPicker.Checked = EmployeeModifyLinq.OrderPicker
                    End If

                    If EmployeeModifyLinq.Labourer IsNot Nothing Then

                        Labourer.Checked = EmployeeModifyLinq.Labourer
                    End If
                    If EmployeeModifyLinq.Joiner IsNot Nothing Then

                        Joiner.Checked = EmployeeModifyLinq.Joiner
                    End If
                    If EmployeeModifyLinq.TigWelder IsNot Nothing Then

                        TigWelder.Checked = EmployeeModifyLinq.TigWelder
                    End If
                    If EmployeeModifyLinq.QInspector IsNot Nothing Then

                        QInspector.Checked = EmployeeModifyLinq.QInspector
                    End If
                    If EmployeeModifyLinq.QInspector IsNot Nothing Then

                        Setter.Checked = EmployeeModifyLinq.Setter
                    End If
                    If EmployeeModifyLinq.Driving IsNot Nothing Then

                        Driving.Checked = EmployeeModifyLinq.Driving
                    End If
                    If EmployeeModifyLinq.Packer IsNot Nothing Then

                        Packer.Checked = EmployeeModifyLinq.Packer
                    End If
                    If EmployeeModifyLinq.Cleaner IsNot Nothing Then
                        Cleaner.Checked = EmployeeModifyLinq.Cleaner
                    End If
                    If EmployeeModifyLinq.Admin IsNot Nothing Then
                        Admin.Checked = EmployeeModifyLinq.Admin
                    End If

                    If EmployeeModifyLinq.Braize IsNot Nothing Then
                        Braize.Checked = EmployeeModifyLinq.Braize
                    End If
                    If EmployeeModifyLinq.FSA IsNot Nothing Then

                        FSA.Checked = EmployeeModifyLinq.FSA
                    End If
                    If EmployeeModifyLinq.FLT IsNot Nothing Then

                        FLT.Checked = EmployeeModifyLinq.FLT
                    End If
                    If EmployeeModifyLinq.FLTRT IsNot Nothing Then

                        FLTRT.Checked = EmployeeModifyLinq.FLTRT
                    End If
                    If EmployeeModifyLinq.FLTNA IsNot Nothing Then

                        FLTNA.Checked = EmployeeModifyLinq.FLTNA
                    End If
                    If EmployeeModifyLinq.FLTBendi IsNot Nothing Then

                        FLTBendi.Checked = EmployeeModifyLinq.FLTBendi
                    End If
                    If EmployeeModifyLinq.CE IsNot Nothing Then

                        CE.Checked = EmployeeModifyLinq.CE
                    End If
                    If EmployeeModifyLinq.C IsNot Nothing Then

                        C.Checked = EmployeeModifyLinq.C
                    End If
                    If EmployeeModifyLinq._7_5Tonn IsNot Nothing Then

                        Tonn75.Checked = EmployeeModifyLinq._7_5Tonn
                    End If
                    If EmployeeModifyLinq.Van IsNot Nothing Then

                        Van.Checked = EmployeeModifyLinq.Van
                    End If
                    If EmployeeModifyLinq.Hiab IsNot Nothing Then

                        Hiab.Checked = EmployeeModifyLinq.Hiab
                    End If
                    If EmployeeModifyLinq.Moffat IsNot Nothing Then

                        Moffat.Checked = EmployeeModifyLinq.Moffat
                    End If
                    If EmployeeModifyLinq.Tipper1 IsNot Nothing Then

                        Tipper1.Checked = EmployeeModifyLinq.Tipper1
                    End If
                    If EmployeeModifyLinq.Tipper2 IsNot Nothing Then

                        Tipper2.Checked = EmployeeModifyLinq.Tipper2
                    End If
                    If EmployeeModifyLinq.Tipper75T IsNot Nothing Then

                        Tipper75T.Checked = EmployeeModifyLinq.Tipper75T

                    End If
                    If EmployeeModifyLinq.RollOnOff IsNot Nothing Then

                        RollOnOff.Checked = EmployeeModifyLinq.RollOnOff
                    End If
                    If EmployeeModifyLinq.MultiLift IsNot Nothing Then

                        MultiLift.Checked = EmployeeModifyLinq.MultiLift
                    End If
                    If EmployeeModifyLinq.PVC IsNot Nothing Then

                        PVC.Checked = EmployeeModifyLinq.PVC
                    End If
                    If EmployeeModifyLinq.MB IsNot Nothing Then

                        MB.Checked = EmployeeModifyLinq.MB
                    End If
                    If EmployeeModifyLinq.AFrame IsNot Nothing Then

                        AFrame.Checked = EmployeeModifyLinq.AFrame
                    End If
                    If EmployeeModifyLinq.CloseCoupled IsNot Nothing Then

                        CloseCoupled.Checked = EmployeeModifyLinq.CloseCoupled
                    End If
                    If EmployeeModifyLinq.CurtainBox IsNot Nothing Then

                        CurtainBox.Checked = EmployeeModifyLinq.CurtainBox
                    End If
                    If EmployeeModifyLinq.FlatFridge IsNot Nothing Then

                        FlatFridge.Checked = EmployeeModifyLinq.FlatFridge
                    End If
                    If EmployeeModifyLinq.Lowloader IsNot Nothing Then

                        Lowloader.Checked = EmployeeModifyLinq.Lowloader
                    End If
                    If EmployeeModifyLinq.Container IsNot Nothing Then

                        Container1.Checked = EmployeeModifyLinq.Container
                    End If
                    If EmployeeModifyLinq.DeMounts IsNot Nothing Then

                        DeMounts.Checked = EmployeeModifyLinq.DeMounts
                    End If
                    If EmployeeModifyLinq.DoubleDeck IsNot Nothing Then

                        DoubleDeck.Checked = EmployeeModifyLinq.DoubleDeck
                    End If
                    If EmployeeModifyLinq.WalkingFloor IsNot Nothing Then

                        WalkingFloor.Checked = EmployeeModifyLinq.WalkingFloor
                    End If
                    If EmployeeModifyLinq.ChainnDog IsNot Nothing Then

                        ChainnDog.Checked = EmployeeModifyLinq.ChainnDog
                    End If
                    If EmployeeModifyLinq.Strap IsNot Nothing Then
                        Strap.Checked = EmployeeModifyLinq.Strap
                    End If
                    If EmployeeModifyLinq.Rope IsNot Nothing Then

                        Rope.Checked = EmployeeModifyLinq.Rope
                    End If
                    If EmployeeModifyLinq.Sheet IsNot Nothing Then

                        Sheet.Checked = EmployeeModifyLinq.Sheet
                    End If
                    If EmployeeModifyLinq.SteelShunter IsNot Nothing Then

                        SteelShunter.Checked = EmployeeModifyLinq.SteelShunter
                    End If
                    If EmployeeModifyLinq.HBall IsNot Nothing Then

                        HBall.Checked = EmployeeModifyLinq.HBall
                    End If
                    If EmployeeModifyLinq.TLift IsNot Nothing Then

                        TLift.Checked = EmployeeModifyLinq.TLift
                    End If
                    If EmployeeModifyLinq.FLT IsNot Nothing Then

                        FLT.Checked = EmployeeModifyLinq.FLT
                    End If
                    If EmployeeModifyLinq.ADRTanks IsNot Nothing Then

                        ADRTanks.Checked = EmployeeModifyLinq.ADRTanks
                    End If
                    If EmployeeModifyLinq.ADRPackages IsNot Nothing Then

                        ADRPackages.Checked = EmployeeModifyLinq.ADRPackages
                    End If

                    If EmployeeModifyLinq.LtdCompanyname IsNot Nothing Then

                        LtdCompanyName.Text = EmployeeModifyLinq.LtdCompanyname
                    End If
                    If EmployeeModifyLinq.CoRegistrationNumber IsNot Nothing Then

                        CoRegistrationNumber.Text = EmployeeModifyLinq.CoRegistrationNumber
                    End If
                    If EmployeeModifyLinq.CorporationCertCopied IsNot Nothing Then

                        CorporationCertCopied.Checked = EmployeeModifyLinq.CorporationCertCopied
                    End If
                    If EmployeeModifyLinq.VatRegistered IsNot Nothing Then

                        VatRegistered.Checked = EmployeeModifyLinq.VatRegistered
                    End If

                    VatNumber.Text = EmployeeModifyLinq.VatNumber
                    Communication.Text = EmployeeModifyLinq.Communication
                    Interviewer.Text = EmployeeModifyLinq.Interviewer
                    DateRegistered.Value = EmployeeModifyLinq.DateRegistered
                    Status.Text = EmployeeModifyLinq.Status
                    Select Case EmployeeModifyLinq.Status
                        Case "Blacklisted"
                            Status.Enabled = False
                        Case "Cloned"
                            Status.Enabled = False
                        Case "N/S"
                            Status.Enabled = False
                        Case Else
                            Status.Enabled = True
                    End Select
                    StatusReason.Text = EmployeeModifyLinq.StatusReason
                    Notes.Text = EmployeeModifyLinq.Notes
                    TaxDetails.Text = EmployeeModifyLinq.Taxdetails
                    TaxCategory.Text = EmployeeModifyLinq.TaxCategory


                    MaritalStatus.Text = EmployeeModifyLinq.MaritalStatus
                    Gender.Text = EmployeeModifyLinq.Gender
                    If EmployeeModifyLinq.StudentLoan IsNot Nothing Then

                        StudentLoan.Checked = EmployeeModifyLinq.StudentLoan
                    End If
                    TaxCategory.Text = EmployeeModifyLinq.TaxCategory
                    PaymentFrequency.Text = EmployeeModifyLinq.PaymentFrequency
                    systemtypeTb.Text = EmployeeModifyLinq.SystemType
                    PriorRefTE.Text = EmployeeModifyLinq.PreviousReference
                    SageRef.Text = EmployeeModifyLinq.SageRef
                    If EmployeeModifyLinq.StatusChangeDate IsNot Nothing Then
                        StatusChangeDateTb.Text = EmployeeModifyLinq.StatusChangeDate
                    Else
                        StatusChangeDateTb.Text = "1/1/1900"
                    End If

                    If EmployeeModifyLinq.DriverLicenseCheckConsentFormComplete IsNot Nothing Then
                        DriverLicenseCheckConsentFormCompleteCB.Checked = EmployeeModifyLinq.DriverLicenseCheckConsentFormComplete
                    Else
                        DriverLicenseCheckConsentFormCompleteCB.Checked = False
                    End If
                    If EmployeeModifyLinq.DateDrivingLicenceChecked IsNot Nothing Then
                        DateDrivingLicenceLastChecked.DateTime = EmployeeModifyLinq.DateDrivingLicenceChecked
                    Else
                        DateDrivingLicenceLastChecked.DateTime = "1/1/1900"
                    End If
                    If DriverLicenseCheckConsentFormCompleteCB.Checked = False Then
                        DateDrivingLicenceLastChecked.Enabled = False
                    Else
                        DateDrivingLicenceLastChecked.Enabled = True

                    End If
                    Select Case EmployeeModifyLinq.SystemType
                        Case "R"
                            lblStatus.Text = "Status: Registered"
                            lblStatus.ForeColor = Color.Red
                        Case "P"
                            lblStatus.Text = "Status: Processed/Checked"
                            lblStatus.ForeColor = Color.Orange
                        Case "C"
                            lblStatus.Text = "Status: Completed"
                            lblStatus.ForeColor = Color.Green
                    End Select
                    If EmployeeModifyLinq.CardArchived IsNot Nothing Then

                        CBCardArchived.Checked = EmployeeModifyLinq.CardArchived
                    End If
                    If Scheme.Tag = 5 Then
                        If TabControl1.TabPages.Contains(TPLTDCompanyContratorDetails) Then

                        Else
                            Me.TabControl1.TabPages.Add(TPLTDCompanyContratorDetails)
                        End If

                    Else
                        If TabControl1.TabPages.Contains(TPLTDCompanyContratorDetails) Then
                            Me.TabControl1.TabPages.Remove(TPLTDCompanyContratorDetails)
                        Else

                        End If
                    End If

                    If EmployeeModifyLinq.LoyaltyCard Is Nothing Then
                        LoyaltyCard.Checked = False
                    Else
                        LoyaltyCard.Checked = EmployeeModifyLinq.LoyaltyCard
                    End If
                    If EmployeeModifyLinq.LoyaltyPoints Is Nothing Then
                        LoyaltyPoints.EditValue = 0
                    Else
                        LoyaltyPoints.EditValue = EmployeeModifyLinq.LoyaltyPoints
                    End If
                    Dim item As ImageComboBoxItem
                    If EmployeeModifyLinq.LoyaltyRank Is Nothing Then
                        item = LoyaltyRank.Properties.Items.GetItem("Bronze")
                        LoyaltyRank.SelectedItem = item
                    Else
                        item = LoyaltyRank.Properties.Items.GetItem(EmployeeModifyLinq.LoyaltyRank.Trim())

                        LoyaltyRank.SelectedItem = item
                    End If

                    If lblStatus.Text = "Status: New" Then
                        DateRegistered.Enabled = True

                    Else
                        DateRegistered.Enabled = False

                    End If
                    If GetSecurityInfo2("EmployeesHeadOffice", "Lexicon") <> 0 Then
                        Status.Enabled = True
                        StatusReason.ReadOnly = False

                    Else
                        Select Case EmployeeModifyLinq.Status
                            Case "Archive"
                                If EmployeeModifyLinq.LastWorkedDate > DateAdd(DateInterval.Month, -6, Now()) Then
                                    Status.Enabled = True
                                    StatusReason.ReadOnly = False
                                Else
                                    Status.Enabled = False
                                    StatusReason.ReadOnly = True

                                End If
                            Case "N/S"
                                Status.Enabled = False
                                StatusReason.ReadOnly = True

                            Case "Blacklisted"
                                Status.Enabled = False
                                StatusReason.ReadOnly = True
                            Case "Cloned"
                                Status.Enabled = False
                                StatusReason.ReadOnly = True

                            Case "TOT"
                                Status.Enabled = True
                                StatusReason.ReadOnly = False

                            Case Else
                                Status.Enabled = True
                                StatusReason.ReadOnly = False

                        End Select


                    End If
                    Dim Moneyowed = (From EmployeesMoneyOwed In dc.GetTable(Of LinqEmployeesMoneyOwed)() Where EmployeesMoneyOwed.EmployeeID = bigint.ToString And EmployeesMoneyOwed.Paid = False).Count

                    If Moneyowed >= 1 Then
                        Status.Enabled = False

                    End If
            End Select


        Catch ex As Exception

            MsgBox(ex.ToString)
        Finally
            If GetSecurityInfo2("EmployeesHeadOffice", "Lexicon") <> 0 Then
                If TabControl1.TabPages.Contains(TBHeadOffice) Then

                Else
                    Me.TabControl1.TabPages.Add(TBHeadOffice)
                End If
            Else
                If EmployeeID.Text <> "" Then
                    NiNumber.ReadOnly = True
                Else


                End If

                If TabControl1.TabPages.Contains(TBHeadOffice) Then
                    Me.TabControl1.TabPages.Remove(TBHeadOffice)
                Else

                End If
            End If
            If EmployeeID.Text <> "" Then

                If GetSecurityInfo2("EmployeesScheme", "Lexicon") <> 0 Then
                    Scheme.Enabled = True
                Else
                    Scheme.Enabled = False
                End If
            Else
                Scheme.Enabled = True

            End If
        End Try


    End Sub
    Private Sub ComboBox2_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles Branch.SelectionChangeCommitted

    End Sub
    Dim cmd As New SqlCommand
    Dim allTxt As New List(Of Control)


    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function
    Private Sub Cb_Branch_TextChanged(sender As System.Object, e As System.EventArgs) Handles Branch.TextChanged
        Try
            If Dset.Tables("BranchId") IsNot Nothing Then
                Dset.Tables("BranchId").Clear()
            End If
            If Branch.Text = "" Then
                MsgBox("Invalid Branch Selection")
            Else
                If IsNumeric(Strings.Left(Branch.Text, 1)) Then


                    adSQLAdapter2 = New SqlDataAdapter("select BranchId from CV_BranchDropdown where Expr1 = '" + Branch.Text + "'", Main.con)


                    adSQLAdapter2.Fill(Dset, "BranchId")
                    '  
                    Main.con.Open()
                    Branch.Tag = Dset.Tables("BranchId").Rows(0)(0).ToString
                    If EmployeeCode.Text = "" Then


                        adSQLAdapter2 = New SqlDataAdapter("DECLARE @RC int DECLARE @ID bigint DECLARE @Code nvarchar(30) EXECUTE  [dbo].[CFN_GetNextBranchNumber] " + Branch.Tag + "  ,@Code OUTPUT   select @Code", Main.con)
                        If Dset.Tables("EmployeeCode") IsNot Nothing Then
                            Dset.Tables("EmployeeCode").Clear()
                        End If
                        adSQLAdapter2.Fill(Dset, "EmployeeCode")




                        ' cmd.ExecuteNonQuery()
                        EmployeeCode.Text = Dset.Tables("EmployeeCode").Rows(0)(0).ToString()
                    End If

                End If
            End If
        Catch ex As Exception



        Finally
            Main.con.Close()
        End Try


    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles PostCode.TextChanged
        'Dim PostCodelookup As String

    End Sub

    Private Sub Tb_PostCode_Leave(sender As System.Object, e As System.EventArgs) Handles PostCode.Leave
        Try
            adSQLAdapter2 = New SqlDataAdapter("SELECT TOP 1  [town]  ,[county]  FROM [LexiconRecManager].[dbo].[uk_postcodes]  where postcode = left('" + PostCode.Text + "', CHARINDEX(' ', '" + PostCode.Text + "')) ", Main.con)
            If Dset.Tables("PostCode") IsNot Nothing Then
                Dset.Tables("PostCode").Clear()
            End If
            adSQLAdapter2.Fill(Dset, "PostCode")

            City.Text = Dset.Tables("PostCode").Rows(0)(0).ToString()
            County.Text = Dset.Tables("PostCode").Rows(0)(1).ToString()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Cb_Scheme_TextChanged(sender As System.Object, e As System.EventArgs) Handles Scheme.TextChanged

        Try
            If IsNumeric(Strings.Left(Scheme.Text, 1)) Then

                Dim dc As New DataClasses1DataContext


                Dim LinqSchemePick = (From Schemes In dc.GetTable(Of LinqCV_SchemeDropdown)() Where Schemes.Expr1 = Scheme.Text).SingleOrDefault
                Scheme.Tag = LinqSchemePick.SchemeID
            End If



        Catch ex As Exception
        End Try

    End Sub


    Private Sub Communication_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Branch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Branch.SelectedIndexChanged

    End Sub

    Private Sub Scheme_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Scheme.SelectedIndexChanged
        If Scheme.Tag = "5" Then
            'TabControl1.TabPages.(TPLTDCompanyContratorDetails)
            If TabControl1.TabPages.Contains(TPLTDCompanyContratorDetails) Then

            Else
                Me.TabControl1.TabPages.Add(TPLTDCompanyContratorDetails)
            End If

        Else
            If TabControl1.TabPages.Contains(TPLTDCompanyContratorDetails) Then
                Me.TabControl1.TabPages.Remove(TPLTDCompanyContratorDetails)
            Else

            End If

        End If
    End Sub

    Private Sub NiNumber_Leave(sender As Object, e As EventArgs)
        Try
            If NiNumber.ReadOnly = False Then
                If NiNumber.Text = "" Then
                    NiNumber.Focus()

                End If

                adSQLAdapter2 = New SqlDataAdapter("SELECT TOP 1  employeeid from employees where NINumber = '" + NiNumber.Text + "' and Employeeid <> '" + EmployeeID.Text + "'", Main.con)
                If Dset.Tables("NiNumber") IsNot Nothing Then
                    Dset.Tables("NiNumber").Clear()
                End If
                adSQLAdapter2.Fill(Dset, "NiNumber")

                If Dset.Tables("NiNumber").Rows.Count <> 0 Then

                    MsgBox("NINumber isnt unique" + Dset.Tables("NiNumber").Rows(0)(0).ToString())
                    NiNumber.Focus()
                End If
            End If
        Catch ex As Exception

            If ex.ToString() <> "" Then
                MsgBox("NINumber isnt unique")
                NiNumber.Focus()
            End If
        End Try

    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs)

    End Sub
    Dim da2 As SqlDataAdapter
    Dim UserBranch, Sql As String
    Dim Dset2 As New DataTable

    Public Function GetSecurityInfo(area As String, application As String)
        da2 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset2 IsNot Nothing Then
            Dset2.Clear()
        End If
        da2.Fill(Dset2)
        Return Dset2.Rows(0)(0).ToString()


    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim updatestatusstr As String

            Select Case systemtypeTb.Text

                Case "R"
                    If GetSecurityInfo("EmployeeStatusUpgradeProcessed", "Lexicon") <> "0" Then
                        Dim result = MsgBox("Have you checked all areas are correct including BANK DETAILS, NI NUMBER,TAX DETAILS, EMPLOYEE TYPE, LTD CO ECT.", MsgBoxStyle.YesNo, "Checked?")
                        If result = DialogResult.Cancel Then
                            MessageBox.Show("Cancel pressed")
                        ElseIf result = DialogResult.No Then
                            MessageBox.Show("No pressed")
                        ElseIf result = DialogResult.Yes Then
                            If (Me.Validate()) Then

                                updatestatusstr = "   Update Employees set   SystemType = " + "'P'" + " WHERE(EmployeeID = " + bigint.ToString + ")"
                                lblStatus.Text = "Status: Processed/Checked"
                                lblStatus.ForeColor = Color.Orange
                                adSQLAdapter2 = New SqlDataAdapter(updatestatusstr, Main.con)
                                If Dset.Tables("UpdateEmployee") IsNot Nothing Then
                                    Dset.Tables("UpdateEmployee").Clear()
                                End If
                                adSQLAdapter2.Fill(Dset, "UpdateEmployee")
                                MessageBox.Show("SEND ALL FORMS (if applicable) TO THE ASSOCIATED PAY-ROLLING COMPANY... If you are placing the worker on the plan and have been asked to bypass this process you MUST gain authorisation from John Sutton.", "Important!")
                            End If

                        End If

                    End If

                Case "P"
                    If GetSecurityInfo("EmployeeStatusUpgradeCompleted", "Lexicon") <> "0" Then
                        lblStatus.Text = "Status: Completed"
                        lblStatus.ForeColor = Color.Green
                        updatestatusstr = "   Update Employees set   SystemType = " + "'C'" + " WHERE(EmployeeID = " + bigint.ToString + ")"
                        adSQLAdapter2 = New SqlDataAdapter(updatestatusstr, Main.con)
                        If Dset.Tables("UpdateEmployee") IsNot Nothing Then
                            Dset.Tables("UpdateEmployee").Clear()
                        End If
                        adSQLAdapter2.Fill(Dset, "UpdateEmployee")
                        MessageBox.Show("If this employee was a liq worker an email has been automatically sent to admin@liquiditygroup.co.uk and mrychly@liquiditygroup.co.uk INFORMING THEM OF THE NEW STARTER NAME AND EMP NUMBER", "Important!")
                        If Scheme.Text.StartsWith("LIQ") = True Then

                            'Try


                            '    Dim Message As MailMessage = New MailMessage()

                            '    Message.From = New MailAddress("Emma.Mansell@purestaff.co.uk")
                            '    Message.To.Add("Emma.Mansell@purestaff.co.uk")
                            '    Message.To.Add("admin@liquiditygroup.co.uk")
                            '    Message.To.Add("mrychly@liquiditygroup.co.uk")

                            '    Message.ReplyToList.Add("Emma.Mansell@purestaff.co.uk")
                            '    Message.Subject = "Pure Staff new starter notification: Name:" + Forename.Text + " " + Surname.Text + " Scheme: " + Scheme.Text + " Employee No: " + EmployeeCode.Text
                            '    Message.IsBodyHtml = True
                            '    Message.Body = "This is an automated email to confirm to you that the above named worker has now started working, this email has been sent to you to enable you to set this worker up on your system ready for payroll.  The workers application form / full set up details have already been sent to you,  if you have any issues setting this worker up ready for payroll you should contact the payroll manager at Pure Staff immediately in order to rectify the issue before payroll commences."
                            '    Dim smtp As SmtpClient = New SmtpClient("PURESTAFFSERVER", 25)
                            '    smtp.Credentials = New System.Net.NetworkCredential("purestaff\craigwright", "cw84343751")
                            '    smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                            '    smtp.Send(Message)
                            'Catch ex As Exception

                            'End Try
                        End If
                    End If

            End Select




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub EmployeeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Schemes' table. You can move, or remove it, as needed.
        Me.SchemesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Schemes)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)

    End Sub

    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged
        If Status.Text = "TOT" Then
            StatusReason.ReadOnly = True
        Else
            StatusReason.ReadOnly = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case systemtypeTb.Text

            Case "R"

                Dim result = MsgBox("Are you sure you want to delete this employee?", MsgBoxStyle.YesNo, "Checked?")
                If result = DialogResult.Cancel Then
                    MessageBox.Show("Cancel pressed")
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("No pressed")
                ElseIf result = DialogResult.Yes Then
                    If (Me.Validate()) Then
                        Dim deletestatusstr = "   delete from Employees  WHERE(EmployeeID = " + bigint.ToString + ")"

                        adSQLAdapter2 = New SqlDataAdapter(deletestatusstr, Main.con)
                        If Dset.Tables("deleteemployee") IsNot Nothing Then
                            Dset.Tables("deleteemployee").Clear()
                        End If
                        adSQLAdapter2.Fill(Dset, "deleteemployee")
                    End If



                End If


        End Select
    End Sub


    Private Sub Tb_Email_InvalidValue(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles Tb_Email.InvalidValue
        e.ErrorText = "The Email is not Valid"

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles DriverLicenseCheckConsentFormCompleteCB.CheckedChanged
        If DriverLicenseCheckConsentFormCompleteCB.Checked = False Then
            DateDrivingLicenceLastChecked.Enabled = False
        Else
            DateDrivingLicenceLastChecked.Enabled = True

        End If
    End Sub
    'Clone Button

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to clone this employee, doing this will cause the current screen to close and you will lose any unsaved changes", vbYesNo)
        If ans = vbYes Then
            If Status.Text <> "TOT" Then
                MsgBox("Can Only Clone TOT Temps")
            Else
                If BranchLUE.Text = "" Or SchemeLUE.Text = "" Then
                    MsgBox("Cannot Clone Without Branch Or Scheme Blank")
                Else
                    Dim dc As New DataClasses1DataContext

                    dc.LinqCloneEmployee(EmployeeID.Text, BranchLUE.EditValue, SchemeLUE.EditValue)

                    Dim EmployeeModLinq = (From Employees In dc.GetTable(Of LinqEmployeeModify)() Where Employees.PreviousReference = EmployeeCode.Text).Single

                    MsgBox("New Employeecode: " + EmployeeModLinq.EmployeeCode.ToString)

                    Me.Close()
                End If
            End If

        End If

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Below is the buttons for the money owed grid
    Private Sub DataNavigator1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles DataNavigator1.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Append Then
            MsgBox(e.Button.Tag)
            EmployeesMoneyOwedBindingSource.AddNew()
            With GridView1
                .SetRowCellValue(.FocusedRowHandle, colEmployeeID, bigint)
            End With
            e.Handled = True

        ElseIf e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.EndEdit Then

            Me.EmployeesMoneyOwedTableAdapter.Update(Me.Sites.EmployeesMoneyOwed)
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        With GridView1
            .SetRowCellValue(.FocusedRowHandle, colPaidChangedBy, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
            .SetRowCellValue(.FocusedRowHandle, colPaidChangedDate, Now.ToString("yyyy/MM/dd HH:mm:ss"))

        End With
    End Sub


    Private Sub Status_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Status.SelectionChangeCommitted
        StatusChangeDateTb.Text = Now()
    End Sub

    Private Sub Passport_CheckStateChanged(sender As Object, e As EventArgs) Handles Passport.CheckStateChanged, Visa.CheckStateChanged, DrivingLicense.CheckStateChanged, DigiCard.CheckedChanged, CPCM1.CheckedChanged
        If Passport.Checked = True Then
            PassportExpiryDate.Enabled = True
        Else
            PassportExpiryDate.Enabled = False
        End If

        If Visa.Checked = True Then
            VisaExpiryDate.Enabled = True
        Else
            VisaExpiryDate.Enabled = False
        End If

        If DrivingLicense.Checked = True Then
            DrivingExpiryDate.Enabled = True
        Else
            DrivingExpiryDate.Enabled = False
        End If
        If DigiCard.Checked = True Then
            DigiCardExpiryDate.Enabled = True
        Else
            DigiCardExpiryDate.Enabled = False
        End If
        If CPCM1.Checked = True Then
            DQCExpiryDate.Enabled = True
        Else
            DQCExpiryDate.Enabled = False
        End If
    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub


    'below adds an event to the update button on the edit form for moneyowed.
    Private Sub GridView1_ShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        For Each control As Control In e.EditForm.Controls
            If Not (TypeOf control Is EditFormContainer) Then
                Continue For
            End If
            For Each nestedControl As Control In control.Controls
                If Not (TypeOf nestedControl Is PanelControl) Then
                    Continue For
                End If
                For Each button As Control In nestedControl.Controls
                    If Not (TypeOf button Is SimpleButton) Then
                        Continue For
                    End If
                    Dim simpleButton = TryCast(button, SimpleButton)
                    RemoveHandler simpleButton.Click, AddressOf editFormUpdateButton_Click
                    AddHandler simpleButton.Click, AddressOf editFormUpdateButton_Click
                Next
            Next
        Next
    End Sub

    Private Sub editFormUpdateButton_Click(sender As Object, e As EventArgs)
        Me.EmployeesMoneyOwedTableAdapter.Update(Me.Sites.EmployeesMoneyOwed)

    End Sub

End Class
