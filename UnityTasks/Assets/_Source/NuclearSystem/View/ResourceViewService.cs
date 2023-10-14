using NuclearSystem.Data;
using UnityEngine;

namespace NuclearSystem.View
{
    public class ResourceViewService
    {
        private static ResourceViewService instance;
        private ResourceViewDataSO _resourceViewDataSo = 
        Resources.Load("NewResourceViewData" ) as ResourceViewDataSO;
        
        public static ResourceViewService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceViewService();
                }

                return instance;
            }
        }

        public bool GetProcessResourceIcon(NuclearResourceTypes type, out Sprite icon)
        {
            icon = null;
            if (_resourceViewDataSo)
            {
                foreach (var viewData in _resourceViewDataSo.ResourceViewDatas)
                {
                    if (viewData.ResourceType == type)
                    {
                        icon = viewData.ResourceProcessIcon;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool GetDecayResourceIcon(NuclearResourceTypes type, out Sprite icon)
        {
            icon = null;
            if (_resourceViewDataSo)
            {
                foreach (var viewData in _resourceViewDataSo.ResourceViewDatas)
                {
                    if (viewData.ResourceType == type)
                    {
                        icon = viewData.ResourceDecayIcon;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
