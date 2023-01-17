// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using UnicodeData;

Console.WriteLine("XML Stuff");

//"C:\Users\18275\source\repos\UnicodeGeek\Data\SerializeTest1.xml"
XmlSerializer xmlSerializer = new XmlSerializer(typeof(UcdObj));

using (StreamReader xmlReader = new StreamReader(@"C:\Users\18275\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml"))
{
    UcdObj thing = (UcdObj)xmlSerializer.Deserialize(xmlReader);

    var thing1 = thing;
}
