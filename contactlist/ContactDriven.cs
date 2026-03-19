namespace PooCollege;

public class ContactDriven
{
    private readonly ContactService contactService;

    public ContactDriven()
    {
        contactService = new ContactService();
    }

    public void Run()
    {
        string name = "Gabriel";
        string phoneNumber = "1321312321";
        string phoneType = "mobile";

        Contact createdContact = contactService.CreateContact(name, phoneNumber, phoneType);

        Console.WriteLine($"Contato criado com sucesso: {createdContact.name} | {createdContact.phoneNumber} | {createdContact.phoneType}");

        AddContactInLisst();
        CountContactsFromList();
        ListContactsFromLIst();
    }

    public void CountContactsFromList()
    {
        int totalContacts = contactService.CountContacts();
        Console.WriteLine($"Total de contatos: {totalContacts}");
    }

    public void ListContactsFromLIst()
    {
        List<string> contacts = contactService.ListContacts();

        Console.WriteLine("Lista de contatos:");

        foreach (string contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }

    public void AddContactInLisst()
    {
        Contact maria = contactService.CreateContact("Maria", "11999999999", "home");
        Contact joao = contactService.CreateContact("Joao", "11888888888", "work");

        Console.WriteLine($"Contato criado com sucesso: {maria.name} | {maria.phoneNumber} | {maria.phoneType}");
        Console.WriteLine($"Contato criado com sucesso: {joao.name} | {joao.phoneNumber} | {joao.phoneType}");
    }
    
    
}
