using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace VoteApi
{
    public class CredModule : NancyModule
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        public CredModule() : base("/cred")
    {
            Get["/list"] = parameters => {
                return "[usr] [vip] [none]";
            };
        Get["/{id}"] = parameters => new FakeUser(parameters.id).ToString();
            Get["/current"] = parameters => {
                return new FakeUser(rand.Next() % 3).ToString();
            };
        }
    }

    public class FakeUser
    {
        public int userID = 0;
        public FakeUser(int next)
        {
            userID = next;

        }

        public override string ToString()
        {
            if (userID == 1) return "usr";
            if (userID == 2) return "vip";
            return "none";
        }
    }
}
