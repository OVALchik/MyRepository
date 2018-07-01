using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public class CreateReportController
    {
        private StringBuilder _info;

        public StringBuilder Info
        {
            get { return _info; }
            set
            {
                _info = value;
            }
        }

        public CreateReportController(StringBuilder info)
        {
            _info = info;
        }

    }

}
