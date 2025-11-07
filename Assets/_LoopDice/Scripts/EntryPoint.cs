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
}