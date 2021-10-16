using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class TaskDB
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public int MaxScore { get; set; }

        public virtual ICollection<QuestionDB> Questions { get; set; }
    }
}
