using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    public interface INguoi
    {
        string Ho { get; set; }
        string Ten { get; set; }

        string LayTenDayDu();
    }
}
