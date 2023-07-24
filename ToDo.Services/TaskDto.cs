using LiteDB;

namespace ToDo.Services
{
    public class TaskDto
    {
        public ObjectId Id { get; set; }
        public DateTime DueTime { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}