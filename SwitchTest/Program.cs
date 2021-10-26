using System;

namespace SwitchTest
{
    class Program
    {
        private SampleEnum.Samples TheValue { get; set; }

        private string Example => TheValue switch
        {
            SampleEnum.Samples.Sample1 => "Test 1",
            SampleEnum.Samples.Sample2 => "Test 2",
            SampleEnum.Samples.Sample3 => "Test 3",
            SampleEnum.Samples.Sample4 => "Test 4"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

