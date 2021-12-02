using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Singleton.Business
{
    class Singleton
    {
        private static Singleton instance=null;
        public string username = "";

        private Singleton() 
        { 
        }
        public static Singleton Instance()
        {
                if (instance == null)
            {
                instance = new Singleton();
            }                    
                return instance;            
        }

        public String getUsername()
        {

            return username;
        }
        public void setUsername(String username)
        {
            this.username = username;
        }

    }
}
