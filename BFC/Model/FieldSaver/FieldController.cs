using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.JsonConvert;

namespace BFC.Model.FieldSaver
{
    public class FieldController
    {
        private Dictionary<string, string> fields = null;
        private string pathToJsonFields = "";

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

        public void readFields()
        {
            string json = File.ReadAllText(pathToJsonFields);
            this.fields = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public void writeFields() 
        {
            string json = JsonConvert.SerializeObject(this.fields);
            File.WriteAllText(pathToJsonFields, json);
        }

        public void setPath(string path)
        {
            this.pathToJsonFields = path;
        }

        public string getPath()
        {
            return this.pathToJsonFields;
        }

        public void setField(string name, string value)
        {
            this.fields[name] = value;
        }

        public void setCoupleFields(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public void deleteField(string name)
        {
            this.fields.Remove(name);
        }

        public Dictionary<string, string> getFields() 
        {
            return fields;
        }

        public void clearFields() 
        {
            this.fields.Clear();                       
        }

    }
}