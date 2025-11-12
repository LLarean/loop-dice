using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace LoopDice
{
    public class DiceFace : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [Space]
        [SerializeField] private Image _image;
        [SerializeField] private Sprite[] _dice;
        [SerializeField] private Sprite[] _diceBorder;

        private int _valueIndex;
        private bool _isPressed;

        public void ShowValue(int valueIndex)
        {
            _valueIndex = valueIndex;
            _image.sprite = _dice[valueIndex];
        }

        [Button]
        private void ShowOne() => ShowValue(0);

        [Button]
        private void ShowTwo() => ShowValue(1);

        [Button]
        private void ShowThree() => ShowValue(2);

        [Button]
        private void ShowFour() => ShowValue(3);

        [Button]
        private void ShowFive() => ShowValue(4);

        [Button]
        private void ShowSix() => ShowValue(5);

        private void Start()
        {
            _button.onClick.AddListener(Click);
        }

        private void Click()
        {
            var dice = _isPressed ? _dice[_valueIndex] : _diceBorder[_valueIndex];
            _image.sprite = dice;
            _isPressed = !_isPressed;
        }
    }
}