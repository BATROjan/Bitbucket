using UnityEngine;

namespace GameZone.Scripts
{
    public interface ICellView
    {
        bool IsFeel { get; }
        SpriteRenderer SpriteRenderer { get; }
        BoxCollider2D BoxCollider2D { get; }
    }
}