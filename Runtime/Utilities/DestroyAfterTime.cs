using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public class DestroyAfterTime : MonoBehaviour
    {
        [SerializeField] private float lifetime;

        private void Start() => Destroy(gameObject, lifetime);
    }
}