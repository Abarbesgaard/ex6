using System.Security.Cryptography.X509Certificates;

namespace AldersGennemsnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Øvelse 3.1
            int emreAlder = 28;
            int justinAlder = 31;
            int andreasAlder = 33;
            double gennemsnitsAlder = 0;
            Console.WriteLine(emreAlder);
            Console.WriteLine(justinAlder);
            Console.WriteLine(andreasAlder);

            gennemsnitsAlder = (emreAlder + justinAlder + andreasAlder)/3;
            Console.WriteLine(gennemsnitsAlder);
            */
            /* Øvelse 3.2: Alderen på alle i gruppen, samt aldersgennemsnit (med array) 
            int gennemsnitsAlder = 0;
            int[] alder = new int[4];

            alder[0] = 28;
            alder[1] = 31;
            alder[2] = 33;
            alder[3] = 43;

            for (int i = 0;i < alder.Length; i++) 
            {
                gennemsnitsAlder  += alder[i];
                Console.WriteLine(alder[i]);
            }
            Console.WriteLine(gennemsnitsAlder / array.Length);
            */

            /* Øvelse 3.3: Findes der en med alderen
            string name = " ";
            int[] alder = new int[4] {28,31,33,43};

            Console.WriteLine("What age are you looking for? ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < alder.Length; i++)
            {
                Console.WriteLine(alder[i]);

                if (alder[i] == userInput)
                {
                    name = "sovs";
                }



            }
            Console.WriteLine(name);
            */
            
            
            
            int x = 0;
            int y = 0;
            Console.WriteLine("hvor mange er i gruppen?: ");
            x = int.Parse(Console.ReadLine());
            
            int[] alder = new int[x];

            for (int i = 0;i < alder.Length; i++)             
            {
                Console.WriteLine("hvad er gruppemedlemmets alder?: ");
                y = int.Parse(Console.ReadLine());
                alder[i] = y;

            }
            for (int i = 0; i < alder.Length; i++)
            {
                Console.WriteLine("gruppemedlemmets alder er: " + alder[i]);

            }


            Console.ReadLine();
}
}
}