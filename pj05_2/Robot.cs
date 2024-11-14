using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj05_2
{
    internal class Robot
    {
        protected string name = "";
        protected bool powerStatus = false;

        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した!!", name);
        }

        public void PowerOff() 
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した..", name);
        }

        //名前取得
        public string GetName()
        {
            return name;
        }

        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}
