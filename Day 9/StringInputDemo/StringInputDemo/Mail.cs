using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringInputDemo
{
    class Mail
    {
        private long _id;

        public long Id
        {
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
            set { _subject = value; }
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
        private long v;

        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail() { }
        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            Id = id;
            To = to;
            From = from;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = size;
        }

        public Mail(long v)
        {
            this.v = v;
        }

        public override string ToString()
        {
            return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\nSize:{6}\n", Id, To, From, Subject, Content, ReceivedDate.ToString("dd-mm-yy", null), Size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            Mail m1 = obj as Mail;
            if (m1.To == To && m1.From == From && m1.Subject == Subject)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
