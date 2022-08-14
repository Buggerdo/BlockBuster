using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBuster
{
    public abstract class Movie
    {
        public string Title { get; set; }

        public Genre Category { get; set; }
        
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }
        
        //Prints the movie info
        public void PrintInfo()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Category: {0}", Category);
            Console.WriteLine("RunTime: {0}", RunTime);
            Console.WriteLine("Scenes: {0}", Scenes);
        }

        //Plays the current movie scenes
        public void PlayScenes()
        {
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        public abstract void Play();
    }
}