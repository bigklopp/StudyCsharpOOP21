using System;

namespace CodingTest2_1_210511
{
    class Test1
    {
        public class Boiler
        {
            
            public string Brand { get; set; }
            public byte Voltage { get; set; }
            public int Temperature { get; set; }

            public void PrintAll()
            {
                Console.WriteLine($"{this.Brand} : {this.Voltage}V, {this.Temperature}℃");
            }
        }
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();

        }
        
    }
}
