using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopersWebApi.Model
{
    public class Developer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public Skill[] skills { get; set; }
    }
}
