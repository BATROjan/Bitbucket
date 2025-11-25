using UnityEngine;
using UnityEngine.UI;

namespace DragObjects
{
    public interface IDragObject
    {
        SpriteRenderer SpriteRenderer{ get; }
        Transform Transform { get; }
        int id{ get; }
    }
}