using UnityEngine.UI;

namespace UI
{
    public interface IUIElement
    {
        Image Image { get; }
        int ID { get; }
    }
}