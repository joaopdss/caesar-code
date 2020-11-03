using System;

namespace CodigoCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string  text;
            int option;
            

            Console.WriteLine("If you want encrypt type '1', else type '2'");
            option = int.Parse(Console.ReadLine());
            
            switch (option)
            
            {
                case 1:
                
                break;

                case 2:
                
                break;
                default:
                    Console.WriteLine("Type only 1 or 2");
                    break;
            }
            
            if (option == 1)
            {
                Console.WriteLine("Type some text that you want to encrypt: (E TECLE ENTER)");
                text = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Type some text that you want to decrypt: (E TECLE ENTER)");
                text = Console.ReadLine();
            }

            char [] cripto = new char[text.Length];
               
            
            if (option == 1)
            {
               for (int i = 0; i < text.Length; i++)
                {
                    int ASCII = (int)text[i];

                    int ASCIIfinal = ASCII + 3;

                    cripto[i] = Convert.ToChar(ASCIIfinal);

                } 
            }
            
            else if (option == 2)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int ASCII = (int)text[i];

                    int ASCIIfinal = ASCII - 3;

                    cripto[i] = Convert.ToChar(ASCIIfinal);


                }
            }
            
            Console.WriteLine(cripto);

        }
    }
}
