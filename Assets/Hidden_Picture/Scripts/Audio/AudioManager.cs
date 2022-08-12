using UnityEngine;

namespace Assets.Hidden_Picture.Scripts.Audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance
        {
            get { return instance; }
        }

        private static AudioManager instance = null;

        private void Awake()
        {
            if (instance)
            {
                DestroyImmediate(this.gameObject);
                return;
            }
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }
}
