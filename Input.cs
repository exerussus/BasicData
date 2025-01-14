using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace Exerussus.EasyEcsModules.BasicData
{
    public static class InputData
    {
        public struct MovingDirection : IEcsComponent { public Vector2 Value; }
        public struct LookingDirection : IEcsComponent { public Vector2 Value; }
    }
}