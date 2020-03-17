using System;
using System.Collections.Generic;
using System.Text;

namespace Lib1.Services
{
    class Connect
    {
        private static Connect instance = null;
        public List<string> Contacts { get; set;}

        private Connect()
        {
            Contacts.Add("Barack Afritt");
            Contacts.Add("Barbara Dégout");
            Contacts.Add("Bart Haba");
            Contacts.Add("Bernadette Dejeu");
        }

        public static Connect Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new Connect();
                }
                return instance;
            }
        }

        public List<string> Load()
        {
            return Contacts;
        }

    }
}
