/*
 * Data access class obtains list from storage.
 * Contains 1 property; an IList of string arrays. 
 * Contains 1 method which accesses a csv file and copies each row 
 * into a string array which is added to the list. 
 * Doesn't access any other part of the application and could change
 * the storage method from CSV to an alternative without requiring 
 * any changes to other parts of the application. 
 */ 
using System;
using System.Collections.Generic;

using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Windows;

namespace ShoppingList.DataLayer
{
    class GetListFromFile
    {
        public IList<string[]> ListFromFile { get; }

        public GetListFromFile(string path)
        {
            ListFromFile = new List<string[]>();
            GetListFromCSV(path);
        }

        private void GetListFromCSV(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (TextFieldParser tfp = new TextFieldParser(path))
                    {
                        tfp.TextFieldType = FieldType.Delimited;
                        tfp.SetDelimiters(",");

                        while (!tfp.EndOfData)
                        {
                            string[] row = tfp.ReadFields();
                            ListFromFile.Add(row);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
