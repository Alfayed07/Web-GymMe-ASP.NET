using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationFront.Model;

namespace WebApplicationFront.Repository
{
    public class InstanceDB
    {
        private static Database1Entities instance;

        public static Database1Entities getInstance()
        {
            if (instance == null)
            {
                instance = new Database1Entities();
            }
            return instance;

        }
    }
}
