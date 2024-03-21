using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
       
    
        static List<Teacher> teachers = new List<Teacher>();

        public static void TeacherOperations(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Muellim elave et");
                Console.WriteLine("2. Muellim meulamatlarini deyis");
                Console.WriteLine("3. Muellim meulamatlarini sil");
                Console.WriteLine("4. Muellim meulamatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTeacher();
                        break;
                    case "2":
                        ModifyTeacher();
                        break;
                    case "3":
                        RemoveTeacher();
                        break;
                    case "4":
                        DisplayTeacher();
                        break;
                    case "5":
                        Console.WriteLine("Proqramdan cixilir...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim! Zəhmət olmasa dogru secimi edin.");
                        break;
                }
            }
        }

        static void AddTeacher()
        {
            Teacher newTeacher = new Teacher();

            Console.Write("Muellimin ID-i daxil edin (1-100): ");
            newTeacher.TeacherID = int.Parse(Console.ReadLine());

            Console.Write("Muellimin adını daxil edin: ");
            newTeacher.Name = Console.ReadLine();

            Console.Write("Muellimin soyadını daxil edin: ");
            newTeacher.Surname = Console.ReadLine();

            teachers.Add(newTeacher);
            Console.WriteLine("Muellim elave edildi!");
        }

        static void ModifyTeacher()
        {
            Console.Write("DEyismek istediyiniz muellimin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Teacher mueellim = teachers.Find(m => m.TeacherID == ID);
            if (mueellim != null)
            {
                Console.Write("Yeni adı daxil edin: ");
                mueellim.Name = Console.ReadLine();

                Console.Write("Yeni soyadı daxil edin: ");
                mueellim.Surname = Console.ReadLine();

                Console.WriteLine("Muellim melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Muellim tapılmadı!");
            }
        }

        static void RemoveTeacher()
        {
            Console.Write("Silmek istediyiniz muellimin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Teacher mueellim = teachers.Find(m => m.TeacherID == ID);
            if (mueellim != null)
            {
                teachers.Remove(mueellim);
                Console.WriteLine("Muellim silindi!");
            }
            else
            {
                Console.WriteLine("Muellim tapilmadi!");
            }
        }

        static void DisplayTeacher()
        {
            Console.WriteLine("Muellim melumatlari:");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.TeacherID}, Ad: {teacher.Name}, Soyad: {teacher.Surname}");
            }
        }

    }
}


