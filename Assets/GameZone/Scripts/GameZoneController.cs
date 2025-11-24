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
        private readonly GameZoneConfig _gameZoneConfig;
        private readonly GameZoneView _gameZoneView;
        private readonly Transform _spawnPoint;
        
        public GameZoneController(
            IGameZoneConfig config,
            ICellController cellController,
           IGameZoneView gameZoneView
          )
        {
            _gameZoneView = (GameZoneView)gameZoneView;
            _gameZoneConfig = (GameZoneConfig)config;
            _cellController = (CellController)cellController;

            _gameZoneView.OnSpawned += SpawnZone;
        }

        public void SpawnZone(Vector3 position)
        { 
            var currentPoint = _gameZoneConfig.StartPoint;
            var offset = _gameZoneConfig.offset;
            for (int i = 0; i < _gameZoneConfig.HorizontalCount; i++)
            {
                currentPoint.x =  i*offset;
                
                for (int j = 0; j < _gameZoneConfig.HorizontalCount; j++)
                {
                    currentPoint.y =  j*offset;
                    _cellController.SpawnCell(_gameZoneView.transform, currentPoint);
                }
            }
        }

        public void DespawnZone(GameZoneView view)
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
        }
    }
}