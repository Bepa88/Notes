using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDBHelper.Models
{
    public class UsersNotesRight
    {
        public Note Note { get; set; }
        public User User { get; set; }
        public string Right { get; set; }
    }
}
