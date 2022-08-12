using Assets.Hidden_Picture.Scripts.Gameplay;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Assets.Hidden_Picture.Scripts.Audio
{
    public class AudioController : MonoBehaviour
    {
        [SerializeField] private PlayerPref _playerAudioPref;
        [SerializeField] private AudioMixerGroup _masterGroup;
        [SerializeField] public Slider volumeSlider;

        private void OnEnable()
        {
            volumeSlider.onValueChanged.AddListener(_playerAudioPref.ChangeVolume);
        }

        private void OnDisable()
        {
            volumeSlider.onValueChanged.RemoveListener(_playerAudioPref.ChangeVolume);
        }

        private void Start()
        {
            if (!PlayerPrefs.HasKey("MasterVolume"))
            {
                PlayerPrefs.SetFloat("MasterVolume", 1);
                _playerAudioPref.LoadAudio();
            }
            else
                _playerAudioPref.LoadAudio();
        }
    }
}
