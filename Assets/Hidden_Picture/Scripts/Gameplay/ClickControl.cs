using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class ClickControl : MonoBehaviour
    {
        [SerializeField] private GameObject _particleSystem;
        private Button _character;

        private void Awake()
        {
            _character = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _character.onClick.AddListener(Founded);
        }

        private void OnDisable()
        {
            _character.onClick.RemoveListener(Founded);
        }

        private void CharacterFounded()
        {
            Destroy(gameObject);
            TimerController.TimeLeft += 15;
            CloneControl.End(CloneControl.NumberOfClone -= 1);
            ClickTrack.TotalClick = 0;
        }

        private async void Founded()
        {
            GameObject founded = Instantiate(_particleSystem);
            founded.transform.position = _character.transform.position;
            await Task.Delay(1500);
            CharacterFounded();
            await Task.Delay(3000);
            Destroy(founded);
        }
    }
}
