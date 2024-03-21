namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Group group = new Group();
            Teacher teacher = new Teacher();
            Mentor mentor = new Mentor();
            Student student = new Student();

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
                        group.GroupOperations();
                        break;
                    case "2":
                        teacher.TeacherOperations();
                        break;
                    case "3":
                        mentor.MentorOperations();
                        break;
                    case "4":
                        student.StudentOperations();
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

    }
}