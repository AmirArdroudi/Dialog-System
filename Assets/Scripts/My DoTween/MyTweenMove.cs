using UnityEngine;
using DG.Tweening;

namespace VOID.FT
{
    public class MyTweenMove : MyTween
    {
        public Transform objectToTween;
        public Vector3 targetPosition;
        
        private Tween myTween;

        public void Start()
        {
            if(onStart)
                PlayForward();
        }

        public override Tween BuildTween()
        {
            myTween = objectToTween.DOLocalMove(targetPosition, duration).SetEase(easeType).SetAutoKill(autoKill);
            
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