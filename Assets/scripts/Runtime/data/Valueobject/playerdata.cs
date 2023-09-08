using System;

namespace Runtime.data.Valueobject
{
    [Serializable]
    public struct playerdata
    {
        public playermovementdata movementdata; 
    }

    [Serializable]
    public struct playermovementdata
    {
        public float speed;
    }

}