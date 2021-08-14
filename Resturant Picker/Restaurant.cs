using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant_Picker
{
    public class Restaurant
    {
        public string Name { get; set; }
        public bool Usr1 { get; set; }
        public bool Usr2 { get; set; }

        public Restaurant()
        {

        }

        public Restaurant (string name)
        {
            this.Name = name;
            this.Usr1 = false;
            this.Usr2 = false;
        }

        public void SetTrue(int Usr)
        {
            if (Usr == 1)
                this.Usr1 = true;
            else if (Usr == 2)
                this.Usr2 = true;
        }
    }
}
