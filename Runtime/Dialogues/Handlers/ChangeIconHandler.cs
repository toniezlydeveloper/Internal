using Internal.Runtime.Dialogues.Steps;
using UnityEngine.UI;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class ChangeIconHandler : ADialogueElementHandler<ChangeIconStep>
    {
        private Image _iconContainer;
        
        public ChangeIconHandler(Image iconContainer)
        {
            _iconContainer = iconContainer;
        }

        protected override void Handle(ChangeIconStep step)
        {
            _iconContainer.sprite = step.Icon;
        }
    }
}