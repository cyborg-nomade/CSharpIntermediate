using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();
            var engine = new WorkflowEngine();

            workFlow.AddActivity(new UploadVideo());
            workFlow.AddActivity(new CallWebService());
            workFlow.AddActivity(new SendEmail());
            workFlow.AddActivity(new ChangeStatusToProcessing());

            engine.Run(workFlow);
        }
    }
}
