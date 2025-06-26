using Cinemachine;
using Internal.Runtime.Dialogues.Steps;
using UnityEngine;

namespace Internal.Runtime.Dialogues.Handlers.Initializers
{
    public class CameraTransitionInitializer : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCameraBase[] otherCameras;
        [SerializeField] private CinemachineVirtualCameraBase targetCamera;
        [SerializeField] private CameraTransitionStep transitionStep;

        private void Start() => transitionStep.Init(otherCameras, targetCamera);
    }
}