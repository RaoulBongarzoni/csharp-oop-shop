namespace csharp_oop_shop
{


    internal class Prodotto
    {

        Random rnd = new Random();  

        //codice generato random
        public int Code {  get; private set; }

        //informazioni del prodotto
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Iva = 22.5m ;


        //metodi 
        public decimal fullPrice { get { return getFullPrice(); } }
        public string nameCode { get { return getNameCode(); } }

        //costruttore 
        public Prodotto(string nameDefault = "name", string descriptionDefault ="default description", decimal priceDefault = 12.99m )
        {
            Code = getCode();
            Name = nameDefault;
            Description = descriptionDefault;
            Price = priceDefault;
        }

        
        
        //funzione che restituisce prezzo + iva
        private decimal getFullPrice()
        {
            return Math.Round(Price + ( (Price * Iva) / 100  ), 2);
        }


        //funzione che restituisce nome + codice
        private string getNameCode()
        {
            string output = Name + Convert.ToString(Code);
            return output;
        }

        //generatore di codice random
        private int getCode()
        {
            Random rnd = new Random();
            string numToString = Convert.ToString(rnd.Next(0, 10000000));
           // string output = numToString.PadLeft(8, '0'); //cerco un'altra soluzione questa crea problemi con l'ambiguità tra 0 e null


            
            return Convert.ToInt32(numToString);
        }



    }




    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i<3; i++)
            {

            
                Prodotto newProdotto = new Prodotto();
                newProdotto.Name = Convert.ToString(i) + "Prodotto";
                Console.WriteLine($"codice prodotto:{newProdotto.Code} ");
                Console.WriteLine($"nome prodotto:{newProdotto.Name}  ");
                Console.WriteLine($"Codice e nome:{newProdotto.nameCode}");
                Console.WriteLine($"Prezzo:{newProdotto.Price}");
                Console.WriteLine($"Piu Iva:{newProdotto.fullPrice}\n");

            }

        }
    }
}
