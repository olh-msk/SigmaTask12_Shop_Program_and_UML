using System;

namespace SigmaTask12_Shop_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalData data = new PersonalData();

            data.Address.Country = "Oleh";


            Console.WriteLine(@"{0}",data.Address.Country);
        }
    }
}
