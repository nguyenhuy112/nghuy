public abstract class Person
{
    private string _name;
    private string _id;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
}
public interface Kpi
{
    float kpi();
}
public class Student : Person, Kpi
{
    private string _department;
    private float _gpa;

    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
                _department = value;
            else
                throw new Exception("Department must be either 'ICT' or 'ECO'.");
        }
    }

    public float kpi()
    {
        return _gpa;
    }

    public Student(string name, string id, string department, float gpa)
    {
        if (id.Length != 8 || !int.TryParse(id, out _))
            throw new Exception("Invalid student ID. ID must be 8 digits.");
        Name = name;
        Id = id;
        Department = department;
        _gpa = gpa;
    }
   

 
}
Person obs = null;
obs = new Student("Nguyễn Tiến Dũng", "12345678", "ICT", 8.5f);
Console.WriteLine($"KPI: {obs.kpi()}");
try
{
    obs = new Student("Nguyễn Tiến Dũng", "123456789", "ECO", 8.5f); // invalid ID
    // obs = new Student("Nguyễn Tiến Dũng", "12345678", "CSC", 8.5f); // invalid department
    Console.WriteLine($"KPI: {obs.kpi()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
List<Person> list1 = new List<Person>();
List<Person> list2 = new List<Person>();
Console.WriteLine("Enter list1 (end with '#'):");
while (true)
{
    string name = Console.ReadLine();
    if (name == "#")
        break;
    string id = Console.ReadLine();
    string department = Console.ReadLine();
    float gpa = float.Parse(Console.ReadLine());
    list1.Add(new Student(name, id, department, gpa));
}

Console.WriteLine("Enter list2 (end with '#'):");
while (true)
{
    string name = Console.ReadLine();
    if (name == "#")
        break;
    string id = Console.ReadLine();
    string department = Console.ReadLine();
    float gpa = float.Parse(Console.ReadLine());
    list2.Add(new Student(name, id, department, gpa));
}


Console.WriteLine("list1:");
foreach (var student in list1)
    Console.WriteLine($"{student.Name} - {student.Id} - {((Student)student).Department} - {((Student)student).kpi()}");



Console.WriteLine("list2:");
foreach (var student in list2)
    Console.WriteLine($"{student.Name} - {student.Id} - {((Student)student).Department} - {((Student)student).kpi()}");


List<List<Person>> list_list = new List<List<Person>>();
list_list.Add(list1);
list_list.Add(list2);

Console.WriteLine("list_list:");
foreach (var list in list_list)
{
    foreach (var student in list)
        Console.WriteLine($"{student.Name} - {student.Id} - {((Student)student).Department} - {((Student)student).kpi()}");
    Console.WriteLine();
}
Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
foreach (var student in list1)
{
    dic11[student.Id] = (Student)student;
}

bool found = false;
foreach (var kvp in dic11)
{
    if (kvp.Value.Name.Contains("Nam"))
    {
        Console.WriteLine($"{kvp.Value.Name} - {kvp.Value.Id} - {kvp.Value.Department} - {kvp.Value.kpi()}");
        found = true;
    }
}

if (!found)
    Console.WriteLine("No student named 'Nam' found in list1.");