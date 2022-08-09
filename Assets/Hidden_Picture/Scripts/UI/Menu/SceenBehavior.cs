using UnityEngine;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.UI.Menu
{
    public class SceenBehavior : MonoBehaviour
    {
        [SerializeField] private Button _pauseButton;
        [SerializeField] private PauseMenu _pauseMenu;

        private void OnEnable()
        {
            _pauseButton.onClick.AddListener(_pauseMenu.PauseGame);
        }

        private void OnDisable()
        {
            _pauseButton.onClick.RemoveListener(_pauseMenu.PauseGame);
        }
    }
}
