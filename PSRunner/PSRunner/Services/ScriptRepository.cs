using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSRunner.Model;

namespace PSRunner.Services
{
    public class ScriptRepository : ISciptRepository
    {
        public ScriptRepository()
        {
            load();
        }

        
        public Script this[string scriptGuid]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Script> Scripts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Script script)
        {
            throw new NotImplementedException();
        }

        public void Delete(Script script)
        {
            throw new NotImplementedException();
        }

        public void Update(Script script)
        {
            throw new NotImplementedException();
        }

        private void Load()
        {
            
        }

        private void Save()
        {

        }

    }
}
