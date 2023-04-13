using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TestData
    {
        public string LogTime { get; set; }
        public int StepNo { get; set; }
        public string CircuitName { get; set; }
        public decimal TMP1 { get; set; }
        public decimal TMP2 { get; set; }
        public decimal B31 { get; set; }
        public decimal B32 { get; set; }
        public string B21 { get; set; }
        public string B22 { get; set; }
        public decimal P101 { get; set; }
        public decimal RegulatorSP { get; set; }
        public decimal RegulatorFB { get; set; }
    }
}
