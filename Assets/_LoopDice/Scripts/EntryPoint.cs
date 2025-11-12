using UnityEngine;

namespace LoopDice
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Views _views;
        [SerializeField] private AudioPlayer _audioPlayer;

        private void Start()
        {
            _views.Initialize();

            if (_views.Have<GameTableView>())
            {
                var gameTableView = _views.Get<GameTableView>();
                gameTableView.SetAudioPlayer(_audioPlayer);
            }
            
            if (!_views.Have<MenuView>()) return;
            
            var menuView = _views.Get<MenuView>();
            menuView.Show();
        }
    }
}