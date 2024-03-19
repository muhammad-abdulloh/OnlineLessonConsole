using MyCollections.Application.Services;
using MyCollections.Models;
using System.Collections;

namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientService patientService = new PatientService();

            IEnumerable<Patient> result =  patientService.GetPatients();

            foreach (Patient patient in result)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, SSN: {patient.SSN}");
            }

            //1
            Console.ForegroundColor = ConsoleColor.Red;

            Patient patient1 = new Patient()
            {
                Id = 8,
                Name = "Test",
                SSN = 123123
            };

            IEnumerable<Patient> result2 = patientService.CreatePatient(patient1);


            

            foreach (Patient patient in result2)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, SSN: {patient.SSN}");
            }

            Console.ForegroundColor= ConsoleColor.Blue;


            ICollection<Patient> result3 = (ICollection<Patient>)patientService.GetPatients();

            // SSN raqami ga teng elementni topish kere
            // va barcha malumotlarni chiqarish kere

            Patient value = patientService.GetPatientBySSN(123123);

            Console.WriteLine($"Id: {value.Id}, Name: {value.Name}, SSN: {value.SSN}");
           
            Console.ForegroundColor = ConsoleColor.White;







            ICollection<int> collection = new List<int>();

            IList<int> list2 = new List<int>();

            ArrayList array = new ArrayList()
            {
                23, 32, 3,123,12 ,3,12,3
            };

            IDictionary dictionary = new Hashtable();



        }
    }
}
