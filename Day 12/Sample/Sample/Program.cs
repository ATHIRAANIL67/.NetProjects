using System;
using System.Collections;

class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message) { }
}

class Member : IComparable
{
    public int id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string email { get; set; }
    public long phone { get; set; }

    public Member(int id, string firstname, string lastname, string email, long phone)
    {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.phone = phone;
    }

    public override string ToString()
    {
        return id + "," + firstname + "," + lastname + "," + email + "," + phone;
    }

    public int CompareTo(object obj)
    {
        Member other = (Member)obj;
        return this.firstname.CompareTo(other.firstname);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Members:");
        int numMembers = int.Parse(Console.ReadLine());

        ArrayList members = new ArrayList();

        Console.WriteLine("Enter the member details:");

        for (int i = 0; i < numMembers; i++)
        {
            try
            {
                string[] details = Console.ReadLine().Split(',');

                if (details.Length != 7)
                {
                    Console.WriteLine("Invalid input format. Skipping member...");
                    continue;
                }

                int id = int.Parse(details[0]);
                string firstname = details[1];
                string lastname = details[2];
                string email = details[3];
                long phone = long.Parse(details[4]);

                if (!email.Contains("@") || !(email.EndsWith(".com") || email.EndsWith(".org")))
                {
                    throw new InvalidEmailException("InvalidEmailException: Invalid Email for " + firstname);
                }

                Member member = new Member(id, firstname, lastname, email, phone);
                members.Add(member);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format. Skipping member...");
            }
            catch (InvalidEmailException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        members.Sort();

        Console.WriteLine("The member details are:");
        foreach (Member member in members)
        {
            Console.WriteLine(member.ToString());
        }
    }
}
