using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlData = @"<Students>
  <Student>
    <RegNo>101</RegNo>
    <Name>John Doe</Name>
    <Age>20</Age>
    <Class>12th Grade</Class>
    <Email>john@example.com</Email>
  </Student>
  <Student>
    <RegNo>102</RegNo>
    <Name>Jane Smith</Name>
    <Age>19</Age>
    <Class>11th Grade</Class>
    <Email>jane@example.com</Email>
  </Student>
</Students>";

        // Load XML from string (you can also load from file with XmlDocument.Load("file.xml"))
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlData);

        XmlNodeList students = doc.SelectNodes("/Students/Student");

        Console.WriteLine("=== Student Details ===");

        foreach (XmlNode student in students)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Reg No : {student["RegNo"].InnerText}");
            Console.WriteLine($"Name   : {student["Name"].InnerText}");
            Console.WriteLine($"Age    : {student["Age"].InnerText}");
            Console.WriteLine($"Class  : {student["Class"].InnerText}");
            Console.WriteLine($"Email  : {student["Email"].InnerText}");
        }

        Console.WriteLine("----------------------------");
    }
}
