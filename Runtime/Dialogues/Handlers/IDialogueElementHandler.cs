using Internal.Runtime.Dialogues.Steps;

namespace Internal.Runtime.Dialogues.Handlers
{
    public interface IDialogueElementHandler
    {
        void Handle(ADialogueStep step);
    }
}