using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Audio
{
    public class AudioEffects: MonoBehaviour
    {
        [SerializeField] private AudioSource _hintSound;

        public void PlayHintSound()
        {
            _hintSound.Play();
        }
    }
}
