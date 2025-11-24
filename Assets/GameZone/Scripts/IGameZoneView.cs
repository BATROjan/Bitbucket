using System;
using UnityEngine;

namespace GameZone.Scripts
{
    public interface IGameZoneView
    {
        Action<Vector3> OnSpawned { get; set; }
    }
}