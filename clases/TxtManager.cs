using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto
{
    class TxtManager
    {
        private static TxtManager mytminstance;
        string path = @"C:\Users\monap\Desktop\archivolog.txt";

        private TxtManager()
        {

        }

        public static TxtManager GetMyInstance()
        {
            if (mytminstance == null)
            {
                mytminstance = new TxtManager();
            }
            return mytminstance;
        }

        public void OpenFile()
        {

        }

        public void CloseFile()
        {
        }

        public void WriteInFile(string message)
        {
            StreamWriter stream = File.AppendText(path);
            stream.WriteLine(message);
            stream.Close();
        }



        // Método para crear directorio 
        private void CrearDirectorio()
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

            }
            catch (DirectoryNotFoundException ex)
            {
                throw new System.Exception(ex.Message);

            }

        }


        public string[] ReadFromFile()
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

    }
}
