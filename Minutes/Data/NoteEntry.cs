using System;
using System.Collections.Generic;
using System.Text;

namespace Minutes.Data
{
   public class NoteEntry
    {

        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return $"{Title} {CreatedDate}";
        }

        public NoteEntry()
        {
            CreatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }

    }
}
