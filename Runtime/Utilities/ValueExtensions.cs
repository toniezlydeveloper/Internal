using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public static class ValueExtensions
    {
        public static void OverrideLayer(this GameObject gameObject, int layer) => gameObject.layer = layer;

        public static void Disable(this SpriteRenderer renderer) => renderer.color = Color.clear;
    }
}