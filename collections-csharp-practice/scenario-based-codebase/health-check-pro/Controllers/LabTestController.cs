using System;

[Controller]
class LabTestController
{
    [PublicAPI]
    public string GetAllTests()
    {
        return "CBC, LFT, KFT";
    }

    [RequiresAuth]
    public string GetTestResults(int testId)
    {
        return $"Result for test {testId}";
    }

    public void DeleteTest(int testId)
    {
        
    }
}