using UnityEngine;

namespace GameZone.Scripts
{
    public interface IGameZoneConfig
    {
        public int VerticalCount { get; }
        public int HorizontalCount { get; }
        public int offset { get; }
        public Vector3 StartPoint { get; }
    }
}