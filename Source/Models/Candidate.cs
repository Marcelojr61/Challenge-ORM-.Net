using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Required]
        [Column("status")]
        public int Status { get; set; }

        [Required]
        [Column("created_at")]
        [Timestamp]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("User")]
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [ForeignKey("Acceleration")]
        [Column("acceleration_id")]
        public int AccelerationId { get; set; }
        public Acceleration Acceleration { get; set; }

        [Required]
        [ForeignKey("Company")]
        [Column("company_id")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
