using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace LoopDice.Core
{
    public class Dice : MonoBehaviour
    {
        private const int MinimumValue = 1;
        private const int MaximumValue = 6;
        
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _checkmark;
        [Space]
        [SerializeField] private GameObject[] _diceFaces;

        public event Action OnDiceClicked;
        
        private int _currentValue = MinimumValue;
        public int CurrentValue() => _currentValue;
        public bool IsSelected => _checkmark.activeSelf;

        public void EnableInteractable() => _button.interactable = true;
        
        public void DisableInteractable() => _button.interactable = false;
        
        [Button]
        public void Roll()
        {
            if(_checkmark.activeSelf == false) return;
            
            _currentValue = Random.Range(MinimumValue, MaximumValue);
            Debug.Log($"Dice rolled: {_currentValue}");
            DisableAllFaces();
            _diceFaces[_currentValue - 1].gameObject.SetActive(true);
        }

        private void DisableAllFaces()
        {
            foreach (var diceFace in _diceFaces)
            {
                diceFace.gameObject.SetActive(false);
            }
        }

        private void Start()
        {
            _button.onClick.AddListener(DiceClick);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveAllListeners();
        }

        private void DiceClick() => _checkmark.gameObject.SetActive(!_checkmark.activeSelf);
    }
}