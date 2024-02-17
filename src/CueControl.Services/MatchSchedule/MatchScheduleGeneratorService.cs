using CueControl.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.Services
{
    public class MatchScheduleGeneratorService
    {
        public List<MatchSchedule> GenerateSchedule(List<Team> teams, int seasonId, DateTime startDate, List<DayOfWeek> matchDays)
        {
            List<MatchSchedule> schedule = new List<MatchSchedule>();

            if (teams.Count % 2 != 0)
            {
                // Add a bye team if the number of teams is odd
                teams.Add(new Team { Id = -1, Name = "Bye" });
            }

            int totalRounds = teams.Count - 1;
            int matchesPerRound = teams.Count / 2;

            for (int round = 1; round <= totalRounds; round++)
            {
                DateTime roundStartDate = startDate.AddDays((round - 1) * 7); // Start date of the current round

                for (int match = 0; match < matchesPerRound; match++)
                {
                    int homeTeamIndex = (round + match) % (teams.Count - 1); // Team index for home team
                    int awayTeamIndex = (teams.Count - 1 - match + round) % (teams.Count - 1); // Team index for away team

                    // Ensure the bye team never plays itself
                    if (teams[homeTeamIndex].Id != -1 && teams[awayTeamIndex].Id != -1)
                    {
                        // Determine the day of the week for the match
                        DayOfWeek matchDay = matchDays[round % matchDays.Count];

                        // Add match to schedule
                        schedule.Add(new MatchSchedule
                        {
                            SeasonId = seasonId,
                            Round = round,
                            HomeTeamId = teams[homeTeamIndex].Id,
                            AwayTeamId = teams[awayTeamIndex].Id,
                            ScheduledDateTime = GetNextWeekday(roundStartDate, matchDay)
                        });
                    }
                }
            }

            return schedule;
        }

        private DateTime GetNextWeekday(DateTime startDate, DayOfWeek dayOfWeek)
        {
            int daysUntilNextDay = ((int)dayOfWeek - (int)startDate.DayOfWeek + 7) % 7;
            return startDate.AddDays(daysUntilNextDay);
        }
    }
}
