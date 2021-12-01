using System;

namespace zadanieDomowa
{
    class Program
    {
        static void Main(string[] DEV)
        {
            Console.WriteLine("Hello Worlddddd!");
            ConsoleKeyInfo wybrana;

            do
            {

                Console.WriteLine("\n\t\t\tMenu Matematyka Programu");
                Console.WriteLine("A obliczenie pierwiastków równania kwadratowego");
                Console.WriteLine("B obliczenie średniej geometrycznej");
                Console.WriteLine("C obliczenie średniej potęgowej");
                Console.WriteLine("D obliczenie ceny jednostki paszy");
                Console.WriteLine("E obliczenie wartości stałopozycyjne liczby rzeczywistej wczytanej znakowo");
                Console.WriteLine("F obliczenie wartości wielomianu n-tego stopnia");
                Console.WriteLine("G obliczenie średniej kwadratowej");
                Console.WriteLine("H obliczenie średniej harmonicznej");
                Console.WriteLine("I wyznaczenie liczby maksymalnej i minimalnej z wczytywanych liczby ");
                Console.WriteLine("X Zakonczenie programu");
                Console.Write("Nacisniecim klawisza wybierz odpowiedzdnia funkcionalnosc programu: \n");
                wybrana = Console.ReadKey();
                if (wybrana.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n\tA obliczenie pierwiastków równania kwadratowego");
                    float DEVa, DEVb, DEVc, DEVdelta, DEVs1, DEVs2, DEVs3;
                    do
                    {
                        Console.Write("Wprowadż wartość współczynnika a: ");
                        while (!float.TryParse(Console.ReadLine(), out DEVa))
                        {
                            Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                            Console.Write("Wprowadż wartość współczynnika a ponowie: ");
                        }
                        if (DEVa == 0.0F)
                        {
                            Console.WriteLine("\n\tERROR: bląnd w danych wejściową");
                        }

                    } while (DEVa == 0.0F);
                    Console.Write("Wprowadż wartość współczynnika b: ");
                    while (!float.TryParse(Console.ReadLine(), out DEVb))
                    {
                        Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                        Console.Write("Wprowadż wartość współczynnika b ponowie: ");

                    }
                    Console.Write("Wprowadż wartość współczynnika c:");
                    while (!float.TryParse(Console.ReadLine(), out DEVc))
                    {
                        Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                        Console.Write("Wprowadż wartość współczynnika c ponowie: ");
                    }
                    DEVdelta = DEVb * DEVb - 4.0F * DEVa * DEVc;
                    if (DEVdelta > 0)
                    {
                        DEVs1 = (-DEVb - (float)Math.Sqrt(DEVdelta)) / (2 * DEVa);
                        DEVs2 = (-DEVb + (float)Math.Sqrt(DEVdelta)) / (2 * DEVa);
                        Console.WriteLine("\n\tRownanie ma dwa pierwiastki rzeczywiste:");
                        Console.WriteLine("\tX1 = {0, 8:G2} \tX2 = {1, 8:G2} \tDelta = {2, 8:G4}", DEVs1, DEVs2, DEVdelta);
                    }
                    else if (DEVdelta < 0)
                    {
                        Console.WriteLine("\n\tRownanie nie ma pierwiastkow rzeczywistych");
                    }
                    else
                    {
                        DEVs3 = -DEVb / (2 * DEVa);
                        Console.WriteLine("\n\tRownanie ma jeden pierwiastek podwójny: ");
                        Console.WriteLine("\tX1i2 = {0}", DEVs3);
                        Console.WriteLine("\tDelta = {0}", DEVdelta);
                        Console.WriteLine("\tDelta = {0, 9:E4}", DEVdelta);
                    }
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();


                }
                else if (wybrana.Key == ConsoleKey.I)
                {
                    Console.WriteLine("\n\tI wyznaczenie liczby maksymalnej i minimalnej z wczytywanych liczby ");
                    int DEVbuy = 0, Devkuc = 0, n;
                    string licz;
                    Console.Write("Podaj licznosc ciagu liczbowego  n = ");
                    n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write((i + 1) + ".podaj numer=");
                        licz = Console.ReadLine();
                        
                        int myInt;
                        bool isNumerical = int.TryParse(licz, out myInt);
                        if (!isNumerical)
                        {
                            Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                            Console.Write("\n\tWprowadż number ponowie: ");
                            i--;
                        }


                        if (myInt > DEVbuy)
                        {
                            DEVbuy = myInt;
                        }
                        if (myInt < Devkuc)
                        {
                            Devkuc = myInt;
                        }
                        if (i == 0)
                        {
                            Devkuc = myInt;
                            DEVbuy = myInt;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("MAX= " + DEVbuy);
                    Console.WriteLine("MIN= " + Devkuc);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();


                }
                else if (wybrana.Key == ConsoleKey.F)
                {
                    Console.WriteLine("\n\tF obliczenie wartości wielomianu n-tego stopnia");
                    float A;
                    Console.Write("\nWprowadź wartość X, a następnie naciśnij ENTER: ");
                    while (!float.TryParse(Console.ReadLine(), out A))
                    {
                        Console.WriteLine("\n\tError!!! Musisz podać numer!!");
                        Console.Write("\nWprowadź znowu wartość X, a następnie naciśnij ENTER:");
                    }
                    Console.WriteLine("\nWprowadzaj wartosc zmienney");
                    float DEVwspolczyn, dvx;
                    int DEVlicz;
                    string DEVbuff;
                    dvx = 0.0F; DEVlicz = 0;
                    do
                    {

                        Console.Write("\n\tPoday wartosc kolejnogo wspolczynnika");

                        DEVbuff = Console.ReadLine();
                        if (DEVbuff != "")
                        {
                            while (!float.TryParse(DEVbuff, out DEVwspolczyn))
                            {
                                Console.WriteLine("n\tError!!! Musisz podać numer!!!");
                                Console.Write("\nPodaj po nowie wartisc wspolczynnika");
                                DEVbuff = Console.ReadLine();
                            }
                            dvx = dvx * A + DEVwspolczyn;
                            DEVlicz++;
                        }
                    } while (DEVbuff != "");
                    Console.WriteLine("\n\tObliczonna wartosc mielomianu {0, 6:F3}, pry wczytanych {1}", dvx, DEVlicz);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();


                }
                else if (wybrana.Key == ConsoleKey.D)
                {


                    Console.WriteLine("\n\tD obliczenie ceny jednostki paszy");
                    Console.WriteLine("\nWczytanie danych o składnikach paszy");
                    int DEVvknb;
                    float DEVkm, DEVkc, DEVpaszy, DEVsumc, DEVsums;
                    do
                    {
                        Console.Write("\nWprowadz liczby składników paszy: ");
                        while (!int.TryParse(Console.ReadLine(), out DEVvknb))
                        {
                            Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                            Console.Write("Wprowadż wartość współczynnika N ponowie: ");
                        }
                        DEVsumc = 0;
                        DEVsums = 0;
                        if (DEVvknb <= 0)
                        {
                            Console.Write("\n\tN musi być > 0 ");
                        }
                    } while (DEVvknb <= 0);

                    for (int i = 1; i <= DEVvknb; i++)
                    {
                        do
                        {
                            Console.Write("Wprowadz masę {0} - go składnika jednostce paszy: ", i);
                            while (!float.TryParse(Console.ReadLine(), out DEVkm))
                            {
                                Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wrowadż wartość współczynnika m ponowie: ");
                            }
                            if (DEVkm <= 0)
                            {
                                Console.WriteLine("\n\tMasa musi być > 0");
                            }
                        } while (DEVkm <= 0);

                        do
                        {
                            Console.Write("Wprowadz cenę {0} - go składnika  paszy: ", i);
                            while (!float.TryParse(Console.ReadLine(), out DEVkc))
                            {
                                Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wprowadż wartość współczynnika c ponowie: ");
                            }
                            if (DEVkc <= 0)
                            {
                                Console.WriteLine("\n\tCena musi być > 0");
                            }
                        } while (DEVkc <= 0);

                        DEVsumc += DEVkm * DEVkc;
                        DEVsums += DEVkm;
                    }
                    DEVpaszy = DEVsumc / DEVsums;
                    Console.WriteLine("\n\tCena jodnostki paszy " + DEVpaszy);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();
                }
                else if (wybrana.Key == ConsoleKey.H)
                {
                    Console.WriteLine("\n\tH obliczenie średniej harmonicznej");
                    float DEVa, DEVasum, DEVshar;
                    int DEVnar, DEVnul;

                    DEVasum = 0.0F;
                    DEVnar = 0;
                    DEVnul = 0;
                    string DEVKlawiatura;
                    do
                    {
                        Console.Write("Podaj wartość {0} współczynnika a : ", (DEVnar + 1));
                        DEVKlawiatura = Console.ReadLine();
                        if (DEVKlawiatura != "")
                        {
                            while (!float.TryParse(DEVKlawiatura, out DEVa))
                            {
                                Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wprowadż wartość {0} współczynnika a ponowie: ", (DEVnar + 1));
                                DEVKlawiatura = Console.ReadLine();
                            }
                            if (DEVa != 0.0F)
                            {
                                DEVnar++;
                                DEVasum += 1 / DEVa;
                            }
                            else
                            {
                                DEVnul++;
                            }
                        }
                    } while (DEVKlawiatura != "");
                    DEVshar = DEVnar / DEVasum;
                    Console.WriteLine("\n\tW danym zadanju było {0} liczb = 0", DEVnul);
                    Console.WriteLine("\n\tŚrednia harmiczna {0} liczb jest {1, 6:F2}", DEVnar, DEVshar);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();
                }
                else if (wybrana.Key == ConsoleKey.B)
                {
                    Console.WriteLine("\n\tB obliczenie średniej geometrycznej");
                    float DEVka, DEVlloczyn, DEVgeom;
                    int DEVA = 0, DEVnula = 0;
                    string DEVKlawiatura;
                    DEVlloczyn = 1.0F;
                    do
                    {
                        Console.Write("Podaj wartość {0} współczynnika a : ", DEVA + 1);
                        DEVKlawiatura = Console.ReadLine();
                        if (DEVKlawiatura != "")
                        {
                            while (!float.TryParse(DEVKlawiatura, out DEVka))
                            {
                                Console.WriteLine("\n\tError: wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wprowadż wartość {0} współczynnika a ponowie: ", DEVA + 1);
                                DEVKlawiatura = Console.ReadLine();
                            }
                            if (DEVka != 0.0f)
                            {
                                DEVlloczyn *= DEVka;
                                DEVA++;
                            }
                            else
                            {
                                DEVnula++;
                            }
                        }
                    } while (DEVKlawiatura != "");
                    DEVgeom = (float)(Math.Pow(DEVlloczyn, 1.0 / DEVA));
                    Console.WriteLine("\n\tW danym zadanju było {0} liczb = 0", DEVnula);
                    Console.WriteLine("\n\tŚrednia geometryczna {0} liczb jest {1, 6:F2}", DEVA, DEVgeom);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    wybrana = Console.ReadKey();
                }
                else if (wybrana.Key == ConsoleKey.G)
                {
                    Console.WriteLine("\n\tG obliczenie średniej kwadratowej");
                    float DEVa, DEVb, DEVwad;
                    int DEVn;
                    DEVb = 0.0F;
                    DEVn = 0;
                    string DEVklawiatura;
                    do
                    {
                        Console.Write("Podaj wartość {0} współczynnika a : ", (DEVn + 1));
                        DEVklawiatura = Console.ReadLine();
                        if (DEVklawiatura != "")
                        {
                            while (!float.TryParse(DEVklawiatura, out DEVa))
                            {
                                Console.WriteLine("\n\tERROR: wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wprowadż wartość współczynnika a ponowie: ");
                                DEVklawiatura = Console.ReadLine();
                            }
                            DEVn++;
                            DEVb += DEVa * DEVa;
                        }
                    } while (DEVklawiatura != "");

                    DEVwad = ((float)Math.Sqrt(DEVb / DEVn));
                    Console.WriteLine("\n\tŚrednia kwadratowa {0} liczb jest {1, 6:F2}", DEVn, DEVwad);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();
                }
                else if (wybrana.Key == ConsoleKey.C)
                {
                    Console.WriteLine("\n\tC obliczenie średniej potęgowej");
                    float DEVa, DEVum, DEVrz, DEVK, DEVsr;
                    int DEVn;
                    DEVn = 0;
                    DEVK = 1.0F;
                    DEVum = 0.0F;
                    Console.Write("\n\tPodaj wartość rządu: ");
                    while (!float.TryParse(Console.ReadLine(), out DEVrz))
                    {
                        Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                        Console.Write("Wprowadż wartość rządu ponowie: ");
                        Console.ReadKey();
                    }

                    string DEVklawiatura;
                    do
                    {
                        Console.Write("Podaj wartość {0} współczynnika a : ", (DEVn + 1));
                        DEVklawiatura = Console.ReadLine();
                        if (DEVklawiatura != "")
                        {
                            while (!float.TryParse(DEVklawiatura, out DEVa))
                            {
                                Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                                Console.Write("Wprowadż wartość współczynnika a ponowie: ");
                                Console.ReadKey();
                            }
                            DEVn++;
                            DEVK = (float)Math.Pow(DEVa, DEVrz);
                            DEVum += DEVK;
                        }
                    } while (DEVklawiatura != "");

                    DEVsr = (float)Math.Pow((DEVum / DEVn), 1.0 / DEVrz);
                    Console.WriteLine("\n\tŚrednia potęngowa {0} liczb, {1} rzęndu, jest {2, 6:F2}", DEVklawiatura, DEVrz, DEVsr);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");
                    Console.ReadKey();

                }


                else if (wybrana.Key == ConsoleKey.E)
                {
                    Console.WriteLine("\n\tE obliczenie wartości stałopozycyjne liczby rzeczywistej wczytanej znakowo");
                    float DEVnumber;
                    Console.Write("Wprowadż liczbe dziesiętną: ");
                    while (!float.TryParse(Console.ReadLine(), out DEVnumber))
                    {
                        Console.WriteLine("\n\tERROR wystąpił niedozwolony znak w zapisie podanej liczby");
                        Console.Write("Wprowadż number ponowie: ");
                    }

                    float DEV_number = DEVnumber % 1;
                    int DEVmain_number = (int)DEVnumber - (int)DEV_number;


                    String DEVmain_bin = Convert.ToString(DEVmain_number, 2);
                    int DEVk = 6;
                    String DEVest_bin = "";
                    for (int i = 0; i < DEVk; i++)
                    {
                        DEV_number = DEV_number * 2;
                        if (DEV_number >= 1)
                        {
                            DEVest_bin = DEVest_bin + "1";
                            DEV_number = DEV_number - 1;
                        }
                        else
                        {
                            DEVest_bin = DEVest_bin + "0";
                        }
                    }
                    string op = DEVmain_bin + '.' + DEVest_bin;
                    Console.WriteLine("\n\tLiczba binarna jest {0} ", op);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz dla kontynuacji działania programu...");

                    Console.ReadKey();

                }
                else if (wybrana.Key != ConsoleKey.X)
                {

                    Console.WriteLine("\n\tERROR !!!!");
                    Console.Write("Dokonaj wyboru funkcjonalnosci programu jeszcze raz");
                }
            } while (wybrana.Key != ConsoleKey.X);
            Console.WriteLine("\n\t Semih Burhan Sunar, Nr albumu: 59960 ---");
            Console.WriteLine("\n\t Pan profesor jestem Turczynką , mam problem z językiem , Mogę się tak mylić , przepraszam");


            Console.WriteLine("\n\tAktualna data i godzina: {0}", DateTime.Now);
            Console.ReadKey();
        }

    }
}

