using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask12_Shop_Program
{
    class Moderator
    {
        //відповідає за id створенних модераторів
        private static int moderatorNextUniqueId = 1;

        public int ModeratorId { get; private set; }

        public Moderator()
        {
            this.ModeratorId = moderatorNextUniqueId++;
        }
    }
}
