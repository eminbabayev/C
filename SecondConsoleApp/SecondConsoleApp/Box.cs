using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    class Box
    {
        public double x;
        public double y;
        public double z;

        private double _result;

        public double Result
        {
            get
            {
                this.Volume();
                return this._result;
            }

        }
        public Box(double x , double y , double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private void Volume ()
        {
         this._result = (this.x * this.y * this.z);
        }
    }
}
