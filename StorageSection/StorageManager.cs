using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class StorageManager
    {
        private static StorageManager instance;

        private AbstractProductFactory factory;
        
        public MeatStorage MeatStorage { get; private set; }
        public DairyStorage DairyStorage { get; private set; }
        public HouseholdStorage HouseholdStorage { get; private set; }

        private StorageManager()
        {
            this.MeatStorage = new MeatStorage();
            this.HouseholdStorage = new HouseholdStorage();
            this.DairyStorage = new DairyStorage();
        }

        public static StorageManager Instance()
        {
            if(instance == null)
            {
                instance = new StorageManager();
            }
            return instance;
        }
    }
}
