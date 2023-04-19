/*Problem Description

Car Pooling System - Requirement 1

You are a very active member of a Nature Club in your organization. In one of the meetings, it was discussed to build a car pooling system to help cut down the pollution. Being very active and tech savvy, you wish to contribute towards the development of system. One of the members being an architect has understood the requirement and would be sharing you with smaller requirements.

Requirement 1:

The users of the system are going to be general public who own cars.They are classified as members in our system.

a.	Create a Member Class with the following attributes:

Member Field name	Type

_id	long

_firstName	string

_lastName	string

_email	string

_contactNumber	string

_license Number	string

_licenseStartDate	DateTime

_licenseExpiryDate	DateTime

b.	Mark all the attributes as private

c.Create / Generate appropriate Properties

d.	Add a default constructor and a parameterized constructor to take in all attributes.

e.	When the “member” object is printed, it should display the following details:

Member: _firstname, _lastname

Member contact details: _contactNumber, _email

f.	Two members are considered same if they have same email and contactNumber. Implement the logic in the appropriate function. (Case – Insensitive)

Sample Input and Output 1:

[All text in bold corresponds to input and the rest corresponds to output.]

Member1:

id:

1

first name:

Arun

last name:

Kumar

email:

arun123 @gmail.com

contact number:

9878767655

license number:

TN38QW1232343

license start date:

12 - 12 - 2010

license expiry date:

13 - 12 - 2020

Member2:

id:

2

first name:

Mohamed

last name:

Safiq

email:

safiq1243 @gmail.com

contact number:

9667826601

license number:

TN33VA1238743

license start date:

01 - 05 - 2013

license expiry date:

01 - 04 - 2125

Member 1

Name: Arun , Kumar

Member contact details: 9878767655 , arun123 @gmail.com

Member 2

Name: Mohamed , Safiq

Member contact details: 9667826601 , safiq1243 @gmail.com

Member 1 and Member 2 are different

Sample Input and Output 2:

[All text in bold corresponds to input and the rest corresponds to output.]

Member1:

id:

1

first name:

Sam

last name:

Nath

email:

Sam123 @gmail.com

contact number:

9456738498

license number:

TN45AS123456

license start date:

12 - 12 - 2010

license expiry date:

13 - 12 - 2021

Member2:

id:

2

first name:

Swamy

last name:

Nathan

email:

Sam123 @gmail.com

contact number:

9456738498

license number:

TN54DF321456

license start date:

01 - 05 - 2012

license expiry date:

01 - 05 - 2123

Member 1

Name: Sam , Nath

Member contact details: 9456738498 , Sam123 @gmail.com

Member 2

Name: Swamy , Nathan

Member contact details: 9456738498 , Sam123 @gmail.com

Member 1 is same as Member 2*/

using System;
using System.Collections.Generic;

namespace CarPoolingReq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member {0}:", i + 1);
                Console.Write("Id: ");
                long id = long.Parse(Console.ReadLine());
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Contact Number: ");
                string contactNumber = Console.ReadLine();
                Console.Write("License Number: ");
                string licenseNumber = Console.ReadLine();
                Console.Write("License Start Date (dd-MM-yyyy): ");
                DateTime licenseStartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Console.Write("License Expiry Date (dd-MM-yyyy): ");
                DateTime licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Member member1 = new Member(id,firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate);
                list.Add(member1);
            }
            
            int j = 1;
            foreach (var item in list)
            {
                Console.WriteLine("Mail {0}: ", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("\nMember 1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("\nMember 1 and Member 2 are different");
            }

            Console.ReadLine();
        }

    }
}
