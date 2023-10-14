using NuclearSystem.Data;
using NuclearSystem.View;
using UnityEngine;

namespace NuclearSystem.Timer
{
    public class ResourceTimerService 
    {
        private static ResourceTimerService instance;
        private ResourceTimeDataSO _resourceViewDataSo = 
            Resources.Load("NewResourceViewData" ) as ResourceTimeDataSO;
        
        public static ResourceTimerService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceTimerService();
                }

                return instance;
            }
        }
    }
}
