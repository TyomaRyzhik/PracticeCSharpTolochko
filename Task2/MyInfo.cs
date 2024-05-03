using System;

public class MyInfo
{
    private string name;
    public delegate void NameChangedDelegate(string oldName, string newName);
    public event NameChangedDelegate NameChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                string oldName = "Даниил";
                name = value;
                NameChanged?.Invoke(oldName, name);
            }
        }
    }
}