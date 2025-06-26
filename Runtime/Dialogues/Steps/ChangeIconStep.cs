using UnityEngine;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Change Icon")]
    public class ChangeIconStep : ADialogueStep
    {
        [field:SerializeField] public Sprite Icon { get; set; }
    }
}