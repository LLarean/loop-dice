using UnityEngine;

namespace LoopDice
{
    public class View : MonoBehaviour
    {
        private ViewHub _viewHub;

        public void Initialize(ViewHub viewHub)
        {
            _viewHub = viewHub;
        }

        public void Show()
        {
            _viewHub.HideAllViews();
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}