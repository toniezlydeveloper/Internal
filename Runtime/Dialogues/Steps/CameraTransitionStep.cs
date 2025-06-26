#if CINEMACHINE
using Cinemachine;
#endif
using UnityEngine;

namespace Internal.Runtime.Dialogues.Steps
{
    [CreateAssetMenu(menuName = "Dialogue/Camera Transition")]
    public class CameraTransitionStep : ADialogueStep
    {
#if CINEMACHINE
        [SerializeField] private CinemachineBlendDefinition.Style blendStyle;
        [SerializeField] private float duration;

        private CinemachineVirtualCameraBase[] _otherCameras;
        private CinemachineVirtualCameraBase _targetCamera;
        
        public void Init(CinemachineVirtualCameraBase[] otherCameras, CinemachineVirtualCameraBase targetCamera)
        {
            _otherCameras = otherCameras;
            _targetCamera = targetCamera;
        }
        
        public void Apply()
        {
            foreach (CinemachineVirtualCameraBase otherCamera in _otherCameras)
            {
                otherCamera.Priority = 0;
            }

            _targetCamera.Priority = 1;
        }
#endif
    }
}