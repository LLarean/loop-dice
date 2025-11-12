using UnityEngine;

namespace LoopDice
{
    public class AudioPlayer : MonoBehaviour
    {
        public static AudioPlayer Instance { get; private set; }

        [SerializeField] private AudioSource _sound;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    
        public void PlaySound(AudioClip clip)
        {
            _sound.PlayOneShot(clip);
        }
    }
}
