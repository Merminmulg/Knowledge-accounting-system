using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class QuestionDB
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TaskId { get; set; }
        public virtual TaskDB Task { get; set; }
    }
}
