using BFC.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BFC.Model
{
    public class Initializer
    {
        public string SQLScript = "";

        public string ReadScript()
        {
            string path = "Script.sql";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    SQLScript = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SQLScript;
        }
 
    }
}
