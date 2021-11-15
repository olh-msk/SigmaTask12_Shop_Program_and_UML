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

            Product prod = shop.Facade.StorageManager.ProductFactory.CreateMeatProduct();

            Administrator admin = ShopFacade.Instance().StaffManager.AdministratorManager.CreateNewAdministrator();

            ShopFacade.Instance().StaffManager.AdministratorManager.AddAdministrator(admin);
            //ід буде показано в особистому кабінеті адміністратора
            //і добавляння буде реалізовано через GUI
            ShopFacade.Instance().StaffManager.AdministratorManager.GetAdministratorById(admin.AdministratorId).AddProduct(1, prod);

            string text = (StorageManager.Instance().GetProductByID(prod.ProductId).Name="Test Product");

            Console.WriteLine("Name of test: {0}",text);

        }
    }
}
