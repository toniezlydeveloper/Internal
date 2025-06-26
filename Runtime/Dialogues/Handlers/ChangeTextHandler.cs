using Internal.Runtime.Dialogues.Steps;
using TMPro;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class ChangeTextHandler : ADialogueElementHandler<ChangeTextStep>
    {
        private TextMeshProUGUI _textContainer;
        
        public ChangeTextHandler(TextMeshProUGUI textContainer)
        {
            _textContainer = textContainer;
        }


        protected override void Handle(ChangeTextStep step)
        {
            _textContainer.text = step.Text;
        }
    }
}