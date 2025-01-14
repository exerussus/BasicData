using Exerussus._1EasyEcs.Scripts.Core;

namespace Exerussus.EasyEcsModules.BasicData
{
    public static class StaminaData
    {
        public struct Stamina : IEcsComponent
        {
            public float Max;
            public float Current;
        }
        
        public struct StaminaRegeneration : IEcsComponent
        {
            public float Rate;
            public float TimeRemaining;
            public float Amount;
        }
        
        /// <summary> Отключает регенерацию стамины </summary>
        public struct StaminaRegenerationStopMark : IEcsComponent
        {
            
        }
    }
}