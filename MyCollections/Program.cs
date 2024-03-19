using MyCollections.Application.Services;
using MyCollections.Models;
using System.Collections;

namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
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

            */
            
            PatientService service = new PatientService();

            service.GetPatients();

            var result = service.DeletePatient(3);


            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
            }
            




            /**
            List<Patient> patients2 = new List<Patient>()
            {
                new Patient() {Id = 1, Name = "Shavkatjon", SSN = 12312312 },
                new Patient() {Id = 2, Name = "Shuxratbek", SSN = 656562312 },
                new Patient() {Id = 3, Name = "Mirkozim", SSN = 43542312 },
                new Patient() {Id = 4, Name = "Akramjon", SSN = 23412312 },
                new Patient() {Id = 5, Name = "Sardor", SSN = 23127689 },
                new Patient() {Id = 6, Name = "Muxlisa", SSN = 67872312 },
                new Patient() {Id = 7, Name = "Alisa", SSN = 563752 },
            };

            patients2.Remove(new Patient()
            {
                Id = 1,
                Name = "Shavkatjon",
                SSN = 12312312
            });

            foreach (Patient pat in patients2)
            {
                Console.WriteLine(pat.Name);
            }
            */


            /**
            object a = "Item";
            object b = "Item";

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            object c = "Item";
            object d = new string("Item");

            Console.WriteLine(c == d);
            Console.WriteLine(c.Equals(d));




            var res1 = new Patient()
            {
                Id = 1,
                Name = "Shavkatjon",
                SSN = 12312312
            };

            var res2 = new Patient()
            {
                Id = 1,
                Name = "Shavkatjon",
                SSN = 12312312
            };


            Console.WriteLine(res1 == res2);
            */
        }
    }
}
