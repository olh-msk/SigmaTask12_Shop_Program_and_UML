using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class Administrator
    {
        //відповідає за id
        private static int administratorNextUniqueId = 1;

        public int AdministratorId { get; private set; }

        public Administrator()
        {
            this.AdministratorId = administratorNextUniqueId++;
        }
    }
}
