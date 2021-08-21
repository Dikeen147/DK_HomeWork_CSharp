using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace W8_T3_BelieveOrNotBelieve
{
    class TrueFalse
    {
        private string fileName;
        private List<Question> list;

        public string FileName { set => fileName = value; }
        public Question this[int index] => list[index];
        public int Count => list.Count;

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        public void SaveXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void SaveJson()
        {
            var jsonFormat = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            File.WriteAllText(fileName, jsonFormat);
        }
        public void LoadXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public void LoadJson()
        {
            var file = File.ReadAllText(fileName);
            list =  Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(file);
        }
    }
}
