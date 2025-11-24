using System;
using System.Buffers;
using UnityEngine;
using VContainer;

namespace GameZone.Scripts
{
    public class GameZoneView: MonoBehaviour, IGameZoneView
    {
        public Action<Vector3> OnSpawned { get; set; }
        private void Awake()
        {
            OnSpawned?.Invoke(transform.position);
        }
    }
}