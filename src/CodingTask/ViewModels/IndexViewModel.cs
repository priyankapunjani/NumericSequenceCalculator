using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//..
using CodingTask.Models;
namespace CodingTask.ViewModels
{
    public class IndexViewModel
    {
        public MyNumberModel Number { get; set; }
        public IEnumerable<MyNumberModel> AllNumbers { get; set; }
        public IEnumerable<MyNumberModel> OddNumbers { get; set; }

        public IEnumerable<MyNumberModel> EvenNumbers { get; set; }
        public IEnumerable<MyNumberModel> FiboNumbers { get; set; }


        public string Message { get; set; }
    }
}
