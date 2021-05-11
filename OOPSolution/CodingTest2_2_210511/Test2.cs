using System;

namespace CodingTest2_2_210511
{
    class Test1
    {
        public class Boiler
        {
            
            private byte voltage;

            public byte Voltage
            {
                get { return this.voltage; }
                set
                {
                    if (value != 110 && value != 220)
                    {
                        while (true)
                        {
                            Console.WriteLine("전압에 110 또는 220을 입력해주세요.");
                            this.voltage = byte.Parse(Console.ReadLine());
                            if (this.voltage == 110 || this.voltage == 220)
                                break;
                        }

                    }
                    else
                    {
                        this.voltage = value;
                    }

                }
            }
        


            public string Brand { get; set; }

            private int temperature;
            public int Temperature
            {
                get { return this.temperature; }
                set
                {
                    if (value <= 5)
                        this.temperature = 5;
                    else if (value >= 70)
                        this.temperature = 70;
                    else
                        this.temperature = value;
                }
            }

            public void PrintAll()
            {
                Console.WriteLine($"{this.Brand} : {this.Voltage}V, {this.Temperature}℃");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 221, Temperature = 45 };
                kitturami.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            

        }

    }
}
