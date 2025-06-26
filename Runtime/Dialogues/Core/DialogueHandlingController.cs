using System;
using System.Collections.Generic;
using Internal.Runtime.Dialogues.Handlers;
using Internal.Runtime.Dialogues.Steps;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Internal.Runtime.Dialogues.Core
{
    // Extremely simplified, without the dialogue options.
    public class DialogueHandlingController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textContainer;
        [SerializeField] private TextMeshProUGUI nameContainer;
        [SerializeField] private Image iconContainer;

        private Dictionary<Type, IDialogueElementHandler> _handlerByStepTypes = new()
        {
            { typeof(CameraTransitionStep), new CameraTransitionHandler() },
            { typeof(RaiseCallbackStep), new RaiseCallbackHandler() }
        };

        private void Start()
        {
            _handlerByStepTypes.Add(typeof(ChangeNameAndIconStep), new ChangeNameAndIconHandler(nameContainer, iconContainer));
            _handlerByStepTypes.Add(typeof(ChangeIconStep), new ChangeIconHandler(iconContainer));
            _handlerByStepTypes.Add(typeof(ChangeNameStep), new ChangeNameHandler(nameContainer));
            _handlerByStepTypes.Add(typeof(ChangeTextStep), new ChangeTextHandler(textContainer));
        }

        public void HandleElement(DialogueElement element)
        {
            foreach (ADialogueStep step in element.Steps)
            {
                _handlerByStepTypes[step.GetType()].Handle(step);
            }
        }
    }
}