using System;
using System.Collections.Generic;

class AddressBookMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program in C#");

        AddressBook addressBook = new AddressBook();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Display all contacts");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;
                case 2:
                    addressBook.DisplayContacts();
                    break;
                case 3:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        Console.WriteLine("Address Book program has ended.");
    }
}

class AddressBook
{
    private List<Contact> contacts;

    public AddressBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact()
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter phone number:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Enter email:");
        string email = Console.ReadLine();

        Console.WriteLine("Enter address:");
        string addressInfo = Console.ReadLine();

        Contact newContact = new Contact(name, phoneNumber, email, addressInfo);
        contacts.Add(newContact);

        Console.WriteLine("Contact added successfully!");
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
            return;
        }

        Console.WriteLine("List of contacts:");
        foreach (var contact in contacts)
        {
            contact.Display();
        }
    }
}

class Contact
{
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public string AddressInfo { get; private set; }

    public Contact(string name, string phoneNumber, string email, string addressInfo)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        AddressInfo = addressInfo;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Address: {AddressInfo}");
        Console.WriteLine();
    }
}
