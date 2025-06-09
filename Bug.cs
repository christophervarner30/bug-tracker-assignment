using System;

namespace BugTracker
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AttachmentUrl { get; set; }

        public Bug()
        {
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Bug {Id}: {Title} - {Status}";
        }
    }
}
