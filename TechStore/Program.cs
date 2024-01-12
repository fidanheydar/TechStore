using System;

namespace TechStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechStore store = new TechStore();
            string opt;

            do
            {
                Console.WriteLine("1. Notebook elave et");
                Console.WriteLine("2. Notebook sat");
                Console.WriteLine("3. Total amounta bax");
                Console.WriteLine("0. Cix");

                Console.Write("Emeliyyat sechin: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        if (double.TryParse(Console.ReadLine(), out double price))
                        {
                            Notebook newNt = new Notebook(name, price);
                            if (store.Find(name) == null)
                            {
                                store.Add(newNt);
                                Console.WriteLine("Notebook elave olundu!");
                            }
                            else
                            {
                                Console.WriteLine("Bu adla notebook artig movcuddur.Elave etmek olmaz!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Duzgun giymet daxil edin!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Notebooklar:");
                        for (int i = 0; i < store.Notebooks.Length; i++)
                        {
                            Console.WriteLine($"{store.Notebooks[i].Name}-{store.Notebooks[i].Price}");
                        }
                        Console.WriteLine("Mehsul adi:");
                        string ntName = Console.ReadLine();
                        Notebook nt = store.Find(ntName);

                        if (nt != null)
                        {
                            store.Sell(nt);
                            Console.WriteLine("Notebook satildi!");
                        }
                        else
                        {
                            Console.WriteLine("Notebook movcud deyil !");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Total amount:");
                        Console.WriteLine(store.TotalAmount);
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("Yanlish sehcim!");
                        break;
                }

            } while (opt != "0");
        }
    }
    }

