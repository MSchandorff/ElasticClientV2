using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TestResult
    {
        public TestResult(TestData testData)
        {
            if (DateTime.TryParse(testData.LogTime, out var logTime))
            {
                LogTime = logTime;
            }
            StepNo = testData.StepNo;
            CircuitName = testData.CircuitName;
            TMP1 = testData.TMP1;
            TMP2 = testData.TMP2;
            B31 = testData.B31;
            B32 = testData.B32;
            B21 = testData.B21;
            B22 = testData.B22;
            P101 = testData.P101;
            RegulatorSP = testData.RegulatorSP;
            RegulatorFB = testData.RegulatorFB;
        }

        public int Id { get; set; }
        public DateTime LogTime { get; set; }
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
