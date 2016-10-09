using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//..
using CodingTask.Models;
namespace CodingTask.Services
{
    public class CalculatorService : IcalculatorService
    {
        //For the Normal List: 0 1 2 3 4 5 6 7 8 9 10 11
        public IEnumerable<MyNumberModel> GetAll(int num)
        {
            List<MyNumberModel> myAllNumbers = new List<MyNumberModel>();
            for (int i = 0; i <= num; i++)
            {
                myAllNumbers.Add(new MyNumberModel { Num = i });
            }
            return myAllNumbers;
        }


        //For the Even List: 0 2 4 6 8 10 
        public IEnumerable<MyNumberModel> GetEven(int num)
        {
            List<MyNumberModel> myAllNumbers = new List<MyNumberModel>();
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    myAllNumbers.Add(new MyNumberModel { Num = i });
                }
            }
            return myAllNumbers;
        }

        //For the Odd List: 1 3 5 7 9 11 
        public IEnumerable<MyNumberModel> GetOdd(int num)
        {
            List<MyNumberModel> myAllNumbers = new List<MyNumberModel>();
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    myAllNumbers.Add(new MyNumberModel { Num = i });
                }
            }
            return myAllNumbers;
        }

        //for the fibonacci List: 0 1 1 2 3 5 8 13 21 34 
        public IEnumerable<MyNumberModel> GetFibo(int num)
        {
            List<MyNumberModel> myAllNumbers = new List<MyNumberModel>();
            int next;
            int first = 0;
            int second = 1;
            for (int i = 0; i < num; i++)
            {
                MyNumberModel obj = new MyNumberModel();
                next = first + second;
                obj.Num = next;
                myAllNumbers.Add(new MyNumberModel { Num = first });
                first = second;
                second = next;
            }
            return myAllNumbers;
        }

        public string Message(int num)
        {
            string message = "";
            if ((num % 5) == 0 || (num % 3) == 0)
            {
                if (((num % 5) == 0) && ((num % 3) == 0))
                {
                    message = "The number is Multiple of 5 and 3: Z";
                }
                else if ((num % 3) == 0)
                {
                    message = "The number is multiple of 3: C";
                }
                else if ((num % 5) == 0)
                {
                    message = "The number is multiple of 5: E";
                }                
            }
            return message;
        }
    }
}