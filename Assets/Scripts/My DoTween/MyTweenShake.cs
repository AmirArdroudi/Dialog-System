using DG.Tweening;
using MyBox;
using UnityEngine;

namespace VOID.FT.Scripts.Tweens
{
    public enum ShakeType
    {
        Position, Rotation, Scale
    }
    public class MyTweenShake : MyTween
    {
        public Transform objectToTween;
        public ShakeType shakeType;
        public float strength;
        
        private Tween myTween;

        private void Start()
        {
            if(onStart)
                PlayForward();
        }
        
        public override Tween BuildTween()
        {
            switch (shakeType)
            {
                case ShakeType.Position:
                    myTween = objectToTween.DOShakePosition(duration, strength);
                    break;
                case ShakeType.Rotation:
                    myTween = objectToTween.DOShakeRotation(duration, strength);
                    break;
                case ShakeType.Scale:
                    myTween = objectToTween.DOShakeScale(duration, strength);
                    break;
            }
            
            if (loop)
                myTween.SetLoops(loopCounts, loopType);
            myTween.SetAutoKill(autoKill);
            
            return myTween;
        }

        public override void PlayForward()
        {
            if (myTween == null)
                BuildTween();
            myTween.PlayForward();
        }
        public void PlayBackward()
        {
            if (myTween == null)
                BuildTween();
            myTween.PlayBackwards();
        }

        public override void Pause()
        {
            base.Pause();
            myTween?.Pause();
        }
        public override Tween GetMyTween()
        {
            return myTween;
        }
    }
}