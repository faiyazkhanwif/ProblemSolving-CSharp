using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Basics
{
    internal class NoteStoreOOPProblem
    {

        public class NotesStore
        {
            class Note
            {
                public string Notestate;
                public string Notename;
            }

            List<Note> notes;

            public NotesStore()
            {
                notes = new List<Note>();
            }
            public void AddNote(String state, String name)
            {
                if (name.Length == 0)
                {
                    throw new Exception("Error: Name cannot be empty");
                }
                else
                {
                    if (state != "completed" && state != "active" && state != "others")
                    {
                        throw new Exception($"Invalid state {state}");
                    }
                    else
                    {
                        Note note = new Note();
                        note.Notestate = state;
                        note.Notename = name;

                        notes.Add(note);
                    }
                }
            }
            public List<String> GetNotes(String state)
            {
                List<String> resnotes = new List<String>();

                if (state != "completed" && state != "active" && state != "others")
                {
                    throw new Exception($"Invalid state {state}");
                }

                foreach (Note note in notes)
                {
                    if (note.Notestate == state)
                    {
                        resnotes.Add(note.Notename);
                    }
                }
                return resnotes;
            }
        }
    }
}
