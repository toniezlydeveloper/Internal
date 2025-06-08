using UnityEngine;

namespace Internal.Runtime.Dependencies.Core
{
    public abstract class ADependency<TDependency> : MonoBehaviour where TDependency : IDependency
    {
        private void Awake() => DependencyInjector.InjectRecipe(GetComponent<TDependency>());

        private void OnDestroy() => DependencyInjector.DejectRecipe<TDependency>();
    }
}