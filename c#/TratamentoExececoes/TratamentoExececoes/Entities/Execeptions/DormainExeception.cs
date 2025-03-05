using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExececoes.Entities.Execeptions
{
    class DormainExeception : ApplicationException
    {
        public DormainExeception(string message) : base(message) { }

    }
}
