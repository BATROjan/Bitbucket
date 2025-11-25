using UnityEngine;

namespace Houses
{
    public interface IHouseView
    {
        SpriteRenderer SpriteRenderer { get; }
        Transform Transform { get; }
        BoxCollider2D BoxCollider2D { get; }
    }
}