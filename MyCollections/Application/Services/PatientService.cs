using MyCollections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Application.Services
{
    public class PatientService
    {
        // beorlarni qo'shish
        // ularni o'chirish
        // o'zgartirish
        // CRUD
        List<Patient> patients = new List<Patient>();

        public IEnumerable<Patient> CreatePatient(Patient data)
        {
            patients.Add(data);

            return patients;
        }

        public Patient GetPatientBySSN(int number)
        {
            
            Patient patient = new Patient();

            foreach (Patient patn in patients)
            {
                if (patn.SSN == number)
                {
                    patient.Id = patn.Id;
                    patient.Name = patn.Name;
                    patient.SSN = patn.SSN;

                }
            }

            return patient;
        }

        public Patient UpdatePatient()
        {
            return new Patient();
        }

        public Patient GetPatient()
        {
            return new Patient();
        }

        public void DeletePatient()
        {
            
        }

        public IEnumerable<Patient> GetPatients()
        {

            IEnumerable<Patient> patients2 = new List<Patient>()
            {
                new Patient() {Id = 1, Name = "Shavkatjon", SSN = 12312312 },
                new Patient() {Id = 2, Name = "Shuxratbek", SSN = 656562312 },
                new Patient() {Id = 3, Name = "Mirkozim", SSN = 43542312 },
                new Patient() {Id = 4, Name = "Akramjon", SSN = 23412312 },
                new Patient() {Id = 5, Name = "Sardor", SSN = 23127689 },
                new Patient() {Id = 6, Name = "Muxlisa", SSN = 67872312 },
                new Patient() {Id = 7, Name = "Alisa", SSN = 563752 },
            };

            patients.AddRange(patients2);
           
            return patients;
        }


    }
}
