using System;
using LiteDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Todo.Db
{
    public class Task
    {
        public ObjectId Id { get; set; }
        public DateTime DueTime { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
