using Internal.Runtime.Dialogues.Steps;
using TMPro;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class ChangeNameHandler : ADialogueElementHandler<ChangeNameStep>
    {
        private TextMeshProUGUI _nameContainer;
        
        public ChangeNameHandler(TextMeshProUGUI nameContainer)
        {
            _nameContainer = nameContainer;
        }

        protected override void Handle(ChangeNameStep step)
        {
            _nameContainer.text = step.Name;
        }
    }
}