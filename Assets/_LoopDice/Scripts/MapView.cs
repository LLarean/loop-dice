using System;
using UnityEngine;
using UnityEngine.UI;

namespace LoopDice
{
    public class MapView : MonoBehaviour
    {
        [SerializeField] private GameObject _deckView;
        [Space]
        [SerializeField] private Button _menu;
        [SerializeField] private Button _main;
        [Space]
        [SerializeField] private Transform _unit;
        [SerializeField] private Transform[] _battlePoitns;

        private int _battleIndex = 0;
        private int _currentIndex = Int32.MinValue;
        private bool _canStart = true;
        
        private void Update()
        {
            if(_battleIndex == _currentIndex) return;
        }

        private void Start()
        {
            _menu.onClick.AddListener(MenuClick);
            _main.onClick.AddListener(MainClick);
        }

        private void OnDestroy()
        {
            _menu.onClick.RemoveAllListeners();
            _main.onClick.RemoveAllListeners();
        }

        private void MenuClick()
        {
        }

        private void MainClick()
        {
            if (_canStart == false) return;
            
            _deckView.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
