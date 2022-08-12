using Assets.Hidden_Picture.Scripts.Gameplay;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Hidden_Picture.Input
{
    public class InputManager : MonoBehaviour
    {
        private TouchInput _touchInput;

        private void Awake()
        {
            _touchInput = new TouchInput();
        }

        private void OnEnable()
        {
            _touchInput.Enable();
        }

        private void OnDisable()
        {
            _touchInput.Disable();
        }

        private void Start()
        {
            _touchInput.Touch.TouchPress.started += ctx => StartTouching(ctx);
        }

        private void StartTouching(InputAction.CallbackContext context)
        {
            ClickTrack.TotalClick += 1;
        }
    }
}
