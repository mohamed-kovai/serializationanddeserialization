using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace serializationanddeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
         //serialization.
            writeXml();
        }

        public static void writeXml()
        {

            Employee emp = new Employee();
            emp.Id = 1001;
            emp.Name = "Charle";
            emp.JobRole = "RD Engeener";
            XmlSerializer m = new XmlSerializer(typeof(Employee));
            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            string filePath = @"D:\DotNet\console\serializationanddeserialization\xml\xml1.xml";
            FileStream file = File.Create(filePath);

            m.Serialize(file,emp);
            file.Close();

        }
    }

    public class Employee
    {
        public int Id;
        public string Name;
        public string JobRole;

       
    }
}
