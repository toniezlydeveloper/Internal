using UnityEngine;
using UnityEngine.Events;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Raise Callback")]
    public class RaiseCallbackStep : ADialogueStep
    {
        private UnityEvent _callback;

        public void Init(UnityEvent callback) => _callback = callback;

        public void Raise() => _callback.Invoke();
    }
}