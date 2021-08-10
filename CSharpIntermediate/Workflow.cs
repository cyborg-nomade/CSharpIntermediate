using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow
    {
        public readonly IList<IActivities> ActivitiesList;

        public Workflow()
        {
            ActivitiesList = new List<IActivities>();
        }

        public void AddActivity(IActivities activity)
        {
            ActivitiesList.Add(activity);
        }
    }
}