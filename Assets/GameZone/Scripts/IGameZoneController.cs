using UnityEngine;

namespace GameZone.Scripts
{
    public interface IGameZoneController
    {
        void SpawnZone(Vector3 position);
        void DespawnZone(GameZoneView view);
    }
}