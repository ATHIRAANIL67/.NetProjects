/*Mail Folder - Requirement

You work for a start-up company. The company has been using an outdated mail system. Looking at the difficulty in the old system, the management decided to build their own mail server. There are two major domains, Mail and Mail Folder. The mail details are stored in the mail domain. The mail folder is used to group the emails together.

Requirement 1:

Let’s start off by creating two Mail objects and check whether they are equal.

1.	Create a Mail Class with the following attributes:

Member Field Name	Type

_id	long

_to	string

_from	string

_subject	string

_content	string

_receivedDate	DateTime

_size	double

2.	Mark all the attributes as private

3.Include appropriate properties.

4.Add a default constructor and a parameterized constructor to take in all attributes in the given order: Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)

5.When the “mail” object is printed, it should display the following details: [Override the ToString method]

Print format:

Id: "_id"

To: "_to"

From: "_from"

Subject: "_subject"

Content: "_content"

Received Date:"_receivedDate"

Size: "_size"

6.Two emails are considered same if they have the same to address, from address, and subject. Implement the logic in the appropriate function. (Case – Insensitive) [Override the Equals method]

The input format consists of mail details separated by comma in the below order,

(_id, _to, _from, _subject, _content, _receivedDate, _size)

The Input to your program would be details of two emails, you need to display their details as given in "5th point(refer above)" and compare the two emails and display if the Mails are same or different.

Note: There is an empty line between display statements. Print the empty lines in Main function.

       Display one digit after the decimal point for double datatype.

Sample INPUT & OUTPUT 1:

Enter mail 1 detail:

1001,meyyappan @gmail.com, satish@gmail.com, Master Copy, Attached doc,05-05-2017,10.0

Enter mail 2 detail:

1001,meyyappan @gmail.com, satish@gmail.com, Master Copy, Attached doc,05-05-2017,10.0

Mail 1:

Id: 1001

To: meyyappan @gmail.com

From:satish @gmail.com

Subject:Master Copy

Content:Attached doc

ReceivedDate:05 - 05 - 2017

Size: 10.0

Mail 2:

Id: 1001

To: meyyappan @gmail.com

From:satish @gmail.com

Subject:Master Copy

Content:Attached doc

ReceivedDate:05 - 05 - 2017

Size: 10.0

Mail 1 is same as Mail 2

Sample INPUT & OUTPUT 2:

Enter mail 1 detail:

1001,meyyappan @gmail.com, satish@gmail.com, Master Copy, Attached doc,05-05-2017,10.0

Enter mail 2 detail:

1002,satish @gmail.com, meyyappan@gmail.com, Master Copy, Attached doc,05-05-2017,10.0

Mail 1:

Id: 1001

To: meyyappan @gmail.com

From:satish @gmail.com

Subject:Master Copy

Content:Attached doc

ReceivedDate:05 - 05 - 2017

Size: 10.0

Mail 2:

Id: 1002

To: satish @gmail.com

From:meyyappan @gmail.com

Subject:Master Copy

Content:Attached doc

ReceivedDate:05 - 05 - 2017

Size: 10.0

Mail 1 and Mail 2 are different*/



using System;
using System.Collections.Generic;

namespace StringInputDemo
{
    class Mail
    {
        private long _id;

        public long Id { 
            get { return _id; } 
            set { _id = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; } 
            set { _to = value; }
        }

        private string _from;

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _from = value; }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
            
        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail() { }
        public Mail(long id,string to,string from,string subject,string content,DateTime receivedDate,double size)
        {
            Id = id;
            To = to;
            From = from;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = size;
        }
        public override string ToString()
        {
            return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\nSize:{6}\n", Id, To, From, Subject, Content, ReceivedDate.ToString("dd-mm-yy", null), Size.ToString("0.0"));
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> list = new List<Mail>();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter mail {0} detail:", i + 1);
                string[] s=Console.ReadLine().Split(' ');
                Mail m = new Mail(long.Parse(s[0], s[1], s[2], s[3], s[4], s[5], s[6]));
            }



            
        }

        
    }
    /*string input = "1001,meyyappan@gmail.com,satis@gmail.com,Master Copy,Attached doc,05-05-2017,10.0";
    string[] entries = input.Split(',');
    foreach (string entry in entries)
    {
        Console.WriteLine(entry);
    }*/
    //int id;
    //string to;

}
