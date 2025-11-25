using UnityEngine;

namespace UI
{
    public class UIStatusbar: MonoBehaviour, IUIStatusBar
    {
        [SerializeField] private UIIconElement[] iconElements;

        public UIIconElement[] GetElements()
        {
            return iconElements;
        }
    }
}