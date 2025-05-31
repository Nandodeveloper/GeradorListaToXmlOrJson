using System.Xml.Serialization;
using System.Text.Json;

namespace ListToXmlOrJson;

/// <summary>
/// Utility class for exporting lists of objects to JSON or XML format.
/// </summary>
/// <typeparam name="T">Type of the objects contained in the list to be exported.</typeparam>
public static class ExportData<T>
{
    /// <summary>
    /// Saves a list of objects to a file in the specified format (JSON or XML).
    /// </summary>
    /// <param name="file">Base name of the output file (without extension).</param>
    /// <param name="data">List of objects to be exported.</param>
    /// <param name="fileFormat">Output file format (<see cref="FileFormat.Json"/> or <see cref="FileFormat.Xml"/>).</param>
    /// <exception cref="ArgumentNullException">Thrown if the data list is null.</exception>
    /// <exception cref="Exception">Thrown if the desired file format is not supported.</exception>
    /// <remarks>
    /// The file will be saved in the current directory with the corresponding extension (.json or .xml).
    /// </remarks>
    public static void SaveData(string file, List<T> data, FileFormat fileFormat)
    {
        if (data == null)
        {
            Console.WriteLine("Data list is empty.");
            throw new ArgumentNullException("Data list is empty.");
        }
        else
        {
            if (fileFormat != FileFormat.Xml && fileFormat != FileFormat.Json)
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
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });

            try
            {
                using (var fs = new FileStream(file + ".json", FileMode.Create))
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(json);
                }
                Console.WriteLine($"File saved.");
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
                using (var fs = new FileStream(file + ".xml", FileMode.Create))
                using (var sw = new StreamWriter(fs))
                {
                    serialize.Serialize(sw, data);
                }
                Console.WriteLine($"File saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    /// <summary>
    /// Enumeration of supported file formats for export.
    /// </summary>
    public enum FileFormat
    {
        /// <summary>
        /// JSON format.
        /// </summary>
        Json = 1,
        /// <summary>
        /// XML format.
        /// </summary>
        Xml = 2
    };
}
