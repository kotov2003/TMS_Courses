using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.clinic
{
    public class TreatmentPlan
    {
        public int Code { get; set; }

        public TreatmentPlan(int code)
        {
            this.Code = code;
        }

        public TreatmentPlan()
        {
        }
    }
}
