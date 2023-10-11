using System;
using NuclearSystem.Data;
using UnityEngine;
using UnityEngine.UI;

namespace NuclearSystem.View
{
    [RequireComponent(typeof(Image))]
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private NuclearResourceTypes resourceType;
        private Image _icon;
        private void Start()
        {
            _icon = GetComponent<Image>();
            if (ResourceViewService.Instance.GetProcessResourceIcon(resourceType,
                    out Sprite processIcon))
            {
                _icon.sprite = processIcon;
            }
        }
    }
}
