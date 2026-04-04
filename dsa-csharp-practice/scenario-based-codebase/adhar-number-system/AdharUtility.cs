using System;
using System.Collections.Generic;
using System.Text;

namespace Adhar_Number_Sorting
{
    internal class AdharUtility : IAdhar
    {
        private Adhar[] adhar;
        private int maxsize;
        private int countIndex;

        public AdharUtility()
        {
            maxsize = 20;
            adhar = new Adhar[maxsize];
            countIndex = 0;
        }

        public void AddAdhar()
        {
            Console.WriteLine("\n=============   ADD NEW ADHAR   ===========\n");
            if(countIndex >= maxsize)
            {
                Console.WriteLine("\nAdhar Array Capacity is Full\n");
            }

            string id;
            bool isCorrect;
            do
            {
                Console.Write("Enter Adhar Id : ");
                id = Console.ReadLine();
                isCorrect = isValidId(id);
                if (!isCorrect)
                {
                    Console.WriteLine("\nID Should Contains 12 Digits Only\n");
                }
            } while (!isCorrect);
            Console.Write("Enter Adhar Name : ");
            string name = Console.ReadLine();

            Adhar entry = new Adhar(id, name);

            adhar[countIndex++] = entry;
            Sort();
        }
        public void SearchAdhar()
        {
            Console.WriteLine("\n==============     SEARCH ADHAR     ===============\n");
            string id;
            bool isCorrect;
            do
            {
                Console.Write("Enter Adhar Id : ");
                id = Console.ReadLine();
                isCorrect = isValidId(id);
                if (!isCorrect)
                {
                    Console.WriteLine("\nID Should Contains 12 Digits Only\n");
                }
            } while (!isCorrect);

            Adhar entity = BinarySearch(id);

            if(entity == null)
            {
                Console.WriteLine("\nThis Adhar Id Doesn't Exist\n");
            }
            else
            {
                Console.WriteLine(entity);
            }
            Console.WriteLine();
        }

        public void DisplayAllAdhar()
        {
            for(int i=0; i<countIndex; i++)
            {
                Console.WriteLine(adhar[i]);
            }
        }

        private void Sort()
        {
            for(int exp=11; exp>=0; exp--)
            {
                CountingSort(exp);
            }
        }

        private void CountingSort(int exp)
        {
            int n = countIndex;
            int[] count = new int[10];
            Adhar[] output = new Adhar[n];

            for(int i=0; i<n; i++)
            {
                int digit = adhar[i].GetAdharId()[exp] - '0';
                count[digit]++;
            }

            for(int i=1; i<10; i++)
            {
                count[i] += count[i - 1];
            }

            for(int i=n-1; i>=0; i--)
            {
                int digit = adhar[i].GetAdharId()[exp] - '0';
                output[count[digit] - 1] = adhar[i];
                count[digit]--;
            }

            for(int i=0; i<n; i++)
            {
                adhar[i] = output[i];
            }
        }

        private Adhar BinarySearch(string id)
        {
            int low = 0;
            int high = countIndex - 1;

            while(low <= high)
            {
                int mid = (low+high)/ 2;

                if (adhar[mid].GetAdharId() == id)
                {
                    return adhar[mid];
                }
                int result = string.Compare(id , adhar[mid].GetAdharId());
                if(result < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                
            }
            return null;
        }

        private bool isValidId(string id)
        {
            int countDigit = 0;
            for(int i=0; i<id.Length; i++)
            {
                if (id[i] - '0' >= 0 && id[i] - '0' <= 9)
                {
                    countDigit++;
                }
            }
            if(countDigit != 12)
            {
                return false;
            }
            return true;
        }
    }
}
