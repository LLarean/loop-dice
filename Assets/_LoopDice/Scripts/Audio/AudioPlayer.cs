using UnityEngine;

namespace LoopDice
{
    public class AudioPlayer : MonoBehaviour
    {
        public static AudioPlayer Instance { get; private set; }

        [SerializeField] private AudioSource _sound;
        [SerializeField] private AudioClip _rollDice;
        
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
    
        public void PlayRollDice()
        {
            _sound.PlayOneShot(_rollDice);
        }
    }
}
