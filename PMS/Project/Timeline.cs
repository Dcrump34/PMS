using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Project
{
    class Timeline
    {
        public Timeline()
        {
            Milestones = new List<Milestone>();
        }

        public void addMilestone(string milestoneName, string description)
        {
            Milestones.Add(new Milestone(milestoneName, description));
        }

        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }

        private List<Milestone> Milestones;
        private string startDate;
        private string endDate;
    }
}
