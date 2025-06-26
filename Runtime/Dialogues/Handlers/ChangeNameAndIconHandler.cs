using Internal.Runtime.Dialogues.Steps;
using TMPro;
using UnityEngine.UI;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class ChangeNameAndIconHandler : ADialogueElementHandler<ChangeNameAndIconStep>
    {
        private TextMeshProUGUI _nameContainer;
        private Image _iconContainer;
        
        public ChangeNameAndIconHandler(TextMeshProUGUI nameContainer, Image iconContainer)
        {
            _nameContainer = nameContainer;
            _iconContainer = iconContainer;
        }

        protected override void Handle(ChangeNameAndIconStep step)
        {
            _iconContainer.sprite = step.Icon;
            _nameContainer.text = step.Name;
        }
    }
}