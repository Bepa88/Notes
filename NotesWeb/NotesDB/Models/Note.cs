using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDB.Models
{
    public class Note
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime DataCreate { get; set; }
        public string Notes { get; set; }
    }
}
