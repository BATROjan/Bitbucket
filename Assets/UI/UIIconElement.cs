using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIIconElement: MonoBehaviour, IUIElement
    {
       [field:SerializeField] public Image Image { get; set; }
       [field:SerializeField] public int ID { get; set; }
    }
}