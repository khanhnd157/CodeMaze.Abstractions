using System;

namespace CodeMaze.Abstractions.Domain
{
    public abstract class AuditLogsEntity : BaseEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
    }
}