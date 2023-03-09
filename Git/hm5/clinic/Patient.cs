using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm5.clinic
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
                1 => new Doctor(Specialization.Surgeon),
                2 => new Doctor(Specialization.Dentist),
                _ => new Doctor(Specialization.Therapist)
            };

            assignedDoctor.Treat();
        }
    }
}
