using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace LoopDice
{
    public class DeckView : MonoBehaviour
    {
        [SerializeField] private MapView _mapView;
        [Space]
        [SerializeField] private Button _back;
        [SerializeField] private Button _roll;
        [SerializeField] private TMP_Text _rollLabel;
        [Space]
        [SerializeField] private DiceFace[] _diceFaces;

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
            List<int> results = new List<int>();
            Random random = new Random();

            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));
            results.Add(random.Next(6));

            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] == 1)
                {
                    _diceFaces[i].ShowOne();
                }
                else if (results[i] == 2)
                {
                    _diceFaces[i].ShowTwo();
                }
                else if (results[i] == 3)
                {
                    _diceFaces[i].ShowThree();
                }
                else if (results[i] == 4)
                {
                    _diceFaces[i].ShowFour();
                }
                else if (results[i] == 5)
                {
                    _diceFaces[i].ShowFive();
                }
                else if (results[i] == 6)
                {
                    _diceFaces[i].ShowSix();
                }
            }

            _rollLabel.text = "Roll Selected";
        }
    }
}