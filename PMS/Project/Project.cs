using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Project
{
    class Project
    {
        public Project(string projectName)
        {
            ProjectName = projectName;
        }

        public Budget ProjectBudget
        {
            get => projectBudget;
            set => value = projectBudget;
        }

        public Timeline ProjectTimeline
        {
            get => projectTimeline;
            set => value = projectTimeline;
        }

        private Budget projectBudget;
        private Timeline projectTimeline;
        public readonly string ProjectName;
    }
}
