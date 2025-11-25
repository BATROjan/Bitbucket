using System;
using UnityEngine;

namespace Houses.Scripts
{
    [CreateAssetMenu(fileName = "HousesConfig", menuName = "configs/HousesConfig")]

    public class HousesConfig : ScriptableObject, IHouseConfig
    {
        [SerializeField] private HouseModel[] houseModels;
        public HouseModel GetModelById(int iD)
        {
            return houseModels[iD];
        }
    }
    
    
    [Serializable]
    public struct HouseModel: IHousesModel
    {
      [field: SerializeField] public Sprite Sprite { get;set; }
      [field: SerializeField] public int LvL { get;set; }
      [field: SerializeField] public int MaxLvL { get;set; }
      [field: SerializeField] public int UpgrateCost { get;set; }
      [field: SerializeField] public int Income { get;set; }
    }
}