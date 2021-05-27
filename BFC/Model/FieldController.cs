using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BFC.Model.FieldSaver
{
    public class FieldController
    {
        private Dictionary<string, string> fields = null;
        private string pathToJsonFields = "data.json";

        public FieldController()
        {
        }

        public FieldController(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public FieldController(string pathToJsonFields)
        {
            this.pathToJsonFields = pathToJsonFields;            
        }

        public void ReadFields()
        {
            string json = File.ReadAllText(pathToJsonFields);
            fields = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
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