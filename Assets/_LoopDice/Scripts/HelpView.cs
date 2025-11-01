using UnityEngine;
using UnityEngine.UI;

namespace LoopDice
{
    public class HelpView : MonoBehaviour
    {
        [SerializeField] private Button _back;

        private void Start()
        {
            _back.onClick.AddListener(Hide);
        }

        private void OnDestroy()
        {
            _back.onClick.RemoveAllListeners();
        }

        private void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
