using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI.CallCenter
{
    public class CallCenter
    {
        public System.Collections.Generic.Queue<Director> FreeDirectors;
        public System.Collections.Generic.Queue<Manager> FreeManagers;
        public System.Collections.Generic.Queue<Respondent> FreeRespondents;
        public Employee[] OncallEmployee;
         
        public CallCenter(int numberOfEmployees)
        {
            this.FreeDirectors = new System.Collections.Generic.Queue<Director>();
            this.FreeManagers = new System.Collections.Generic.Queue<Manager>();
            this.FreeRespondents = new System.Collections.Generic.Queue<Respondent>();
            this.OncallEmployee = new Employee[numberOfEmployees];
        }

        public Employee dispatchCall()
        {
            var firstRes = new Employee();
            if (FreeRespondents.Count != 0)
            {
                firstRes = FreeRespondents.Dequeue();
            }
            if (FreeManagers.Count != 0)
            {
                firstRes = FreeManagers.Dequeue();
            }
            if (FreeDirectors.Count != 0)
            {
                firstRes = FreeDirectors.Dequeue();
            }

            return firstRes;
        }

    }
}
