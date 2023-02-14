using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public partial class ServicePhoto
    {
        public string MainImage { get
            {

                return "..\\..\\Assets\\img\\"+PhotoPath;
                    }
        }
    }
}
