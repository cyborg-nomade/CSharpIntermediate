using System.Collections;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public interface IWorkflow
    {
        void AddActivity(IActivities activity);
        void RemoveActivity(IActivities activity);
        IEnumerable<IActivities> GetActivities();
    }

    public class Workflow : IWorkflow
    {
        private readonly IList<IActivities> _activitiesList;

        public Workflow()
        {
            _activitiesList = new List<IActivities>();
        }

        public void AddActivity(IActivities activity)
        {
            _activitiesList.Add(activity);
        }

        public void RemoveActivity(IActivities activity)
        {
            _activitiesList.Remove(activity);
        }

        public IEnumerable<IActivities> GetActivities()
        {
            return _activitiesList;
        }
    }
}