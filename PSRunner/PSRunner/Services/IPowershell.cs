using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSRunner.Services
{
    public interface IPowershell
    {
        IEnumerable<string> Run(string script)
    }
}
