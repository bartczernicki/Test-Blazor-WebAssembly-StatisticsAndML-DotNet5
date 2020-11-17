using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Test_Blazor_WebAssembly_StatisticsAndML_DotNet5
{
    public class PerformanceTest
    {
        public int ID { get; set; }

        public string DistributionName { get; set; }

        public int TrialsNumber { get; set; }

        public int SamplesNumber { get; set; }

        public double TestDuration { get; set; }

        public double TakeSamples()
        {
            var dateTime = DateTime.Now;
            var binomaial = new MathNet.Numerics.Distributions.Binomial(0.5, this.TrialsNumber);
            var generatedsamples = binomaial.Samples().Take(SamplesNumber).ToArray();
            var dateTimeElapsed = (DateTime.Now - dateTime).TotalMilliseconds;

            return dateTimeElapsed;
        }

        public string GetTestName()
        {
            var fullName = $"{DistributionName}-Trials:{TrialsNumber}-Samples:{SamplesNumber}";
            return fullName;
        }
    }
}
