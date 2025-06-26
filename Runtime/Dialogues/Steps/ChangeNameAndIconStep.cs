using UnityEngine;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Change Name And Icon")]
    public class ChangeNameAndIconStep : ADialogueStep
    {
        [field:SerializeField] public Sprite Icon { get; set; }
        [field:SerializeField] public string Name { get; set; }
    }
}