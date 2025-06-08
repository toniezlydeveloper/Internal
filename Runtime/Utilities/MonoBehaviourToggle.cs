using Internal.Runtime.Dependencies.Core;
using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public class MonoBehaviourToggle : ADependencyElement<MonoBehaviourToggle>, IDependency
    {
        [SerializeField] private MonoBehaviour[] behaviours;

        public void Toggle(bool state)
        {
            foreach (MonoBehaviour behaviour in behaviours)
            {
                behaviour.enabled = state;
            }
        }
    }
}