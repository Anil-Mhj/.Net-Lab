using System;

namespace ConsoleApp22
{
    class Program
    {
        delegate int Total(Student s);
        delegate double Percent(Student s);
        delegate string Grade(Student s);

        static void Main()
        {
            StudentCollection list = new StudentCollection();
            int n = 0, ch;

            Total t = s => s.M1 + s.M2 + s.M3;
            Percent p = s => s.Total / 3.0;
            Grade g = s =>
                s.Percentage >= 80 ? "A" :
                s.Percentage >= 60 ? "B" :
                s.Percentage >= 40 ? "C" : "Fail";

            do
            {
                Console.WriteLine("\n1.Add 2.View 3.Update 4.Process 5.Exit");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Student s = new Student();
                        Console.Write("ID: ");
                        s.Id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        s.Name = Console.ReadLine();
                        Console.Write("Marks (3): ");
                        s.M1 = int.Parse(Console.ReadLine());
                        s.M2 = int.Parse(Console.ReadLine());
                        s.M3 = int.Parse(Console.ReadLine());
                        list[n++] = s;
                        break;

                    case 2:
                        for (int i = 0; i < n; i++)
                            list[i].Show();
                        break;

                    case 3:
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                            if (list[i].Id == id)
                            {
                                Console.Write("New Name: ");
                                list[i].Name = Console.ReadLine();
                                Console.Write("Marks (3): ");
                                list[i].M1 = int.Parse(Console.ReadLine());
                                list[i].M2 = int.Parse(Console.ReadLine());
                                list[i].M3 = int.Parse(Console.ReadLine());
                            }
                        break;

                    case 4:
                        for (int i = 0; i < n; i++)
                        {
                            list[i].Total = t(list[i]);
                            list[i].Percentage = p(list[i]);
                            list[i].Grade = g(list[i]);
                        }
                        Console.WriteLine("Results Processed.");
                        break;
                }

            } while (ch != 5);
        }
    }
}