# ListToXmlOrJson ✨  

**A Simple & Elegant .NET Data Export Utility**  

![.NET Version](https://img.shields.io/badge/.NET-6.0+-512BD4?logo=dotnet&logoColor=white)  
[![NuGet Version](https://img.shields.io/nuget/v/ListToXmlOrJson)](https://www.nuget.org/packages/ListToXmlOrJson/)  
![No Dependencies](https://img.shields.io/badge/dependencies-none-success)  

Effortlessly export any `List<T>` to **JSON** or **XML** files with just one line of code! Built with native .NET libraries – no external dependencies.  

---  

## 🚀 Features  

✔ **One-method solution** – Simple and intuitive API  
✔ **Supports any object type** – Fully generic implementation  
✔ **Native .NET serialization** – Uses `System.Text.Json` and `System.Xml.Serialization`  
✔ **Lightweight** – Zero external dependencies  
✔ **Robust error handling** – Validates inputs and throws meaningful exceptions  

---  

## 📦 Installation  

### Via NuGet Package Manager:  
```bash
Install-Package ListToXmlOrJson
```
### Or using .NET CLI:
```bash
dotnet add package ListToXmlOrJson
```

---

## 🛠 Usage

1️⃣ **Define your model**
```csharp
//Example code:
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```
2️⃣ **Prepare your data**
```csharp
//Example code:
var people = new List<Person>
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "Mary", Age = 25 }
};
```
3️⃣ **Export to JSON or XML**
```csharp
//Example code:
using ListToXmlOrJson;

// Export to JSON
ExportData<Person>.SaveData("people", people, ExportData<Person>.FileFormat.Json);

// Export to XML
ExportData<Person>.SaveData("people", people, ExportData<Person>.FileFormat.Xml);
```
This generates:

📄 `people.json`

📄 `people.xml`

---

## 📜 API Reference
`ExportData<T>.SaveData`
```csharp
public static void SaveData(string file, List<T> data, FileFormat fileFormat)
```
| Parameter    | Type         | Description                          |
|--------------|:------------:|--------------------------------------|
| `file`       | `string`     | Output filename (without extension)  |
| `data`       | `List<T>`    | Collection of objects to export      |
| `fileFormat` | `FileFormat` | Export format (`Json` or `Xml`)      |

**Exceptions:**
- ⚠️ ArgumentNullException → If data is null
- ⚠️ Exception → If an unsupported format is provided

---

## ❓ Why Use This?

✔ **No complex setup** – Works out of the box  
✔ **Clean and maintainable** – Single responsibility principle  
✔ **Production-ready** – Proper error handling  
✔ **Lightweight** – No bloat, just pure functionality  

---

## 🌟 Example Output
**JSON (`people.json`)**
```json
[
  {
    "Name": "John",
    "Age": 30
  },
  {
    "Name": "Mary",
    "Age": 25
  }
]
```
**XML (`people.xml`)**
```xml
<ArrayOfPerson>
  <Person>
    <Name>John</Name>
    <Age>30</Age>
  </Person>
  <Person>
    <Name>Mary</Name>
    <Age>25</Age>
  </Person>
</ArrayOfPerson>
```

---

**🌐 Developed by NandoDeveloper**  

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat&logo=github&logoColor=white)](https://github.com/NandoDeveloper)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/fernandoodeveloper/)
