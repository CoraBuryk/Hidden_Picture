using Assets.Hidden_Picture.Scripts.Gameplay;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Input
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] ClickTrack _clickTrack;
        [SerializeField] CanvasScaler _canvasScaler;
        private float _cameraSpeed = 4f;
        private TouchInput _touchInput;
        private Coroutine _zoomcoroutine;
        private Transform _cameraTransform;

        private void Awake()
        {
            _touchInput = new TouchInput();
            _cameraTransform = Camera.main.transform;
            Camera.main.orthographicSize = 4.8f;
            _canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;         
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

            _touchInput.Touch.SecondaryTouchContact.started += ctx => ZoomStart(ctx);
            _touchInput.Touch.SecondaryTouchContact.canceled += ctx => ZoomEnds(ctx);
        }

        private void StartTouching(InputAction.CallbackContext context)
        {
            _clickTrack.ignoreUI = false;
            _clickTrack.Click(false);
            Debug.Log(_clickTrack.ignoreUI);                    
        }

        private void ZoomStart(InputAction.CallbackContext context)
        {
            _zoomcoroutine = StartCoroutine(ZoomDetection());
            _clickTrack.Click(true);
        }

        private void ZoomEnds(InputAction.CallbackContext context)
        {
            StopCoroutine(_zoomcoroutine);
            _clickTrack.Click(true);
        }

        IEnumerator ZoomDetection()
        {
            float previousDistance = 0f;
            float distance = 0f;

            while (true)
            {
                distance = Vector2.Distance(_touchInput.Touch.PrimaryTouchPosition.ReadValue<Vector2>(),
                    _touchInput.Touch.SecondaryTouchPosition.ReadValue<Vector2>());

                if (distance > previousDistance)
                {
                    if (Camera.main.orthographicSize > 2.8f)
                    {
                        Vector3 targetPosition = _cameraTransform.position;
                        targetPosition.z -= 1;
                        _cameraTransform.position = Vector3.Slerp(_cameraTransform.position, targetPosition,
                                    Time.deltaTime * _cameraSpeed);

                        Camera.main.orthographicSize -= 0.2f;
                    }
                }
                else if (distance < previousDistance)
                {
                    if (Camera.main.orthographicSize < 4.8f)
                    {
                        Vector3 targetPosition = _cameraTransform.position;
                        targetPosition.z += 1;
                        _cameraTransform.position = Vector3.Slerp(_cameraTransform.position, new Vector3(0, 0, 0),
                                    Time.deltaTime * _cameraSpeed);

                        Camera.main.orthographicSize += 0.2f;
                    }
                }
                previousDistance = distance;
                yield return null;
            }
        }
    }
}