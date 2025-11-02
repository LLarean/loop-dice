using UnityEngine;
using UnityEngine.UI;

namespace LoopDice
{
    public class DeckView : MonoBehaviour
    {
        [SerializeField] private MapView _mapView;
        [Space]
        [SerializeField] private Button _back;
        [SerializeField] private Button _roll;

        private void Start()
        {
            _back.onClick.AddListener(Back);
            _roll.onClick.AddListener(Roll);
        }

        private void Back()
        {
            _mapView.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

        private void Roll()
        {
            throw new System.NotImplementedException();
        }
    }
}