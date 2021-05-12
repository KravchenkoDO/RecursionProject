using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProject
{
    public class FirstStep
    {
        public static void CombinationOfElements(int numberOfFreeShelves, List<string> listOfBooks, List<string> currentNodeBooks = null)
        {
            if (currentNodeBooks is null)
            {
                currentNodeBooks = new List<string>();
            }

            if (currentNodeBooks.Count == numberOfFreeShelves)
            {
                foreach (string element in currentNodeBooks)
                {
                    Console.Write("{0} ", element);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (string book in listOfBooks)
                {
                    List<string> tempList= new List<string>(currentNodeBooks);
                    tempList.Add(book);
                    CombinationOfElements(numberOfFreeShelves, listOfBooks, tempList);
                }
            }
        }
    }
}
