using System;
using Internal.Runtime.Dialogues.Steps;
using UnityEngine;

namespace Internal.Runtime.Dialogues.Core
{
    [Serializable]
    public class DialogueElement
    {
        [field:SerializeField] public ADialogueStep[] Steps { get; set; }
    }
}