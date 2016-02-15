using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

/// <summary>
/// Implement a powershell service to run scripts... and get some results
/// </summary>
/// <remarks>
/// Main informations gathered from
///     - http://blogs.msdn.com/b/kebab/archive/2014/04/28/executing-powershell-scripts-from-c.aspx
///     
/// </remarks>
namespace PSRunner.Services
{
    public class PowershellRunner : IPowershell
    {
        public IEnumerable<string> Run(string script)
        {
            using (PowerShell psInstance = PowerShell.Create())
            {
                psInstance.AddScript(script);
                var result = psInstance.Invoke();

                return result.Select(item => item.ToString());                
            }
        }
    }
}
