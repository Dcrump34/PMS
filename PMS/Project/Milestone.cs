using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Project
{
    class Milestone
    {
        public Milestone(string milestoneName, string description)
        {
            MilestoneName = milestoneName;
            Description = description;
        }

        private readonly string MilestoneName;
        public readonly string Description;
    }
}
