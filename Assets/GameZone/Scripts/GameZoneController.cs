using UnityEngine;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;
using Vector2 = System.Numerics.Vector2;

namespace GameZone.Scripts
{
    public class GameZoneController : IGameZoneController, ITickable
    {
        private readonly CellController _cellController;
        private readonly GameZoneView _gameZoneView;
        private readonly Transform _spawnPoint;
        
        public GameZoneController(
           ICellController cellController,
           IGameZoneView gameZoneView
          )
        {
            _gameZoneView = (GameZoneView)gameZoneView;
            _gameZoneView.OnSpawned += SpawnZone;
            _cellController = (CellController)cellController;
        }

        public void SpawnZone(Vector3 position)
        {
            _cellController.SpawnCell(_gameZoneView.transform);
        }

        public void DespawnZone(GameZoneView view)
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
            Debug.Log("AAAAAAAAAa");
        }
    }
}