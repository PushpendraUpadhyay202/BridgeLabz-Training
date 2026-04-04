using System;
internal interface IAdmin
{
    void AdmitPatient();
    void RecruitDoctor();
    void GenerateBill();
    bool AuthenticateAdmin();
    void ShowBill();
    void ShowAllPatients();
    void ShowAllDoctors();
    void ShowAllBills();
}