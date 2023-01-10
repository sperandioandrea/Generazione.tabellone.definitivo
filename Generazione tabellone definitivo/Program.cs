using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generazione_delle_cartelle_definitivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INIZIO CODICE
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI".Length) / 3, 0);
            Console.WriteLine("IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI");
            Console.WriteLine("- ");

            //funzione random
            Random random = new Random();

            //generazione delle due cartelle

            //1 dichiarazione delle due cartelle
            int[,] cartella1 = new int[3, 9];

            //lista che permette di non far rigenerare un numero due volte
            List<int> numeri = new List<int>();

            //generazione 1 cartella
            Console.WriteLine(" CARTELLA PRIMO GIOCATORE ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella1[i, j] = num;
                }
            }

            //ciclo for per test dei valori1 e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //generazione 2 cartella
            Console.WriteLine("- ");
            Console.WriteLine(" CARTELLA SECONDO GIOCATORE ");
            int[,] cartella2 = new int[3, 9];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella2[i, j] = num;
                }
            }

            //ciclo for per test dei valori1 e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella2[i, j] + " ");
                }
                Console.WriteLine();
            }







            //generazione del tabellone del tabellone 

            Console.WriteLine("- ");
            Console.WriteLine("TABELLONE ");
            //dichiarazione tabellone
            int[,] tabellone = new int[9, 10];

            //stampa tabellone
            StampaTabellone(tabellone); //semplificazione del codice con funzione
        }








        //funzione per ottimizzare il codice
        private static void StampaTabellone(int[,] tabellone)
        {
            //generazione tabellone aggiornato
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tabellone[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
