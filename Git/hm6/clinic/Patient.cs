using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.clinic
{
    public class Patient
    {
        private TreatmentPlan plan;
        private Doctor assignedDoctor;

        public Patient(TreatmentPlan plan)
        {
            this.plan = plan;
        }
        public Patient()
        {
        }

        public void AddTreatmentPlan(TreatmentPlan plan)
        {
            this.plan = plan;
        }

        public void AssignDoctorAndTreat()
        {
            Doctor assignedDoctor = plan.Code switch
            {
                1 => new Surgeon(),
                2 => new Dentist(),
                _ => new Therapist()
            }; ;

            assignedDoctor.Treat();
        }
    }
}
