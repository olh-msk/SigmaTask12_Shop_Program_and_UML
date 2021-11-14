using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class StaffManager
    {
        private static StaffManager instance;

        private StaffManager()
        {

        }

        public static StaffManager Instance()
        {
            if(instance == null)
            {
                instance = new StaffManager();
            }
            return instance;
        }
    }
}
