using System;

namespace GlobalMotorcycleServiceModule
{
    public delegate void MotoServiceDelegate(int totalDistance);
    public class MotorCycleService
    {
        public static int TotalDistance { get; set; }

        public MotorCycleService()
        {
            CHeckDistance();
        }

        void CHeckDistance()
        {
            if (TotalDistance >= 10000)
            {
                NotifyAboutService();
            }
        }

        private void NotifyAboutService()
        {
            throw new NotImplementedException();
        }
    }
}
