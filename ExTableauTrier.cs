using System;

namespace lazaarex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t ;
            Console.WriteLine("Entrer le nombre la taille du tableau :");
            
            t = int.Parse(Console.ReadLine());
            int[] tab = new int[t];
            Console.WriteLine("entrer les elements du tableau :");
            for (int i = 0; i < tab.Length; ++i)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter un nombre : ");
            Array.Resize<int>(ref tab, tab.Length + 1);
            int val = int.Parse(Console.ReadLine());

            int j;
            if (tab[0] < val)
            {
            for(j=tab.Length-1; tab[j - 1] > val; j--) {
                tab[j] = tab[j - 1];
            }
            tab[j] = val;
            }
            else
            {
                for (j = tab.Length - 1; j > 0; j--)
                {
                    tab[j] = tab[j - 1];
                }
                tab[0] = val;
            }

            Console.WriteLine("tableau apres insertion");

            for (int k = 0; k < tab.Length; k++)
            {
                Console.Write(tab[k] + "\t");
            }
        }
    }
}
