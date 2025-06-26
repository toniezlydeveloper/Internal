using Internal.Runtime.Dialogues.Steps;

namespace Internal.Runtime.Dialogues.Handlers
{
    public class CameraTransitionHandler : ADialogueElementHandler<CameraTransitionStep>
    {
        protected override void Handle(CameraTransitionStep step)
        {
            step.Apply();
        }
    }
}