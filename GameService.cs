using MIDTERM_A1_SLOT_MACHINE_BACKEND.Models;
using MIDTERM_A1_SLOT_MACHINE_BACKEND.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MIDTERM_A1_SLOT_MACHINE_BACKEND.Services
{
    public class GameService
    {
        private readonly ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveGameResult(GameResultDTO gameResult)
        {
            var result = new GameResult
            {
                PlayerId = gameResult.PlayerId,
                Outcome = gameResult.Outcome,
                DatePlayed = DateTime.UtcNow
            };

            _context.GameResults.Add(result);
            _context.SaveChanges();
        }

        public List<GameResult> GetGameResults(DateTime startDate, DateTime endDate)
        {
            return _context.GameResults
                .Where(gr => gr.DatePlayed >= startDate && gr.DatePlayed <= endDate)
                .ToList();
        }
    }
}
