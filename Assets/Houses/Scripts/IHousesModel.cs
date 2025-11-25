using UnityEngine;

namespace Houses.Scripts
{
    public interface IHousesModel
    {
        Sprite Sprite { get; }
        int LvL { get; }
        int MaxLvL { get; }
        int UpgrateCost { get; }
        int Income { get; }
    }
}