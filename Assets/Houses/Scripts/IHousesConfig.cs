using UnityEngine;

namespace Houses.Scripts
{
    public interface IHousesConfig
    {
        Sprite Sprite { get; }
        int LvL { get; }
        int MaxLvL { get; }
        int UpgrateCost { get; }
        int Income { get; }
    }
}