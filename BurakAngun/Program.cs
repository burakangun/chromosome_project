using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakAngun
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] baba = new int[4];
                int sayac = 0;
                int[] çocuk = new int[4];
                int[] anne = new int[4];
                Console.WriteLine("Hangi gende bir birey istiyorsunuz ? (0 veya 1), 4 adet");
                int A = int.Parse(Console.ReadLine()); int B = int.Parse(Console.ReadLine()); int C = int.Parse(Console.ReadLine()); int D = int.Parse(Console.ReadLine());
                while (true)
                {                      
                    if (!(A == 1) && !(A == 0) || !(B == 1) && !(B == 0) || !(C == 1) && !(C == 0) || !(D == 1) && !(D == 0))
                    {
                        Console.WriteLine("Lütfen geçerli bir gen giriniz !");
                        Console.WriteLine("Hangi gende bir birey istiyorsunuz ? (0 veya 1), 4 adet");
                         A = int.Parse(Console.ReadLine()); B = int.Parse(Console.ReadLine());  C = int.Parse(Console.ReadLine()); D = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                int[] istenen = new int[4] { A, B, C, D };
                Console.Write("İstenen gen : ");
                for(int x = 0;x<anne.Length;x++)
                {
                    Console.Write(istenen[x]);
                }
                Console.WriteLine("\n");                                                             
                Random rnd = new Random();                                                      
                bool a = true;
                
                while(a)
                {
                    sayac = 0;
                    Console.Write("Annenin genleri : ");
                        for (int i = 0; i < anne.Length; i++)
                        {
                            anne[i] = rnd.Next(0, 2);
                            Console.Write(anne[i]);
                        }
                        Console.Write(" Babanın genleri : ");
                        for (int i = 0; i < anne.Length; i++)
                        {
                            baba[i] = rnd.Next(0, 2);
                            Console.Write(baba[i]);
                        }
                        for (int i = 0; i < anne.Length; i++)
                        {
                            if (i < 2)
                            {
                                çocuk[i] = anne[i];
                            }
                            else
                            {
                                çocuk[i] = baba[i];
                            }
                        }
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------");
                        Console.Write("Çarprazlama : ");
                        for (int i = 0; i < anne.Length; i++)
                        {
                            Console.Write(çocuk[i]);
                        }
                        for (int i = 0; i < anne.Length; i++)
                        {
                            int mutasyon = rnd.Next(0, 2);
                            if (mutasyon == 1 && sayac == 0)
                            {
                                if (çocuk[i] == 0)
                                {
                                    çocuk[i]++;
                                    sayac++;
                                }
                                else
                                {
                                    çocuk[i]--;
                                    sayac++;
                                }
                            }
                        }
                        Console.Write(" Mutasyon : ");
                        for (int i = 0; i < anne.Length; i++)
                        {
                            Console.Write(çocuk[i]);
                        }
                        for (int i = 0; i < anne.Length; i++)
                        {
                            if (!(çocuk[i] == istenen[i]))
                            {
                            a = true;
                        Console.WriteLine(" ----> İstenen gen bulunamadı !");
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------");
                        break;
                            }
                            else
                            {   
                            a = false;                          
                            }                                                                                                                           
                        }
                    if(!a)
                    Console.WriteLine(" ----> İstenen gen bulundu !");
                }
           }
        }
    }
}
