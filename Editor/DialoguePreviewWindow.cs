using System;
using Internal.Runtime.Dialogues.Core;
using Internal.Runtime.Dialogues.Steps;
using UnityEditor;

namespace Internal.Editor
{
    [CustomEditor(typeof(Dialogue))]
    public class DialoguePreviewWindow : UnityEditor.Editor
    {
        private bool _shouldDrawCustom;
        private int _currentElement;
        private Dialogue _dialogue;
        
        public override void OnInspectorGUI()
        {
            if (ShouldDrawCustom())
            {
                CacheDialogue();
                DrawCustomDialogue();
            }
            else
            {
                base.OnInspectorGUI();
            }

            if (LocalGUIUtilities.Button("Toggle Custom Drawing"))
            {
                ToggleCustomDrawing();
            }
        }

        private void DrawCustomDialogue()
        {
            DrawAllSteps(DrawStep);

            EditorGUILayout.BeginHorizontal();
            
            if (LocalGUIUtilities.Button("Previous", IsPreviousAvailable))
            {
                GoToPrevious();
            }
            
            if (LocalGUIUtilities.Button("Next", IsNextAvailable))
            {
                GoToNext();
            }
            
            EditorGUILayout.EndHorizontal();
        }

        private void DrawStep(ADialogueStep step)
        {
            switch (step)
            {
                case ChangeNameStep typedStep:
                    EditorGUILayout.LabelField("Name", typedStep.Name);
                    break;
                case ChangeIconStep typedStep:
                    LocalGUIUtilities.DrawSprite(typedStep.Icon);
                    break;
                case ChangeNameAndIconStep typedStep:
                    EditorGUILayout.LabelField("Name", typedStep.Name);
                    LocalGUIUtilities.DrawSprite(typedStep.Icon);
                    break;
                case ChangeTextStep typedStep:
                    EditorGUILayout.LabelField("Text", typedStep.Text);
                    break;
                case RaiseCallbackStep typedStep:
                    EditorGUILayout.LabelField("Raise Callback", typedStep.name);
                    break;
                case CameraTransitionStep typedStep:
                    EditorGUILayout.LabelField("ToggleCamera", typedStep.name);
                    break;
            }
        }

        private void DrawAllSteps(Action<ADialogueStep> drawCallback)
        {
            foreach (ADialogueStep step in _dialogue.Elements[_currentElement].Steps)
            {
                drawCallback.Invoke(step);
            }
        }

        private bool ShouldDrawCustom() => _shouldDrawCustom;

        private void ToggleCustomDrawing()
        {
            _shouldDrawCustom = !_shouldDrawCustom;
            _currentElement = 0;
        }

        private void CacheDialogue() => _dialogue = (Dialogue)target;

        private bool IsNextAvailable() => _currentElement < _dialogue.Elements.Length - 1;

        private bool IsPreviousAvailable() => _currentElement > 0;

        private void GoToNext() => _currentElement++;
        
        private void GoToPrevious() => _currentElement--;
    }
}