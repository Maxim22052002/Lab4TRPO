using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Refactorings
{
    class ImprovedCode
    {
        private void SetMode(bool mod) //1+
        {
            label1.Enabled = mod;
            button1.Enabled = mod;
            button2.Enabled = mod;
            button3.Enabled = !mod;
            button4.Enabled = !mod;
        }
        public string Foo()//2+
        {
            return m_driverStatusNames[driver.Status];
        }
        public void Something3()//3+
        {
            uint i = 15;
            if (i < 10)
            {
                
            }
        }
        public void Something4()//4+
        {
            string destination = null;
            destination = String.Join(string.Empty, source);
        }
        public bool IsNumber(string str)//5+
        {
            int test = 0;
            return int.TryParse(str, out test);
        }
        public void Something6()//6?
        {
            foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                //create folder{16}
                stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
                stream.Read(new byte[1], 0, 1);
                stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
                stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')), 0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
                
                stream.Read(new byte[1], 0, 1);//Ok
            }
        }
        public void Something7()//7+
        {
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }
        public void Something8()//8+
        {
            DateTime dt = DateTime.Now;
            string[] array = dt.ToLongTimeString().Split(':');
            string h = array[0];
            string m = array[1];
            string s = array[2];
            Console.WriteLine("--" + h + ":" + m + ":" + s + "--");
        }
        public void Something9()//9+
        {
            return (Counter % 2 != 0 && Counter / 10.0 != 0);
        }
        public void Something10()//10+
        {
            if (Connected == 0)
            {
                rez = setup();
            }
            flEnd = true;
        }
        public void Something11()//11+
        {
            List<int> array = new List<int>();
            for(int i = 0; i < array.Count; i++)
            {
                if (array[i] > 100)
                {
                    array.Remove(array[i]);
                }
            }
        }
        public void Something12()//12+
        {
            var ids = form.Keys;
            if(ids.Length != 1)
            {
                throw new Exception();
            }
        }
        public void Something13()//13+
        {
            //Use the Name field
            string[] nameParts = customer.Name.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
        }
        public void Something14()//14+
        {
            sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
        }
        public string generateEMail()//15+
        {
            string res;
            PersonName = PersonName.Replace(' ', '.');
            if (PersonName.Length >= 20)
            {
                res = PersonName.Substring(0, 20);
            }
            else
            {
                res = PersonName.Substring(0, PersonName.Length);
            }
            res += "@domain.ua";
            return res;
        }
        public void Something16()//16+
        {
            sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
        }
        string GetTextDiv2(string text)//17+
        {
            string[] array = text.Split(' ');
            switch (array.Length)
            {
                case 1:
                    return "&nbsp" + array[0];
                case 2:
                    return "&nbsp" + array[0] + " " + array[1];
                default:
                    return "&nbsp" + String.Join(" ", array.Take((array.Length + 1) / 2).ToArray()) + " <br/>&nbsp " + String.Join(" ", array.Skip((array.Length + 1) / 2).ToArray());
            }
        }
        public void Something18() { }//18+
        private static readonly char SPECIFIER = "$"[0];
        private static readonly char DELIMITER = ":"[0];
        private static readonly char[] DELIMITER_ARRAY = { DELIMITER };

        public void Something19()//19+
        {
            string mailTo = String.IsNullOrEmpty(Config.GetSetting("AdminNotifications_EmailAddress")) ? Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString() : Config.GetSetting("AdminNotifications_EmailAddress");
        }
        public bool CheckPath(string path)//20+
        {
            return File.Exists(path + "analit.dbf") && File.Exists(path + "partner.dbf") && File.Exists(path + "SCLAD\\mdoc.dbf") && File.Exists(path + "SCLAD\\mdoc.fpt") && File.Exists(path + "SCLAD\\mdocm.dbf") && File.Exists(path + "SCLAD\\mgrup.dbf") && File.Exists(path + "SCLAD\\mlabel.dbf") && File.Exists(path + "SCLAD\\mlabel.fpt") && File.Exists(path + "REAL\\rbookm.dbf") && File.Exists(path + "REAL\\rbook.dbf") && File.Exists(path + "REAL\\rbook.fpt") && File.Exists(path + "DOSTAVKA\\avt.dbf") && File.Exists(path + "DOSTAVKA\\avtm.dbf") && File.Exists(path + "DOSTAVKA\\avtm.fpt") && File.Exists(path + "DOSTAVKA\\cargo.dbf") && File.Exists(path + "DOSTAVKA\\cargom.dbf") && File.Exists(path + "DOSTAVKA\\zamena.dbf");
        }
        public void Something21()//21+
        {
            txtContacts.Text = String.Join(";", contacts);
        }
        public void Something22()//22+
        {
            Game1.clou = !Game1.clou;
        }
    }
}
