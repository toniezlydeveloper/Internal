using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public static class TimeHelper
    {
        private const float DefaultFixedDeltaTime = 0.01f;
        private const float DefaultTimeScale = 1.0f;

        public static void SetDefaultTimeScale() => SetTimeScale(DefaultTimeScale);

        public static void SetTimeScale(float timeScale)
        {
            Time.fixedDeltaTime = timeScale * DefaultFixedDeltaTime;
            Time.timeScale = timeScale;
        }
    }
}