using Runtime.data.Valueobject;
using UnityEngine;

namespace Runtime.data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_PLAYER", menuName = "TestGame/CD_PLAYER", order = 0)]
    public class CD_PLAYER : ScriptableObject
    {
        public playerdata data; 
    }
}