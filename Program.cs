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

            Product test_prod = shop.Facade.StorageManager.ProductFactory.CreateMeatProduct();

            Administrator admin = ShopFacade.Instance().StaffManager.AdministratorManager.CreateNewAdministrator();

            ShopFacade.Instance().StaffManager.AdministratorManager.AddAdministrator(admin);
            //ід буде показано в особистому кабінеті адміністратора
            //і добавляння буде реалізовано через GUI
            ShopFacade.Instance().StaffManager.AdministratorManager.GetAdministratorById(admin.AdministratorId).AddProduct(1, test_prod);

            string text = (StorageManager.Instance().GetProductByID(test_prod.ProductId).Name="Test Product");

            Console.WriteLine("Name of test: {0}",text);

            VIPCustomer vipcus = (VIPCustomer)CustomerManager.Instance().CreateCustomer(1);
            vipcus.PersonalData.Name = "Oleh";

            


            CustomerManager.Instance().AddCustomer(vipcus);

            string resultName = CustomerManager.Instance().GetCustomerById(vipcus.CustomerId).PersonalData.Name;

            Console.WriteLine("Name: {0}", resultName);

            //Щоб замвляти продукти, має бути
            //реалізована GUI, і покупець буде з ним взаємодіяти
            //звіди обирати товари і купувати їх

            vipcus.PersonalData.Money = 100;

            Console.WriteLine("Money: {0}",CustomerManager.Instance().GetCustomerById(vipcus.CustomerId).PersonalData.Money);

            admin.ChangeCustomerStatus(vipcus.CustomerId, UserStatus.Blocked);

            Console.WriteLine("Status after update: {0}", vipcus.GetStatusString());
        }
    }
}
