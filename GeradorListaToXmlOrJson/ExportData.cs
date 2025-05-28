using System.Xml.Serialization;
using Newtonsoft.Json;

namespace GeradorListaToXmlOrJson;
public static class ExportData <T>
{
    public static void SaveData(string file, List<T> data, FileFormat fileFormat)
    {
        if (!File.Exists(file))
        {
            throw new FileNotFoundException("File does not exist.");
        }
        if (data == null)
        {
            Console.WriteLine("Data list is empty.");
            throw new ArgumentNullException("Data list is empty.");    
        }
        else
        {
            if (fileFormat != FileFormat.Xml || fileFormat != FileFormat.Json)
            {
                throw new Exception("Desired file format not found.");
            }
        }
        Export(file, data, fileFormat);
    }
    private static void Export(string file, List<T> data, FileFormat fileFormat)
    {
        if (fileFormat.Equals(FileFormat.Json))
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            try
            {
                using (var fs = new FileStream(file+"\\dados.json", FileMode.Create))
                    using (var sw = new StreamWriter(fs))
                    {
                    sw.WriteLine(json);
                    }
                Console.WriteLine($"File saved in {file}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        else if (fileFormat.Equals(FileFormat.Xml))
        {
            var serialize = new XmlSerializer(typeof(List<T>));

            try
            {
                using (var fs = new FileStream(file + "\\dados.xml", FileMode.Create))
                    using ( var sw = new StreamWriter(fs))
                    {
                    serialize.Serialize(sw, data);
                    }
                Console.WriteLine($"File saved in {file}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public enum FileFormat
    {
        Json = 1,
        Xml = 2,
    };
}
