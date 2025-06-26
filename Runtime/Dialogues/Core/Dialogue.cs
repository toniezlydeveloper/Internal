using UnityEngine;

namespace Internal.Runtime.Dialogues.Core
{
    [CreateAssetMenu(menuName = "Dialogue/Container")]
    public class Dialogue : ScriptableObject
    {
        [field:SerializeField] public DialogueElement[] Elements { get; set; }
    }
}