using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            var removeMail = Inbox.FirstOrDefault(mail => mail.Sender == sender);
            if (removeMail != null)
            {
                Inbox.Remove(removeMail);
                return true;
            }
            return false;
        }

        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            int movedMailsCount = Inbox.Count;
            Inbox.Clear();
            return movedMailsCount;
        }

        public string GetLongestMessage()
        {
            var longestMail = Inbox.MaxBy(mail => mail.Body.Length);
            return longestMail.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new();

            sb.AppendLine("Inbox:");

            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
