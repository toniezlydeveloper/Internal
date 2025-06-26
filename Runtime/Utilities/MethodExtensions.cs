using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public static class MethodExtensions
    {
        public static void DestroySelf(this GameObject gameObject, float delay) => Object.Destroy(gameObject, delay);
        
        public static void DestroySelf(this GameObject gameObject) => Object.Destroy(gameObject);
        
        public static void DestroySelf(this Component component) => Object.Destroy(component);
        
        public static float AbsoluteValue(this float value) => Mathf.Abs(value);
        
        public static float Clamp(this float value, float min, float max) => Mathf.Clamp(value, min, max);
    }
}