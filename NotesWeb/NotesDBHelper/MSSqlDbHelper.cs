using NotesDBHelper.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDBHelper
{
    public class MSSqlDbHelper : IDbHelper
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public List<Note> GetNote()
        {
            List<Note> notes = new List<Note>();
            string queryString = @"SELECT n.Id, n.UsersId, n.DateCreate, n.Note
                                    FROM Notes n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Note note = new Note();
                        note.Id = Convert.ToInt32(reader["Id"]);
                        note.User.Id = Convert.ToInt32(reader["UsersId"]);
                        note.DataCreate = Convert.ToDateTime(reader["DateCreate"]);
                        note.Notes = reader["Note"].ToString();
                        notes.Add(note);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }

            return notes;
        }

        public Note GetNoteById(int id)
        {
            Note note = new Note();
            string queryString = @"SELECT n.Id, n.UsersId, n.DateCreate, n.Note
                                    FROM Notes n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        note.Id = Convert.ToInt32(reader["Id"]);
                        note.User.Id = Convert.ToInt32(reader["UsersId"]);
                        note.DataCreate = Convert.ToDateTime(reader["DateCreate"]);
                        note.Notes = reader["Note"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }

            return note;
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void InsertNote(Note note)
        {
            throw new NotImplementedException();
        }

        public void InsertUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
