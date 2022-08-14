using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; } =  0;
        
        public override void Play()
        {
            Console.WriteLine("Playing VHS");
            Console.WriteLine(Scenes[CurrentScene]);
            CurrentScene++;
        }

        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}