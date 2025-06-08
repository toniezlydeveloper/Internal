using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Internal.Runtime.Utilities
{
    public static class ExtendedDebug
    {
        public static void Log(string message, [CallerFilePath] string filePath = "") => Debug.Log($"[{Path.GetFileNameWithoutExtension(filePath)}] {message}");
        
        public static void LogWarning(string message, [CallerFilePath] string filePath = "") => Debug.LogWarning($"[{Path.GetFileNameWithoutExtension(filePath)}] {message}");
        
        public static void LogError(string message, [CallerFilePath] string filePath = "") => Debug.LogError($"[{Path.GetFileNameWithoutExtension(filePath)}] {message}");
    }
}