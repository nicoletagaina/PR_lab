using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

     class Program
     {
          static void Main(string[] args)
          {
               SendMessage("nicoleta.gaina@ati.utm.md", "Nickoletta.1999", "Laboratorul2 finisat");/// posta..parola..Tema
               GetMessages("nicoleta.gaina@ati.utm.md", "Nickoletta.1999");
               
          }
          
          public static void SendMessage(string email, string parola, string mesaj)
          {
               using (MailMessage mail = new MailMessage())
               {
                    mail.From = new MailAddress(email);
                    mail.To.Add(email);
                    mail.Subject = mesaj;
                    mail.Body = "<h1>Lab2</h1>";/// textul 
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.office365.com", 587))
                    {
                         smtp.Credentials = new NetworkCredential(email, parola);
                         smtp.EnableSsl = true;
                         smtp.Send(mail);
                    }
               }
          }

          public static void GetMessages(string OutMail, string Parola)
          {
               using (Imap imap = new Imap())
               {
                    imap.Connect("outlook.office365.com");
                    imap.UseBestLogin(OutMail, Parola);
                    imap.SelectInbox();
                    List<long> uids = imap.Search(Flag.All);
                    foreach (long uid in uids)
                    {
                         IMail email = new MailBuilder()
                             .CreateFromEml(imap.GetMessageByUID(uid));
                         Console.WriteLine(email.Subject);
                    }
                    imap.Close();
               }
          }
     }

