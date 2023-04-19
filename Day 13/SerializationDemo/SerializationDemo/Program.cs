using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
public class Student
{
    public int roll = 0; public string name;
    [NonSerialized]
    public string pwd;
    public Student(int r, string n, string p)
    {
        roll = r;
        name = n;
        pwd = p;
    }
    public override string ToString()
    {
        return name + "(" + roll + ")" + "pwd: " + pwd;
    }
}
class Ser
{
    static string file = @"D:\.NetUST\Day 13\stud.dat";
    static void Main() { Write(); Read(); }
    static void Write()
    {
        Student s1 = new Student(12292, "Rahul", "alliswell");
        FileStream fs = new FileStream(file, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, s1);
        fs.Close();
    }
    static void Read()
    {
        Student s1 = null;
        FileStream fs = new FileStream(file, FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        s1 = (Student)formatter.Deserialize(fs);
        Console.WriteLine(s1);
        fs.Close();
    }
}