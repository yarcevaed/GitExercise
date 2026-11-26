namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"a # b\"");
            string calcul = " ";
            calcul = Console.ReadLine();
            int rez = 0;
            if ((calcul[2] != '*' || calcul[2] != '+' || calcul[2] != '-' || calcul[2] != '/') && calcul.Length < 5)
                return;
            else
            {
                char op = ' ';
                int curs = 0;
                string a = "";
                int b;
                for (int i = 0; i < calcul.Length; i++)
                {
                    if (calcul[i] == ' ')
                    { op = calcul[i + 1]; curs = i; break; }
                    else
                    { a = a + calcul[i];}
                }
                b = int.Parse(a);
                a = "";
                for (int i = curs + 3; i < calcul.Length; i++)
                {
                     a = a + calcul[i]; 
                }
                if (op == '+')
                {
                    rez = b + int.Parse(a);
                }
                else if (op == '-')
                {
                    rez = b - int.Parse(a);
                }
                else if (op == '*')
                {
                    rez = b * int.Parse(a);
                }
                else if (op == '/')
                {
                    rez = b / int.Parse(a);
                }

                Console.WriteLine($"{calcul} = {rez}");

            }

        }
    }
}
