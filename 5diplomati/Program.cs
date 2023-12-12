using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5diplomati
{
    internal class Program
    {
        public class diplomati
        {
            public string _nome;
            public string _cognome;
            public int _voto;
            public diplomati(string nome, string cognome, int voto)
            {
                _nome = nome;
                _cognome = cognome;
                _voto = voto;
            }
            public diplomati() { }
            public void Inserisci(diplomati[] d, int numero)
            {
                Console.Clear();

                for (int i = 0; i < numero; i++)
                {
                    int voto;

                    Console.WriteLine("Inserisci il nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome");
                    string cognome = Console.ReadLine();
                    Console.WriteLine("Inserisci il voto");
                    voto = Convert.ToInt32(Console.ReadLine());

                    if(voto<=36 && voto>=100)
                    {
                        Console.WriteLine("Voto non valido inserisci un voto compreso tra 36 e 100");
                        Console.WriteLine("Inserisci il voto corretto:");
                         voto = Convert.ToInt32(Console.ReadLine());
                    }

                    d[i] = new diplomati(nome, cognome, voto);

                }
            }
            public void StampaTutto(diplomati[] d, int numero)
            {
                Console.Clear();

                for (int i = 0; i < numero; i++)
                {
                    if (d[i]._voto >= 36 && d[i]._voto <= 60)
                    {
                        Console.WriteLine("Vecchio diplomato");

                        Console.WriteLine("Nome: " + d[i]._nome);

                        Console.WriteLine("Cognome: " + d[i]._cognome);

                        Console.WriteLine("Voto: " + d[i]._voto);
                    }
                    else
                    {
                        Console.WriteLine("Nuovo diplomato");

                        Console.WriteLine("Nome: " + d[i]._nome);

                        Console.WriteLine("Cognome: " + d[i]._cognome);

                        Console.WriteLine("Voto: " + d[i]._voto);
                    }

                }
            }

            public void StampaAbili(diplomati[] d, int numero)
            {
                Console.Clear();

                for (int i = 0; i < numero; i++)
                {
                    if (d[i]._voto >= 36 && d[i]._voto <= 60)
                    {
                        if(d[i]._voto >= 42)
                        {
                            Console.WriteLine("Vecchio diplomato abile");

                            Console.WriteLine("Nome: " + d[i]._nome);

                            Console.WriteLine("Cognome: " + d[i]._cognome);

                            Console.WriteLine("Voto: " + d[i]._voto);
                        }
                        
                    }
                    else
                    {
                        if (d[i]._voto >= 60 && d[i]._voto <= 100)
                        {
                            if (d[i]._voto >= 70)
                            {
                                Console.WriteLine("Nuovo diplomato abile");

                                Console.WriteLine("Nome: " + d[i]._nome);

                                Console.WriteLine("Cognome: " + d[i]._cognome);

                                Console.WriteLine("Voto: " + d[i]._voto);
                            }
                        }
                    }
                }
            }
        }
       
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quanti diplomati vuoi inserire");
            int numero=int.Parse(Console.ReadLine());

            diplomati[] d = new diplomati[numero];
            diplomati dip = new diplomati();

            dip.Inserisci(d, numero);
            dip.StampaTutto(d, numero);
            dip.StampaAbili(d, numero);

            Console.ReadLine();
        }
       
    }
}
