﻿using System.ComponentModel.DataAnnotations;

namespace AgentTargetRest.Models
{
    public class AgentModel
    {
        public enum Status
        {
            Dormant,
            Active
        }
        public long Id { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public required string Image { get; set; }
        [Required, StringLength(225, MinimumLength = 3)]
        public required string NickName { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;
        public Status AgentStatus { get; set; } = Status.Dormant;
    }
}