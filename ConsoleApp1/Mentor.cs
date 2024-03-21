using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mentor
    {
        public int MentorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    
    
        static List<Mentor> mentors = new List<Mentor>();

        public static void MentorOperations(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Mentor elave et");
                Console.WriteLine("2. Mentor melumatlarini deyis");
                Console.WriteLine("3. Mentor melumatlarini sil");
                Console.WriteLine("4. Mentor melumatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddMentor();
                        break;
                    case "2":
                        ModifyMentor();
                        break;
                    case "3":
                        RemoveMentor();
                        break;
                    case "4":
                        DisplayMentor();
                        break;
                    case "5":
                        Console.WriteLine("Proqramdan cixilir");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim! Zehmet olmasa dogru secimi edin.");
                        break;
                }
            }
        }

        static void AddMentor()
        {
            Mentor newMentor = new Mentor();

            Console.Write("Mentorun ID-i daxil edin (2-200): ");
            newMentor.MentorID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mentorun adini daxil edin: ");
            newMentor.Name = Console.ReadLine();

            Console.Write("Mentorun soyadini daxil edin: ");
            newMentor.Surname = Console.ReadLine();

            mentors.Add(newMentor);
            Console.WriteLine("Mentor elave edildi!");
        }

        static void ModifyMentor()
        {
            Console.Write("Deyismek istediyiniz mentorun ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Mentor mentor = mentors.Find(m => m.MentorID == ID);
            if (mentor != null)
            {
                Console.Write("Yeni adi daxil edin: ");
                mentor.Name = Console.ReadLine();

                Console.Write("Yeni soyadi daxil edin: ");
                mentor.Surname = Console.ReadLine();

                Console.WriteLine("Mentor melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Mentor tapilmadi!");
            }
        }

        static void RemoveMentor()
        {
            Console.Write("Silmək istədiyiniz mentorun no-sunu daxil edin: ");
            int no = int.Parse(Console.ReadLine());

            Mentor mentor = mentors.Find(m => m.MentorID == no);
            if (mentor != null)
            {
                mentors.Remove(mentor);
                Console.WriteLine("Mentor silindi!");
            }
            else
            {
                Console.WriteLine("Mentor tapilmadi!");
            }
        }

        static void DisplayMentor()
        {
            Console.WriteLine("Mentor melumatlari:");
            foreach (Mentor mentor in mentors)
            {
                Console.WriteLine($"ID: {mentor.MentorID}, Ad: {mentor.Name}, Soyad: {mentor.Surname}");
            }
        }
    }
}