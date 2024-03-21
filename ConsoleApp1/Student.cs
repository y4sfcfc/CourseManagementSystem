using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    

    
     static List<Student> students = new List<Student>();

        public static void StudentOperations(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebe melumatlarini deyis");
                Console.WriteLine("3. Telebe melumatlarini sil");
                Console.WriteLine("4. Telebe melumatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ModiftStudent();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "4":
                        DisplayStudent();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlis secim! Zehmet olmasa dogru sccimi edin.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Student yeniTelebe = new Student();

            Console.Write("Telebenin ID-i daxil edin (3-300): ");
            yeniTelebe.StudentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telebenin adini daxil edin: ");
            yeniTelebe.Name = Console.ReadLine();

            Console.Write("Telebenin soyadini daxil edin: ");
            yeniTelebe.Surname = Console.ReadLine();

            students.Add(yeniTelebe);
            Console.WriteLine("Telebe elave edildi!");
        }

        static void ModiftStudent()
        {
            Console.Write("Deyismek istediyiniz telebenin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Student telebe = students.Find(t => t.StudentID == ID);
            if (telebe != null)
            {
                Console.Write("Yeni adi daxil edin: ");
                telebe.Name = Console.ReadLine();

                Console.Write("Yeni tapilmadi daxil edin: ");
                telebe.Surname = Console.ReadLine();

                Console.WriteLine("Telebe melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi!");
            }
        }

        static void RemoveStudent()
        {
            Console.Write("Silmek istediyiniz telebenin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Student telebe = students.Find(t => t.StudentID == ID);
            if (telebe != null)
            {
                students.Remove(telebe);
                Console.WriteLine("Telebe silindi!");
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi!");
            }
        }

        static void DisplayStudent()
        {
            Console.WriteLine("Telebe məlumatları:");
            foreach (Student telebe in students)
            {
                Console.WriteLine($"ID: {telebe.StudentID}, Ad: {telebe.Name}, Soyad: {telebe.Surname}");
            }
        }
    }
}
