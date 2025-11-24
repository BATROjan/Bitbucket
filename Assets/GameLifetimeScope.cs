using GameZone.Scripts;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] private GameZoneConfig gameZoneConfig;
    [SerializeField] private GameZoneView gameZoneView;
    
    [SerializeField] private CellView _cellView;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<ICellController, CellController>(Lifetime.Singleton);
        builder.RegisterComponent(_cellView).As<ICellView>();
        
        //builder.Register<IGameZonePresenter, GameZonePresenter>(Lifetime.Singleton);
        builder.RegisterInstance(gameZoneConfig).As<IGameZoneSetting>();
        
        builder.RegisterComponent(gameZoneView).As<IGameZoneView>();

        
        builder.UseEntryPoints(config =>
        {
            config.Add<GameZoneController>();
        });
    }
}
