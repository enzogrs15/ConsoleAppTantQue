namespace ConsoleAppTantQue
{
    class Program
    {
        static void Main(string[] args)
        {
            double prixHT = 1;

            while (prixHT != 0)
            {
                System.Console.WriteLine("Saisir un prix HT : ");
                prixHT = double.Parse(System.Console.ReadLine());

                double tva = prixHT * 0.20;
                double prixTTC = prixHT + tva;

                System.Console.WriteLine("TVA : " + tva);
                System.Console.WriteLine("Prix TTC : " + prixTTC);
            }
        }
    }
}   
