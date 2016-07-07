using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TJournal
{
    public class Helper
    {
        public static string GetResourceContent(string filename)
        {
            string tmp;
            // get the current assembly
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            // resources are named using a fully qualified name
            string nimi = asm.GetName().Name;

            Type t = asm.GetType();

            // TODO: Make this non static Namespace getmanifest 
            //Unfortunately I don't know how to access Namespace of current project except statically like here... TR
            System.IO.Stream strm = asm.GetManifestResourceStream("TJournal" + "." + filename);
            //read the contents of the embedded file
            System.IO.StreamReader reader = new System.IO.StreamReader(strm);
            tmp = reader.ReadToEnd();
            reader.Close();
            if (tmp.Length < 2)
            {
                tmp = "e";
            }
            return tmp;
        }




        public static string GetLocalUserName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }


        public static string GetUserName()
        {

            string name = GetLocalUserName();
            string domain = "";
            string uname = "";
            if (name.Contains("\\"))
            {
                string[] tmp = name.Split('\\');
                domain = tmp[0];
                uname = tmp[1];
            }
            else uname = name;
            return uname;
        }


        public static string GetUserDomainName()
        {
            string name = GetLocalUserName();
            string domain = "";
            string uname = "";
            if (name.Contains("\\"))
            {
                string[] tmp = name.Split('\\');
                domain = tmp[0];
                uname = tmp[1];
            }
            return domain;
        }



    }
}
