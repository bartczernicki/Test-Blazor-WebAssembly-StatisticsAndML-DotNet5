using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Blazor_WebAssembly_StatisticsAndML_DotNet5
{
    public class PerformanceResult
    {
        public int ID { get; set; }

        public string TestName { get; set; }

        public double Time { get; set; }
    }
}
