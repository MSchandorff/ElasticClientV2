using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class TestData
    {
        public int Id { get; set; }
        public DateTime LogTime { get; set; }
        public int StepNo { get; set; }
        public string CircuitName { get; set; }
        public decimal TMP1 { get; set; }
        public decimal TMP2 { get; set; }
        public decimal B31 { get; set; }
        public decimal B32 { get; set; }
        public decimal B21 { get; set; }
        public decimal B22 { get; set; }
        public decimal P101 { get; set; }
        public int RegulatorSP { get; set; }
        public int RegulatorFB { get; set; }
    }
}
