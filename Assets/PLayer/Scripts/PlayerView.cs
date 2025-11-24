using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        public Vector3 Position
       { 
           get=>_transform.position; 
           set=> _transform.position = value; 
       }

       [SerializeField] private Transform _transform;
    }
}