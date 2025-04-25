using System;

namespace MIDTERM_A1_SLOT_MACHINE_BACKEND.Models
{
    public class GameResult
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Outcome { get; set; }
        public DateTime DatePlayed { get; set; }
    }
}
