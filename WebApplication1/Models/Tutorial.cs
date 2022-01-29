using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tutorial
    {
        public int TutorialId { get; set; }
        public string TutorialName { get; set; }
        public string TutorialDesc { get; set; }
        public int Published { get; set; }
        public int Fees { get; set; }
    }
}
