using UnityEngine;
using DG.Tweening;
using MyBox;

namespace VOID.FT
{
    public abstract class MyTween : MonoBehaviour
    {
        public bool onStart = false;
        [Range(0, 3000)] public float duration = 1;
        public Ease easeType;
        public bool autoKill = false;
        
        [Tooltip("play this tween with previous one concurrently")]
        // TODO : create a sequence of myTweens to handling playing tweens sequence
        public bool concurrently = false;
        
        [Header("Loop Options")]
        public bool loop = false;
        [ConditionalField(nameof(loop), false)]
        public LoopType loopType;
        [ConditionalField(nameof(loop), false)]
        public int loopCounts = -1;        
        
        public abstract Tween GetMyTween();
        public abstract Tween BuildTween();

        public abstract void PlayForward();
        public abstract void Pause();
    }
}