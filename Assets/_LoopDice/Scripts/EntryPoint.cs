using System;
using UnityEngine;

namespace LoopDice
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Views views;

        private void Start()
        {
            var temp = views.Have<MenuView>();

            if (views.Have<MenuView>())
            {
                var menuView = views.Get<MenuView>();
                menuView.Show();
            }
        }
    }
}