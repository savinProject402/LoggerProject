namespace LoggerProject
{
    using System;
    using LoggerProject.Services;
    using LoggerProject.Interfaces;
    public class Starter
    {
        private readonly ActionsMetod actionsmetod;
        private readonly Logger logger;
        public Starter()
        {
            this.actionsmetod = new ActionsMetod();
            this.logger = Logger.InterfaceServise;
        }

        public void Run()
        {
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                try
                {
                    switch (rand.Next(1,4))
                    {
                        case 1:
                            this.actionsmetod.First();
                            break;
                        case 2:
                            this.actionsmetod.Second();
                            break;
                        case 3:
                            this.actionsmetod.Trird();
                            break;
                    }
                }
                catch (BusinesExeeption busEx)
                {
                    this.logger.LogWarning($"Action got this custom Exception: {busEx}");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message, ex);
                }
            }
        }
    }
}
