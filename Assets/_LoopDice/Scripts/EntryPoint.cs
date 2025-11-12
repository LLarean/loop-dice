using UnityEngine;

namespace LoopDice
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Views _views;

        private void Start()
        {
            _views.Initialize();
            
            if (!_views.Have<MenuView>()) return;
            
            var menuView = _views.Get<MenuView>();
            menuView.Show();
        }
    }

    public class MainPresenter
    {
        private readonly Views _views;

        public MainPresenter(Views views)
        {
            _views = views;
        }

        public void ShowFirstScree()
        {
            _views.Initialize();
            
            if (!_views.Have<MenuView>()) return;
            
            var menuView = _views.Get<MenuView>();
            menuView.Show();
        }
    }
}