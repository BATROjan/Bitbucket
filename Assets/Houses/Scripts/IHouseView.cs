using UnityEngine;

namespace Houses
{
    public interface IHouseView
    {
        SpriteRenderer SpriteRenderer { get; }
        BoxCollider2D BoxCollider2D { get; }
    }
}