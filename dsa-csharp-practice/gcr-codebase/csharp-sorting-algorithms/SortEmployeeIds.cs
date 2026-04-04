using System;

class SortEmployeeIds
{
    static void Main()
    {
        int[] employeeIds = { 105, 102, 110, 101, 108 };

        for (int i = 1; i < employeeIds.Length; i++)
        {
            int key = employeeIds[i];
            int j = i - 1;

            while (j >= 0 && employeeIds[j] > key)
            {
                employeeIds[j + 1] = employeeIds[j];
                j--;
            }

            employeeIds[j + 1] = key;
        }

        foreach (int id in employeeIds)
            Console.Write(id + " ");
    }
}

