using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProject
{
    public class Graph
    {
        public List<int> Boxes;
        public int EmptyPlace {get;set;} //для хранения пустого места
        public List<int> CurrentBoxes { get; set; }

        public Graph(int emptyPlace, List<int> currentBoxes = null)
        {
            EmptyPlace = emptyPlace;
            if (currentBoxes is null)
            {
                CurrentBoxes = new List<int>();
            }
            else
            {
                CurrentBoxes = currentBoxes;
            }
        }

        public void CreateGraph()
        {
            foreach(int box in Boxes)
            {
             if(EmptyPlace >= box)
                {

                }
            }
        }
    }
}

