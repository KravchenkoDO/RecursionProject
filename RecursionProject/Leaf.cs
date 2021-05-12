using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProject
{
    class Leaf
    {
        public List<Film> Films;
        public int FreeTime { get; set; }
        public List<Leaf> CurrentLeaf { get; set; }

        public Leaf(int time, List<Film> pathToFilm)
        {
            FreeTime = time;
            Films = pathToFilm;
            CurrentLeaf = new List<Leaf>();
        }

        public void AddNextLeaf(Leaf leaf)
        {
            CurrentLeaf.Add(leaf);
        }
    }
}
