using System;

using System.IO;
using System.Windows;

namespace ShoppingList.DataLayer
{
    static class DeleteFile
    {

        public static void Delete(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
