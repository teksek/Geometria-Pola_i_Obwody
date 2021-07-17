using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Geometria_Pola_i_Obwody
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Witaj w Programie do Geometrii!\n");
            Thread.Sleep(500);
            Console.WriteLine("Co chciałbyś obliczyć? \n");
            Console.WriteLine("||Figury Płaskie||");
            Console.WriteLine("1. Pole");
            Console.WriteLine("2. Obwód");
            Console.WriteLine("3. Wysokość");
            Console.WriteLine("4. Przekątna\n");
            Console.WriteLine("||Bryły||");
            Console.WriteLine("5. Pole Całkowite");
            Console.WriteLine("6. Objętość\n");
            Console.WriteLine("7. Wyjście z programu\n");
            string wybor1 = Console.ReadLine();

            if (wybor1 == "1")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Pola.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej figury chciałbyś obliczyć pole?: ");
                Console.WriteLine("1. Kwadrat");
                Console.WriteLine("2. Prostokąt");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Trójkąt równoboczny");
                Console.WriteLine("5. Trapez");
                Console.WriteLine("6. Równoległobok");
                Console.WriteLine("7. Deltoid");
                Console.WriteLine("8. Romb");
                string wybor2_Pole = Console.ReadLine();

                switch (wybor2_Pole)
                {
                    case "1":
                        Console.Clear();
                        Kwadrat();
                        break;
                    case "2":
                        Console.Clear();
                        Prostokąt();
                        break;
                    case "3":
                        Console.Clear();
                        Trójkąt();
                        break;
                    case "4":
                        Console.Clear();
                        Trójkąt_Równoboczny();
                        break;
                    case "5":
                        Console.Clear();
                        Trapez();
                        break;
                    case "6":
                        Console.Clear();
                        Równoległobok();
                        break;
                    case "7":
                        Console.Clear();
                        Deltoid();
                        break;
                    case "8":
                        Console.Clear();
                        Romb();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                        break;
                }
            }
            else if (wybor1 == "2")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Obwodu.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej figury chciałbyś obliczyć pole?: ");
                Console.WriteLine("1. Kwadrat");
                Console.WriteLine("2. Prostokąt");
                Console.WriteLine("3. Trójkąt");
                Console.WriteLine("4. Trójkąt równoboczny");
                Console.WriteLine("5. Trapez");
                Console.WriteLine("6. Równoległobok");
                Console.WriteLine("7. Deltoid");
                Console.WriteLine("8. Romb");
                string wybor2_Obwód = Console.ReadLine();

                switch (wybor2_Obwód)
                {
                    case "1":
                        Console.Clear();
                        KwadratObwód();
                        break;
                    case "2":
                        Console.Clear();
                        ProstokątObwód();
                        break;
                    case "3":
                        Console.Clear();
                        TrójkątObwód();
                        break;
                    case "4":
                        Console.Clear();
                        Trójkąt_RównobocznyObwód();
                        break;
                    case "5":
                        Console.Clear();
                        TrapezObwód();
                        break;
                    case "6":
                        Console.Clear();
                        RównoległobokObwód();
                        break;
                    case "7":
                        Console.Clear();
                        DeltoidObwód();
                        break;
                    case "8":
                        Console.Clear();
                        RombObwód();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                        break;
                }
            }
            else if (wybor1 == "3")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Wysokości.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej figury chciałbyś obliczyć wysokość?: ");
                Console.WriteLine("1. Trójkąt Równoboczny");
                string wybor2_Wysokość = Console.ReadLine();

                if (wybor2_Wysokość == "1")
                {
                    Console.WriteLine("Podaj bok trójkąta(a): ");
                    string bok1 = Console.ReadLine();
                    double bok_trójkąta = double.Parse(bok1);

                    double wynik = bok_trójkąta * Math.Sqrt(3) / 2;
                    Console.WriteLine("Wynik: " + wynik);
                    Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
                    Console.WriteLine("1. Tak");
                    Console.WriteLine("2. Nie");
                    string pytanie = Console.ReadLine();

                    if (pytanie == "1")
                    {
                        Console.Clear();
                        Main();
                    }
                    else if (pytanie == "2")
                    {
                        Console.WriteLine("Dobrze. Wyłączam się...");
                        Thread.Sleep(900);
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                    Thread.Sleep(900);
                    Main();
                }
            }
            else if (wybor1 == "4")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Przekątnej.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej figury chciałbyś obliczyć Przekątną?: ");
                Console.WriteLine("1. Kwadrat/Prostokąt/Trójkąt");
                string wybor2_Przekątna = Console.ReadLine();

                if (wybor2_Przekątna == "1")
                {
                    Console.WriteLine("Podaj a: ");
                    string bok_a = Console.ReadLine();
                    double a = double.Parse(bok_a);

                    Console.WriteLine("Chcesz obliczyć co wyjdzie z tego działania czy zostawić w formie zwykłej?: ");
                    Console.WriteLine("1. Oblicz");
                    Console.WriteLine("2. Zostaw");
                    string wybor = Console.ReadLine();

                    if (wybor == "1")
                    {
                        double wynikOblicz = a * Math.Sqrt(3);
                        Console.WriteLine("Wynik: d = " + wynikOblicz);
                    }
                    else if (wybor == "2")
                    {
                        string wynikZostaw = $"d = {a}(pierwiastek)3";
                        Console.WriteLine("Wynik: " + wynikZostaw);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                    }
                    Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
                    Console.WriteLine("1. Tak");
                    Console.WriteLine("2. Nie");
                    string pytanie = Console.ReadLine();

                    if (pytanie == "1")
                    {
                        Console.Clear();
                        Main();
                    }
                    else if (pytanie == "2")
                    {
                        Console.WriteLine("Dobrze. Wyłączam się...");
                        Thread.Sleep(900);
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                    Thread.Sleep(900);
                    Main();
                }
            }
            else if (wybor1 == "5")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Pola Całkowitego brył.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej bryły chciałbyś obliczyć Pole Całkowite?: ");
                Console.WriteLine("1. Graniastosłup");
                Console.WriteLine("2. Sześcian");
                Console.WriteLine("3. Prostopadłościan");
                Console.WriteLine("4. Ostrosłup");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.Clear();
                        GraniastosłupPoleCałkowite();
                        break;
                    case "2":
                        Console.Clear();
                        SześcianPoleCałkowite();
                        break;
                    case "3":
                        Console.Clear();
                        ProstopadłościanPoleCałkowite();
                        break;
                    case "4":
                        Console.Clear();
                        OstrosłupPoleCałkowite();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                        break;
                }
            }
            else if (wybor1 == "6")
            {
                Console.Clear();
                Console.WriteLine("Ok, wybrałeś obliczanie Objętości brył.\n");
                Thread.Sleep(500);
                Console.WriteLine("A więc jakiej bryły chciałbyś obliczyć Pole Całkowite?: ");
                Console.WriteLine("1. Graniastosłup");
                Console.WriteLine("2. Sześcian");
                Console.WriteLine("3. Prostopadłościan");
                Console.WriteLine("4. Ostrosłup");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.Clear();
                        GraniastosłupObjętość();
                        break;
                    case "2":
                        Console.Clear();
                        SześcianObjętość();
                        break;
                    case "3":
                        Console.Clear();
                        ProstopadłościanObjętość();
                        break;
                    case "4":
                        Console.Clear();
                        OstrosłupObjętość();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                        Thread.Sleep(900);
                        Main();
                        break;
                }
            }
            else if (wybor1 == "7")
            {
                Console.WriteLine("Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wybrałeś złą opcje! Spróbuj jeszcze raz! \n\n");
                Main();
            }
        }

        //Pola
        //Pola
        //Pola

        public static void Kwadrat()
        {
            Console.WriteLine("Podaj bok kwadratu: ");
            string bok1 = Console.ReadLine();
            double bok_kwadratu = double.Parse(bok1);
            double potęga = 2;

            double wynik = Math.Pow(bok_kwadratu, potęga);
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Prostokąt()
        {
            Console.WriteLine("Podaj dłuższy bok prostokąta: ");
            string dł_bok = Console.ReadLine();
            double dłuższy_bok = double.Parse(dł_bok);
            Console.WriteLine("Podaj krótszy bot prostokąta: ");
            string kr_bok = Console.ReadLine();
            double krótszy_bok = double.Parse(kr_bok);

            double wynik = dłuższy_bok * krótszy_bok;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Trójkąt()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj h: ");
            string h = Console.ReadLine();

            double ad = double.Parse(a);
            double hd = double.Parse(h);

            int przez = 2;

            double adhd = ad * hd;
            double wynik = adhd / przez;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Trójkąt_Równoboczny()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();

            double ad = double.Parse(a);
            int przez = 4;

            double PowSqrt = Math.Pow(ad, 2) * Math.Sqrt(3);
            double wynik = PowSqrt / przez;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Trapez()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj h: ");
            string h = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);
            double hd = double.Parse(h);

            int przez = 2;
            double ab = ad + bd;
            double abh = ab * hd;
            double wynik = abh / przez;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Równoległobok()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj h: ");
            string h = Console.ReadLine();

            double ad = double.Parse(a);
            double hd = double.Parse(h);

            double wynik = ad * hd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Deltoid()
        {
            Console.WriteLine("Podaj d1: ");
            string djeden = Console.ReadLine();
            Console.WriteLine("Podaj d2: ");
            string ddwa = Console.ReadLine();

            double d1 = double.Parse(djeden);
            double d2 = double.Parse(ddwa);

            int przez = 2;

            double d1d2 = d1 * d2;
            double wynik = d1d2 / przez;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Romb()
        {
            Console.WriteLine("Które pole rombu chciałbyś obliczyć?: ");
            Console.WriteLine("1. Z przekątnymi.");
            Console.WriteLine("2. Z wysokością i bokiem");
            string wybor = Console.ReadLine();

            if (wybor == "1")
            {
                Console.WriteLine("Podaj e: ");
                string e = Console.ReadLine();
                Console.WriteLine("Podaj f: ");
                string f = Console.ReadLine();

                double ed = double.Parse(e);
                double fd = double.Parse(f);

                int przez = 2;

                double edfd = ed * fd;
                double wynik = edfd / przez;
                Console.WriteLine("Wynik: " + wynik + "");
                Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
                Console.WriteLine("1. Tak");
                Console.WriteLine("2. Nie");
                string pytanie = Console.ReadLine();

                if (pytanie == "1")
                {
                    Console.Clear();
                    Main();
                }
                else if (pytanie == "2")
                {
                    Console.WriteLine("Dobrze. Wyłączam się...");
                    Thread.Sleep(900);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                    Thread.Sleep(900);
                    Main();
                }
            }
            else if (wybor == "2")
            {
                Console.WriteLine("Podaj a: ");
                string a = Console.ReadLine();
                Console.WriteLine("Podaj h: ");
                string h = Console.ReadLine();

                double ad = double.Parse(a);
                double hd = double.Parse(h);

                double wynik = ad * hd;
                Console.WriteLine("Wynik: " + wynik + "");
                Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
                Console.WriteLine("1. Tak");
                Console.WriteLine("2. Nie");
                string pytanie = Console.ReadLine();

                if (pytanie == "1")
                {
                    Console.Clear();
                    Main();
                }
                else if (pytanie == "2")
                {
                    Console.WriteLine("Dobrze. Wyłączam się...");
                    Thread.Sleep(900);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                    Thread.Sleep(900);
                    Main();
                }
            }
        }

        //Obwody
        //Obwody
        //Obwody

        public static void KwadratObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();

            double ad = double.Parse(a);

            double wynik = ad * 4;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void ProstokątObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);

            double wynik = 2 * ad + 2 * bd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void TrójkątObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);
            double cd = double.Parse(c);

            double wynik = ad + bd + cd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void Trójkąt_RównobocznyObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();

            double ad = double.Parse(a);

            double wynik = 3 * ad;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void TrapezObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj c: ");
            string c = Console.ReadLine();
            Console.WriteLine("Podaj d: ");
            string d = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);
            double cd = double.Parse(c);
            double dd = double.Parse(d);

            double wynik = ad + bd + cd + dd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void RównoległobokObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);

            double wynik = 2 * ad + 2 * bd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void DeltoidObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string b = Console.ReadLine();

            double ad = double.Parse(a);
            double bd = double.Parse(b);

            double wynik = 2 * ad + 2 * bd;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void RombObwód()
        {
            Console.WriteLine("Podaj a: ");
            string a = Console.ReadLine();

            double ad = double.Parse(a);

            double wynik = 4 * ad;
            Console.WriteLine("Wynik: " + wynik + "");
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void GraniastosłupPoleCałkowite()
        {
            Console.WriteLine("Podaj Pole Postawy: ");
            string PolePodstawy1 = Console.ReadLine();
            double PolePodstawy2 = double.Parse(PolePodstawy1);
            double PolePodstawy = PolePodstawy2 * 2;

            Console.WriteLine("Podaj Pole Boczne: ");
            string PoleBoczne1 = Console.ReadLine();
            double PoleBoczne = double.Parse(PoleBoczne1);

            double PoleCałkowite = PolePodstawy + PoleBoczne;
            Console.WriteLine("Wynik: Pc = " + PoleCałkowite);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void SześcianPoleCałkowite()
        {
            Console.WriteLine("Podaj a: ");
            string bok_a = Console.ReadLine();
            double a1 = double.Parse(bok_a);
            double a = Math.Pow(a1, 2);

            double PoleCałkowite = 6 * a;
            Console.WriteLine("Wynik: Pc = " + PoleCałkowite);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }
        
        public static void ProstopadłościanPoleCałkowite()
        {
            Console.WriteLine("Podaj a: ");
            string bok_a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string bok_b = Console.ReadLine();
            Console.WriteLine("Podaj c: ");
            string bok_c = Console.ReadLine();

            double a = double.Parse(bok_a);
            double b = double.Parse(bok_b);
            double c = double.Parse(bok_c);

            double ab = a * b;
            double ac = a * c;
            double bc = b * c;

            double dwaab = 2 * ab;
            double dwaac = 2 * ac;
            double dwabc = 2 * bc;

            double PoleCałkowite = dwaab + dwaac + dwabc;
            Console.WriteLine("Wynik: Pc = " + PoleCałkowite);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void OstrosłupPoleCałkowite()
        {
            Console.WriteLine("Podaj Pole Podstawy: ");
            string PolePodstawy1 = Console.ReadLine();
            double PolePodstawy = double.Parse(PolePodstawy1);
            Console.WriteLine("Podaj Pole Boczne: ");
            string PoleBoczne1 = Console.ReadLine();
            double PoleBoczne = double.Parse(PoleBoczne1);

            double PoleCałkowite = PolePodstawy + PoleBoczne;
            Console.WriteLine("Wynik: Pc = " + PoleCałkowite);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void GraniastosłupObjętość()
        {
            Console.WriteLine("Podaj Pole Podstawy: ");
            string PolePodstawy1 = Console.ReadLine();
            double PolePodstawy = double.Parse(PolePodstawy1);
            Console.WriteLine("Podaj Wysokość(H): ");
            string Wysokość1 = Console.ReadLine();
            double Wysokość = double.Parse(Wysokość1);

            double Objętość = PolePodstawy * Wysokość;
            Console.WriteLine("Wynik: V = " + Objętość);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void SześcianObjętość()
        {
            Console.WriteLine("Podaj a: ");
            string bok_a = Console.ReadLine();
            double a = double.Parse(bok_a);


            double Objętość = Math.Pow(a, 3);
            Console.WriteLine("Wynik: V = " + Objętość);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void ProstopadłościanObjętość()
        {
            Console.WriteLine("Podaj a: ");
            string bok_a = Console.ReadLine();
            Console.WriteLine("Podaj b: ");
            string bok_b = Console.ReadLine();
            Console.WriteLine("Podaj c: ");
            string bok_c = Console.ReadLine();

            double a = double.Parse(bok_a);
            double b = double.Parse(bok_b);
            double c = double.Parse(bok_c);

            double abc = a * b * c;
            Console.WriteLine("Wynik: V = " + abc);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }

        public static void OstrosłupObjętość()
        {
            Console.WriteLine("Podaj Pole Podstawy: ");
            string PolePodstawy1 = Console.ReadLine();
            double PolePodstawy = double.Parse(PolePodstawy1);
            Console.WriteLine("Podaj Wysokość(H): ");
            string Wysokość1 = Console.ReadLine();
            double Wysokość = double.Parse(Wysokość1);

            int przez = 3;
            double PolePodstawyWysokość = PolePodstawy * Wysokość;
            double Objętość = PolePodstawyWysokość / przez;
            Console.WriteLine("Wynik: V = " + Objętość);
            Console.WriteLine("Chciałbyś jeszcze coś obliczyć?");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            string pytanie = Console.ReadLine();

            if (pytanie == "1")
            {
                Console.Clear();
                Main();
            }
            else if (pytanie == "2")
            {
                Console.WriteLine("Dobrze. Wyłączam się...");
                Thread.Sleep(900);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wpisałeś złą opcję! Spróbuj jeszcze raz!\n\n");
                Thread.Sleep(900);
                Main();
            }
        }
    }
}
