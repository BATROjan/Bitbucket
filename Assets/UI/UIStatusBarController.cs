using System.Collections.Generic;
using System.Linq;
using PlayerInputSystem;
using VContainer.Unity;

namespace UI
{
    public class UIStatusBarController: IUIStatusBarController , ITickable
    {
        private readonly IInputSystem _keyboardInputSystem;
        private readonly UIStatusbar _uiStatusbar;
        private List<UIIconElement> _iconElements = new();
        
        public UIStatusBarController(
            IUIStatusBar uiStatusbar,
            IInputSystem keyboardInputSystem
            )
        {
            _keyboardInputSystem = keyboardInputSystem;
            _uiStatusbar = (UIStatusbar)uiStatusbar;
            _keyboardInputSystem.OnGetIconID += ChangeCurrentIcon;
            _iconElements = _uiStatusbar.GetElements().ToList();
        }

        private void ChangeCurrentIcon(int value)
        {
            foreach (var icon in _iconElements)
            {
                if (icon.ID == value)
                {
                    icon.Image.gameObject.SetActive(false);
                }
                else
                {
                    icon.Image.gameObject.SetActive(true);
                }
            }
        }

        public void Tick()
        {
        }
    }
}