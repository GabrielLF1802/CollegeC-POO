namespace PooCollege;

public class Contact
{
    public string name { get; set; }
    public string phoneNumber { get; set; }
    public string phoneType { get; set; }

    public Contact(string name, string phoneNumber, string phoneType)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.phoneType = phoneType;
    }
}
