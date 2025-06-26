using UnityEngine;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Change Name")]
    public class ChangeNameStep : ADialogueStep
    {
        [field:SerializeField] public string Name { get; set; }
    }
}