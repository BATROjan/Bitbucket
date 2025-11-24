using DefaultNamespace;
using GameZone.Scripts;
using PlayerInputSystem;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] private GameZoneConfig _gameZoneConfig;
    [SerializeField] private ControllConfig _controllConfig;

    [SerializeField] private GameZoneView _gameZoneView;
    [SerializeField] private CellView _cellView;
    [SerializeField] private PlayerView _playerView;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<IInputSystem, KeyboardInputSystem>(Lifetime.Singleton);
        builder.Register<ICellController, CellController>(Lifetime.Singleton);
        
        builder.RegisterComponent(_cellView).As<ICellView>(); 
        builder.RegisterComponent(_gameZoneView).As<IGameZoneView>();
        builder.RegisterComponent(_playerView).As<IPlayerView>();
        
        builder.RegisterInstance(_gameZoneConfig).As<IGameZoneConfig>();
        builder.RegisterInstance(_controllConfig).As<IControllConfigs>();
        
        builder.UseEntryPoints(config =>
        {
            config.Add<GameZoneController>();
            config.Add<PlayerController>();
        });
    }
}
