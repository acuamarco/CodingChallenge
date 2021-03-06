using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallenge.Repository.Model
{
    [Table("UserProject")]
    public partial class UserProject
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        public bool IsActive { get; set; }

        public DateTime AssignedDate { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}
