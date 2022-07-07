using Hangfire;

namespace HangFireExample.JobsManagers
{
    public class JobsManager
    {
        #region Singleton

        private static Lazy<JobsManager> instance = new Lazy<JobsManager>(() => new JobsManager());
        public static JobsManager Instance => instance.Value;

        #endregion

        #region Properties



        #endregion

        #region Methods

        public void StartReccuringJob()
        {
            RecurringJob.AddOrUpdate("Recurring Jobs", () => Console.WriteLine("Recurring Jobs"), Cron.Hourly);
        }

        public void StartFireForgetJob()
        {
            var jobId = BackgroundJob.Enqueue(() => Console.WriteLine("Fire and Forget Jobs"));
        }

        public void StartDelayedJob()
        {
            var jobId = BackgroundJob.Schedule(() => Console.WriteLine("Delayed Jobs"), TimeSpan.FromMinutes(10));
        }

        //public void StartContinuationsJob()
        //{
        //    var jobId = 1;
        //    return BackgroundJob.ContinueJobWith(jobId, () => Console.WriteLine("Continuation!"));
        //}
        #endregion
    }
}
