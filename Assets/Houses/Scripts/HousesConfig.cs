using System;
using UnityEngine;

namespace Houses.Scripts
{
    [CreateAssetMenu(fileName = "HousesConfig", menuName = "configs/HousesConfig")]

    public class HousesConfig : ScriptableObject
    {
        [SerializeField] private houseModel[] houseModels;
    }
    
    
    [Serializable]
    public struct houseModel: IHousesConfig
    {
      [field: SerializeField] public Sprite Sprite { get;set; }
      [field: SerializeField] public int LvL { get;set; }
      [field: SerializeField] public int MaxLvL { get;set; }
      [field: SerializeField] public int UpgrateCost { get;set; }
      [field: SerializeField] public int Income { get;set; }
    }
}