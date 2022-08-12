using Assets.Hidden_Picture.Scripts.Audio;
using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Gameplay
{
    public class PlayerPref : MonoBehaviour
    {
        [SerializeField] private AudioController _audioController;

        public void LoadAudio()
        {
            _audioController.volumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        }

        public void SaveAudio()
        {
            PlayerPrefs.SetFloat("MasterVolume", _audioController.volumeSlider.value);
        }

        public void ChangeVolume(float volume)
        {
            AudioListener.volume = _audioController.volumeSlider.value;
            SaveAudio();
        }
    }
}
