﻿namespace PlanScoreCard.Models
{
    public class ScoreValueModel
    {
        public string PlanId { get; set; }
        public double Value { get; set; }
        public double Score { get; set; }
        public string CourseId { get; set; }
        public string OutputUnit { get; set; }
    }
}
