using UnityEngine;

namespace LoopDice
{
    public class GameTablePresenter
    {
        private readonly GameTableModel _model;
        private readonly GameTableView _view;

        public GameTablePresenter(GameTableModel model, GameTableView view)
        {
            _model = model;
            _view = view;
        }
    }
}
