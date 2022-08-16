using Assets.Hidden_Picture.Scripts.Gameplay;
using TMPro;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.UI
{
    public class HintsView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _hints;
        [SerializeField] private HintsCounter _hintsCounter;

        private void OnEnable()
        {
            _hintsCounter.HintsChange += UpdateNumberOfHints;
        }

        private void OnDisable()
        {
            _hintsCounter.HintsChange -= UpdateNumberOfHints;
        }

        private void Start()
        {
            UpdateNumberOfHints();
        }

        public void UpdateNumberOfHints()
        {
            _hints.text = _hintsCounter.Counter.ToString();
        }
    }
}
