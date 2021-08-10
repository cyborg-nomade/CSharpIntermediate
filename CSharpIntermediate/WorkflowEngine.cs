namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.ActivitiesList)
            {
                activity.Execute();
            }
        }
    }
}