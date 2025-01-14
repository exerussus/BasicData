using Exerussus._1EasyEcs.Scripts.Core;

namespace Exerussus.EasyEcsModules.BasicData
{
    public static class UnityData
    {
        public struct Transform : IEcsComponent { public UnityEngine.Transform Value; }
        public struct Rigidbody2D : IEcsComponent { public UnityEngine.Rigidbody2D Value; }
        public struct Rigidbody3D : IEcsComponent { public UnityEngine.Rigidbody Value; }
        public struct Collider2D : IEcsComponent { public UnityEngine.Collider2D Value; }
        public struct Collider3D : IEcsComponent { public UnityEngine.Collider Value; }
        public struct Renderer : IEcsComponent { public UnityEngine.Renderer Value; }
        public struct Image : IEcsComponent { public UnityEngine.UI.Image Value; }
        public struct SpriteRenderer : IEcsComponent { public UnityEngine.SpriteRenderer Value; }
        public struct Material : IEcsComponent { public UnityEngine.Material Value; }
    }
}