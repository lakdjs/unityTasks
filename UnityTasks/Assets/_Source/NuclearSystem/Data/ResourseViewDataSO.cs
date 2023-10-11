using System.Collections.Generic;
using UnityEngine;

namespace NuclearSystem.Data
{
    [CreateAssetMenu(menuName = "SO/New Resource View Data", fileName = "NewResourceViewData")]
    public class ResourceViewDataSO : ScriptableObject
    {
        [field: SerializeField] public List<ResourceViewData> ResourceViewDatas { get; private set; }
    }
}
