# Generic List Serializer DLL

## Features
✔ **Generic List Support** – Works with any type of object in a `List<T>`.  
✔ **XML Serialization** – Converts objects into well-formatted XML.  
✔ **JSON Serialization** – Generates JSON strings from objects.  
✔ **Easy Integration** – Simply reference the DLL in your project.

## How to Use
### 1. Adding the DLL to Your Project
Reference the `GenericListSerializer.dll` in your project. Import the namespace:
```csharp
using GenericListSerializer;
```
### 2. Ensure your class is serializable
```csharp
[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```
### 2. Serializing a List to XML
```csharp
List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob", Age = 25 }
};

//Params: file name, list and file format (JSON = 1; XML = 2)
ExportData.SaveData("people", people, 2);
```
### 3. Serializing a List to JSON
```csharp

//Params: file name, list and file format (JSON = 1; XML = 2)
ExportData.SaveData("people", people, 1);
```
## File Location
**The serialized files will be generated in your solution's output folder, typically following this path structure:**

`C:\YourSolutionName\YourProjectName\bin\Debug\net6.0\yourfilename.json`

`C:\YourSolutionName\YourProjectName\bin\Debug\net6.0\yourfilename.xml`
#
*1. Navigate to your project's folder*

*2. Go to `bin > Debug > net6.0`*

*3. Look for your generated JSON/XML files*

## Requirements
✔ **.NET Framework 4.7.2+ or .NET Core 3.1+**

✔ **System.Text.Json (for JSON serialization)**

✔ **System.Xml.Serialization (for XML serialization)**

---

**🚀 Developed by NandoDeveloper**  
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat&logo=github&logoColor=white)](https://github.com/NandoDeveloper)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/fernandoodeveloper/)
