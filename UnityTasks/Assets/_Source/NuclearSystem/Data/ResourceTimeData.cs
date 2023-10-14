using System;
using UnityEngine;

namespace NuclearSystem.Data
{
    [Serializable]
    public class ResourceTimeData
    {
        [field: SerializeField] public NuclearResourceTypes ResourceType {get; private set;}
        [field: SerializeField] public float ResourceTimeProcess {get; private set;}
        [field: SerializeField] public float ResourceTimeDecay {get; private set;}
    }
}
