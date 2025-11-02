using NaughtyAttributes;
using UnityEngine;

namespace LoopDice
{
    public class DiceFace : MonoBehaviour
    {
        [SerializeField] private GameObject _one;
        [SerializeField] private GameObject _two;
        [SerializeField] private GameObject _three;
        [SerializeField] private GameObject _four;
        [SerializeField] private GameObject _five;
        [SerializeField] private GameObject _six;

        [Button]
        public void ShowOne()
        {
            HideAll();
            _one.gameObject.SetActive(true);
        }
        
        [Button]
        public void ShowTwo()
        {
            HideAll();
            _two.gameObject.SetActive(true);
        }
        
        [Button]
        public void ShowThree()
        {
            HideAll();
            _three.gameObject.SetActive(true);
        }
        
        [Button]
        public void ShowFour()
        {
            HideAll();
            _four.gameObject.SetActive(true);
        }
        
        [Button]
        public void ShowFive()
        {
            HideAll();
            _five.gameObject.SetActive(true);
        }
        
        [Button]
        public void ShowSix()
        {
            HideAll();
            _six.gameObject.SetActive(true);
        }
        
        private void HideAll()
        {
            _one.gameObject.SetActive(false);
            _two.gameObject.SetActive(false);
            _three.gameObject.SetActive(false);
            _four.gameObject.SetActive(false);
            _five.gameObject.SetActive(false);
            _six.gameObject.SetActive(false);
        }
    }
}
