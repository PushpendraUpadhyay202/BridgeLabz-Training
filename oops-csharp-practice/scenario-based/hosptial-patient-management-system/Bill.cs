using System;
internal class Bill
{
    private static int id = 1;

    private readonly int billID;
    private readonly DateTime billGenerationDate;
    private readonly Patient billedPatient;
    private readonly double billAmount;
    public Bill(Patient billedPatient, double billAmount)
    {
        this.billID = id++;
        this.billAmount = billAmount;
        this.billGenerationDate = DateTime.Now;
        this.billedPatient = billedPatient;
    }
    public int GetBillId()
    {
        return billID;
    }
    public DateTime GetBillGenerationTime()
    {
        return billGenerationDate;
    }
    public Patient GetBilledPatient()
    {
        return billedPatient;
    }
    public double GetBillAmount()
    {
        return billAmount;
    }
    public override string ToString()
    {
        return $"\nBill Id: {billID}\nBill Generation Date: {billGenerationDate}\nBilled Patient: {billedPatient}\nBill Amount: {billAmount}";
    }
}