/*
 * Data access class writes list to storage.
 * The constructor takes an IList of string arrays as a parameter. 
 * Contains 1 method which writes each string array in the list as a 
 * CSV row. 
 * Doesn't access any other part of the application and could change
 * the storage method from CSV to an alternative without requiring 
 * any changes to other parts of the application. 
 */
using System.Collections.Generic;

using System.IO;

namespace ShoppingList.DataLayer
{
    class WriteListToFile
    {
        public WriteListToFile(IList<string[]> writeList, string path)
        {
            WriteListToCSV(writeList, path);
        }

        private void WriteListToCSV(IList<string[]> writeList, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string[] rowArray in writeList)
                {
                    string row = null;
                    bool firstColumn = true;

                    foreach (string element in rowArray)
                    {
                        if (!firstColumn) row += ",";
                        row += element;
                        firstColumn = false;
                    }

                    sw.WriteLine(row);
                }

            }          
        }
    }
}
