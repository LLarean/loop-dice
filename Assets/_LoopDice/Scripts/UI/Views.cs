using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LoopDice
{
    public class Views : MonoBehaviour
    {
        [SerializeField] private Canvas _root;
        [SerializeField] private List<View> _views;

        public void Initialize()
        {
            _views.ForEach(view => view.Initialize(this));
        }
        
        public bool Have<T>() where T : View
        {
            return _views.Any(view => view is T);
        }
        
        public T Get<T>() where T : View
        {
            return _views.FirstOrDefault(view => view is T) as T;
        }
        
        public void HideAllViews()
        {
            _views.ForEach(view => view.Hide());
        }

        private void Start()
        {
            if (_root == null)
            {
                throw new ArgumentNullException(nameof(_root), "Root Canvas is not set");
            }

            if (_views == null)
            {
                throw new ArgumentNullException(nameof(_views), "List<View> is NULL");
            }
        }
    }
}