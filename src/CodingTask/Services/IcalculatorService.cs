using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//..
using CodingTask.Models;
namespace CodingTask.Services
{
   public interface IcalculatorService
    {
        IEnumerable<MyNumberModel> GetAll(int num);      
        IEnumerable<MyNumberModel> GetEven(int num);
        IEnumerable<MyNumberModel> GetOdd(int num);
        IEnumerable<MyNumberModel> GetFibo(int num);

        string Message(int num);
    }
}
