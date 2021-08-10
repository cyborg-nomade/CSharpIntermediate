using System;

namespace CSharpIntermediate
{
    public interface IActivities
    {
        public void Execute();
    }

    public class UploadVideo : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploading");
        }
    }

    public class CallWebService : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service");
        }
    }

    public class SendEmail : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Sending email.");
        }
    }

    public class ChangeStatusToProcessing : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Video status now is processing");
        }
    }
}