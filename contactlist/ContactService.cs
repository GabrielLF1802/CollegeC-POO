namespace PooCollege;

public class ContactService
{
    private readonly ContactList contactList = new();

    public Contact CreateContact(string name, string phoneNumber, string phoneType)
    {
        var newContact = new Contact(name, phoneNumber, phoneType);
        AddNewContact(newContact);

        return newContact;
    }

    public int CountContacts()
    {
        return contactList.contacts.Count;
    }

    public List<string> ListContacts()
    {
        return contactList.contacts
            .Select(contact => $"{contact.name} | {contact.phoneNumber} | {contact.phoneType}")
            .ToList();
    }

    public void AddNewContact(Contact contact)
    {
        contactList.contacts.Add(contact);
    }
}
