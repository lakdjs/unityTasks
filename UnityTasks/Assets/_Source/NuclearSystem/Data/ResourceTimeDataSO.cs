using System.Collections.Generic;
using UnityEngine;

namespace NuclearSystem.Data
{
    [CreateAssetMenu(menuName = "SO/New Resource Time Data", fileName = "NewResourceTimeData")]
    public class ResourceTimeDataSO : ScriptableObject
    {
        [field: SerializeField] public List<ResourceTimeData> ResourceTimeDatas { get; private set; }
    }
}
