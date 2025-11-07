using System;
using System.Collections.Generic;
using UnityEngine;

namespace LoopDice
{
    public class ViewHub : MonoBehaviour
    {
        private readonly List<View> _createdViews = new();

        [SerializeField]
        private Canvas _root;

        public bool TryGetView<T>(out T viewName) where T : View
        {
            viewName = null;
            
            if (TryGetCreatedView(ref viewName) == true) return true;

            if (TryInstantiateNewView(viewName) == false) return false;
            
            return TryGetCreatedView(ref viewName);
        }

        public void HideAllViews()
        {
            foreach (var createdView in _createdViews)
            {
                createdView.Hide();
            }
        }

        private void Start()
        {
            if (_root == null)
            {
                throw new ArgumentNullException(nameof(_root), "Root Canvas is not set");
            }
        }

        private bool TryGetCreatedView<T>(ref T viewName) where T : View
        {
            foreach (var view in _createdViews)
            {
                viewName = view as T;

                if (viewName != null)
                {
                    return true;
                }
            }

            return false;
        }

        private bool TryInstantiateNewView<T>(T view) where T : View
        {
            bool isSuccess = TryLoadViewFromResources(out view);

            if (isSuccess == true)
            {
                InstantiateView(view);
            }
            else
            {
                Debug.LogError($"Prefab with name {typeof(T).Name} not found in Resources folder.");
            }
            
            return isSuccess;
        }

        private bool TryLoadViewFromResources<T>(out T view) where T : View
        {
            view = null;
            string prefabName = typeof(T).Name;
            string path = $"Views/{prefabName}";

            view = Resources.Load<T>(path);
            
            return view != null;
        }

        private void InstantiateView(View newView)
        {
            View view = Instantiate(newView, _root.transform);

            view.Initialize(this);
            view.Hide();
            
            _createdViews.Add(view);
        }
    }
}