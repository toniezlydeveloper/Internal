using Internal.Runtime.Dialogues.Steps;

namespace Internal.Runtime.Dialogues.Handlers
{
    public abstract class ADialogueElementHandler<TStep> : IDialogueElementHandler where TStep : ADialogueStep
    {
        public void Handle(ADialogueStep step) => Handle((TStep)step);

        protected abstract void Handle(TStep step);
    }
}