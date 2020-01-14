using NotesDBHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDBHelper
{
    public interface IDbHelper
    {
        List<User> GetUsers();
        User GetUserById(int id);
        List<Note> GetNote();
        Note GetNoteById(int id);
        void InsertUser (User user);
        void InsertNote(Note note);

    }
}
