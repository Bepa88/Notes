using NotesDBHelper;
using NotesDBHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NotesWeb.Controllers
{
    public class NoteController : ApiController
    {
        private IDbHelper _dbHelper;

        public NoteController() : this(new MSSqlDbHelper())
        {

        }

        public NoteController(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }


        [HttpPost]
        public List<Note> FindNotes()
        {
            var listNote = _dbHelper.GetNote();

            return listNote;
        }
    }
}
