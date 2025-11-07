using System;
using UnityEngine;

namespace LoopDice
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private ViewHub _viewHub;

        private void Start()
        {
            _viewHub.TryGetView<MenuView>(out var menuView);
            menuView.Show();
        }
    }
}