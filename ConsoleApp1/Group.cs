using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        public string GroupID { get; set; }
        public string QrupAdi { get; set; }



        static List<Group> groups = new List<Group>();

        public static void GroupOperations(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Yeni qrup əlavə et");
                Console.WriteLine("2. Çıxış");
                Console.Write("Seçiminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddGroup();
                        break;
                    case "2":
                        Console.WriteLine("Proqramdan cixilir..."); 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim! Zəhmət olmasa doğru seçimi edin.");
                        break;
                }
            }
        }

        static void AddGroup()
        {
            Group newgroup = new Group();

            Console.Write("Qrupun kodunu daxil edin: ");
            string groupID = Console.ReadLine();

            if (DisplayGroup(groupID))
            {
                Console.WriteLine("Bu qrup koduna sahib bir qrup sistemdə mövcuddur.");
                Console.Write("Davam etmək istəyirsinizmi? (Belii/Xeyr): ");
                string asnwer = Console.ReadLine().ToLower();
                if (asnwer != "bəli" && asnwer != "b" && asnwer != "yes" && asnwer != "y")
                {
                    return;
                }
            }

            newgroup.GroupID = groupID;

            Console.Write("Qrupun adını daxil edin: ");
            newgroup.QrupAdi = Console.ReadLine();

            groups.Add(newgroup);
            Console.WriteLine("Qrup əlavə edildi!");
        }

        static bool DisplayGroup(string groupID)
        {
            foreach (Group qrup in groups)
            {
                if (qrup.GroupID == groupID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}