using DefaultNamespace;
using GameZone.Scripts;
using Houses;
using Houses.Scripts;
using PlayerInputSystem;
using UI;
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
    [SerializeField] private HouseView _houseView;
    [SerializeField] private UIStatusbar _uiStatusbar;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<IInputSystem, KeyboardInputSystem>(Lifetime.Singleton);
        builder.Register<ICellController, CellController>(Lifetime.Singleton);
      //  builder.Register<IUIStatusBarController, UIStatusBarController>(Lifetime.Singleton);
        
        builder.RegisterComponent(_cellView).As<ICellView>(); 
        builder.RegisterComponent(_gameZoneView).As<IGameZoneView>();
        builder.RegisterComponent(_playerView).As<IPlayerView>();
        builder.RegisterComponent(_houseView).As<IHouseView>();
        builder.RegisterComponent(_uiStatusbar).As<IUIStatusBar>();
        
        builder.RegisterInstance(_gameZoneConfig).As<IGameZoneConfig>();
        builder.RegisterInstance(_controllConfig).As<IControllConfigs>();
        
        /*foreach (var element in _uiStatusbar.GetElements())
        {
            builder.RegisterComponent(element).As<IUIElement>();
        }*/
        builder.UseEntryPoints(config =>
        {
            config.Add<GameZoneController>();
            config.Add<PlayerController>();
            config.Add<MouseInputSystem>();
            config.Add<UIStatusBarController>();
        });
    }
}
