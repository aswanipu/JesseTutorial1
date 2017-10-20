using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDemo2
{
     public class WingetResult
    {
        public string pid { get; set; }
        public object companyId { get; set; }
        public string companyPid { get; set; }
        public string companyName { get; set; }
        public string login { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public bool activated { get; set; }
        public string langKey { get; set; }
        // public object deviceKey { get; set; }
        //public List<string> authorities { get; set; }
        public bool showAllUserData { get; set; }

    }
}
