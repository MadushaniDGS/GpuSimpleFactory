using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class AsusManufacture : Company
    {
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }
    }
}
