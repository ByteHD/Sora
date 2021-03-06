using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using osu.Framework.Extensions.IEnumerableExtensions;
using Sora.Database;
using Sora.Database.Models;
using Sora.Services;

namespace Sora.API.Controllers.api.v1
{
    [ApiController]
    [Route("/api/v1/status")] // /api/v1/status
    public class ServerStatus : Controller
    {
        private readonly SoraDbContext _context;
        private readonly Bot.Sora _sora;
        private readonly PresenceService _ps;

        public ServerStatus(SoraDbContext context, Bot.Sora sora, PresenceService ps)
        {
            _context = context;
            _sora = sora;
            _ps = ps;
        }

        public class ServerStatusResponse
        {
            public int ConnectedUsers { get; set; }
            public int RegisteredUsers { get; set; }
            public int BannedUsers { get; set; }
            public int SubmittedScores { get; set; }
            public double TotalPerformancePoints { get; set; }
            public double AverageAccuracy { get; set; }
        }
        
        [HttpGet]
        [DisableCors]
        public async Task<ActionResult> GetIndex()
        {
            var totalAcc = 0d;
            var divideTotal = 0d;
            var i = 0;
            _context
                   .Scores
                   .Take(500)
                   .OrderByDescending(s => s.PerformancePoints)
                   .ForEach(
                       s =>
                       {
                           var divide = Math.Pow(.95d, i);

                           totalAcc += s.Accuracy * divide;
                           divideTotal += divide;

                           i++;
                       }
                   );

            var totalAccuracy = divideTotal > 0 ? totalAcc / divideTotal : 0;
            var statusResponse = new ServerStatusResponse
            {
                ConnectedUsers = _ps.ConnectedPresences -1, // Sora doesn't count as user!
                RegisteredUsers = await _context.Users.CountAsync() -1,
                BannedUsers = await _context.Users.Where(u => u.Status == UserStatusFlags.Restricted).CountAsync(),
                SubmittedScores = await _context.Scores.CountAsync(),
                TotalPerformancePoints = await _context.Leaderboard.SumAsync(x=>x.PerformancePointsOsu +
                                                                                      x.PerformancePointsTaiko +
                                                                                      x.PerformancePointsCtb +
                                                                                      x.PerformancePointsMania),
                AverageAccuracy = totalAccuracy
            };
            
            return Ok(JsonConvert.SerializeObject(statusResponse));
        }
    }
}
