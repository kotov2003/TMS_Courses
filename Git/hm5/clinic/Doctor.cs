namespace Git.hm5.clinic
{
    public class Doctor
    {
        public Specialization doctorType { get; set; }

        public Doctor(Specialization doctorType)
        {
            this.doctorType = doctorType;
        }

        public void Treat()
        {
            switch (doctorType)
            {
                case Specialization.Surgeon:
                    SurgeonTreat();
                    break;
                case Specialization.Therapist:
                    TherapisTtreat();
                    break;
                case Specialization.Dentist:
                    DentistTreat();
                    break;
                default:
                    break;
            }
        }

        public void SurgeonTreat()
        {
            Console.WriteLine("Surgeon treat started");
        }

        public void TherapisTtreat()
        {
            Console.WriteLine("Therapist treat started");
        }

        public void DentistTreat()
        {
            Console.WriteLine("Dentist treat started");
        }
    }
}