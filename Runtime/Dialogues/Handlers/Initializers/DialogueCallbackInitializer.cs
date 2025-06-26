using Internal.Runtime.Dialogues.Steps;
using UnityEngine;
using UnityEngine.Events;

namespace Internal.Runtime.Dialogues.Handlers.Initializers
{
    public class DialogueCallbackInitializer : MonoBehaviour
    {
        [SerializeField] private RaiseCallbackStep step;
        [SerializeField] private UnityEvent callback;

        private void Start() => step.Init(callback);
    }
}