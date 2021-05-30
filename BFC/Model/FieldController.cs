using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BFC.Model
{
    public class FieldController
    {
        private Dictionary<string, string> fields;
        private string pathToJsonFields = "data.json";

        public FieldController()
        {
            fields = new Dictionary<string, string>();
        }

        public FieldController(bool sex, double age, double weight, double height)
        {
            fields = new Dictionary<string, string>();
            if (sex)
            {
                fields.Add("sex: ", "1");
            }
            else
            {
                fields.Add("sex: ", "0");
            }
            fields.Add("age: ", Convert.ToString(age));
            fields.Add("weight: ", Convert.ToString(weight));
            fields.Add("height: ", Convert.ToString(height));
        }

        public FieldController(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public FieldController(string pathToJsonFields)
        {
            this.pathToJsonFields = pathToJsonFields;            
        }

        public Dictionary<string, string> ReadFields()
        {
            if (!File.Exists(pathToJsonFields))
            {
                var a = File.Create(pathToJsonFields);
                a.Close();
            }
            string json = File.ReadAllText(pathToJsonFields);
            fields = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return fields;
        }

        public void WriteFields() 
        {
            string json = JsonConvert.SerializeObject(fields);
            File.WriteAllText(pathToJsonFields, json);
        }

        public void SetPath(string path)
        {
            pathToJsonFields = path;
        }

        public string GetPath()
        {
            return pathToJsonFields;
        }

        public void SetField(string name, string value)
        {
            fields[name] = value;
        }

        public void SetCoupleFields(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public void DeleteField(string name)
        {
            fields.Remove(name);
        }

        public Dictionary<string, string> GetFields() 
        {
            return fields;
        }

        public void ClearFields() 
        {
            fields.Clear();                       
        }

    }
}