using UnityEngine;

namespace LoopDice
{
    public class View : MonoBehaviour
    {
        private Views _views;

        public void Initialize(Views views)
        {
            _views = views;
        }

        public void Show()
        {
            _views.HideAllViews();
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}