using UnityEngine;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Change Text")]
    public class ChangeTextStep : ADialogueStep
    {
        [field:SerializeField] public string Text { get; set; }
    }
}