using System;
using UnityEngine;
using UnityEngine.UI;

namespace LoopDice
{
    public class MenuView : View
    {
        [SerializeField] private Button _mute;
        [SerializeField] private Button _leaderboard;
        [SerializeField] private Button _newGame;

        private void Start()
        {
            _mute.onClick.AddListener(Mute);
            _leaderboard.onClick.AddListener(Leaderboard);
            _newGame.onClick.AddListener(NewGame);
        }

        private void OnDestroy()
        {
            _mute.onClick.RemoveAllListeners();
            _leaderboard.onClick.RemoveAllListeners();
            _newGame.onClick.RemoveAllListeners();
        }

        private void Mute()
        {
            throw new NotImplementedException();
        }

        private void Leaderboard()
        {
            throw new NotImplementedException();
        }

        private void NewGame()
        {
            if (!_views.Have<GameTableView>()) return;
            
            var gameTableView = _views.Get<GameTableView>();
            gameTableView.Show();
        }
    }
}