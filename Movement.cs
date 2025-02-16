using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace Exerussus.EasyEcsModules.BasicData
{
    public static class MovementData
    {
        /// <summary> В какой текущей точке находится сущность </summary>
        public struct Position : IEcsComponent
        {
            /// <summary> Позиция сущности. </summary>
            public Vector3 Value;
            /// <summary> Следующее время обновления системами. </summary>
            public float NextTimeUpdate;
        }
        
        /// <summary> В какую сторону двигается сущность </summary>
        public struct Direction : IEcsComponent { public Vector3 Value; }
        /// <summary> С какой скорость двигается сущность </summary>
        public struct Speed : IEcsComponent { public float Value; }
    }

    /// <summary> Определяет режим работу MovementGroup. </summary>
    public enum MovementMode
    {
        /// <summary> Будут подключены только пулер и дата. </summary>
        None,
        /// <summary> Движение осуществляется автоматически с помощью
        /// <see cref="Exerussus.EasyEcsModules.BasicData.MovementData.Position"/> +
        /// <see cref="Exerussus.EasyEcsModules.BasicData.MovementData.Direction"/> +
        /// <see cref="Exerussus.EasyEcsModules.BasicData.MovementData.Speed"/>. </summary>
        Move,
        /// <summary> <see cref="Exerussus.EasyEcsModules.BasicData.MovementData.Position"/>
        /// автоматически обновляется через
        /// <see cref="Exerussus.EasyEcsModules.BasicData.UnityData.Transform"/>. </summary>
        TransformRelay,
    }
}