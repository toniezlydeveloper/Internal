using Internal.Runtime.Dialogues.Steps;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class RaiseCallbackHandler : ADialogueElementHandler<RaiseCallbackStep>
    {
        protected override void Handle(RaiseCallbackStep step)
        {
            step.Raise();
        }
    }
}