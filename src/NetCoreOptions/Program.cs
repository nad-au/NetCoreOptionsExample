using System;
using Microsoft.Extensions.Configuration;

namespace NetCoreOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var config =
                new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", false, true)
                    .Build();
            
            var myOptions = config.GetSection(MyOptions.Path)
                .Get<MyOptions>();
            
            Console.WriteLine($"Count: {myOptions.MyValues.Length}");
            foreach (var myValue in myOptions.MyValues)
            {
                Console.WriteLine($"Value: {myValue}");
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}