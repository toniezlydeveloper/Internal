using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public static class ValueExtensions
    {
        public static void OverrideLayer(this GameObject gameObject, int layer) => gameObject.layer = layer;
    }
}