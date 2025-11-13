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

        public void Subsribe()
        {
            _view.OnBackClick += ToMenu;
            _view.OnMainClick += MainAction;
        }

        private void ToMenu()
        {
            throw new System.NotImplementedException();
        }

        private void MainAction()
        {
            throw new System.NotImplementedException();
        }
    }
}
