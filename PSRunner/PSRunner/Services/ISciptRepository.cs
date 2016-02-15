using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSRunner.Services
{
    public interface ISciptRepository
    {
        IEnumerable<Model.Script> Scripts { get; }
        void Add(Model.Script script);
        void Update(Model.Script script);
        void Delete(Model.Script script);
        Model.Script this [string scriptGuid] { get; }
    }
}
