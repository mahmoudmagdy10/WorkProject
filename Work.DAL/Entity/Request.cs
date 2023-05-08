using System.Diagnostics.CodeAnalysis;

namespace Work.DAL.Entity
{
    public class Request
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        [AllowNull]
        public bool? Agree { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
