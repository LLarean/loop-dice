using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace LoopDice
{
    public class GameTableView : View
    {
        [SerializeField] private MapView _mapView;
        [Space]
        [SerializeField] private Button _back;
        [SerializeField] private Button _roll;
        [SerializeField] private TMP_Text _rollLabel;
        [Space]
        [SerializeField] private DiceFace[] _diceFaces;

        private AudioPlayer _audioPlayer;

        public void SetAudioPlayer(AudioPlayer audioPlayer)
        {
            _audioPlayer = audioPlayer;
        }
        
        private void Start()
        {
            _back.onClick.AddListener(Back);
            _roll.onClick.AddListener(Roll);
            _rollLabel.text = "Roll All";
        }

        private void Back()
        {
            _mapView.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

        private void Roll()
        {
            _audioPlayer.PlayRollDice();
            
            List<int> results = new List<int>();
            Random random = new Random();

            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));

            for (int i = 0; i < results.Count; i++)
            {
                var valueIndex = results[i] - 1;
                
                if (valueIndex is >= 0 and < 6)
                {
                    if (_diceFaces[i].IsPressed == true)
                    {
                        _diceFaces[i].ShowValue(valueIndex);
                    }
                }
            }

            _rollLabel.text = "Roll Selected";
        }
        
    }
}