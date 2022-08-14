using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBuster
{
    public class DVD : Movie
    {
        public override void Play()
        {
            Console.Write("What scene would you like to watch? ");
            string userInput = Console.ReadLine();
            Console.Clear();

            if (int.TryParse(userInput, out int scene))
            {
                Console.WriteLine(Scenes[scene]);
            }
        }
    }
}