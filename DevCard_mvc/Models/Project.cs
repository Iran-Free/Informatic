using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }
}