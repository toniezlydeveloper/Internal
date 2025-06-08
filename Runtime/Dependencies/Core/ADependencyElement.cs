using System.Collections.Generic;
using UnityEngine;

namespace Internal.Runtime.Dependencies.Core
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DependencyList<TDependency> : List<TDependency>, IDependency
    {
    }
    
    public abstract class ADependencyElement<TDependency> : MonoBehaviour where TDependency : IDependency
    {
        private void Awake() => DependencyInjector.AddRecipeElement(GetComponent<TDependency>());

        private void OnDestroy() => DependencyInjector.RemoveRecipeElement(GetComponent<TDependency>());
    }
}