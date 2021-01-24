using System;
using HowLongApi.Models.Enums;

namespace HowLongApi.Models
{
    public class Team
    {
        public string Name { get; set; }
        public Sport Sport { get; set; }
        public string Championship { get; set; }
        public DateTime ChampionshipDate { get; set; }
    }
}
