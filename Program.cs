using System;

namespace SigmaTask12_Shop_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = Shop.Instance();


            PersonalData data = new PersonalData();

            data.Address.Country = "Ukraine";


            Console.WriteLine(@"{0}",data.Address.Country);
        }
    }
}
