using System;
using DG.Tweening;
using UnityEngine;

namespace VOID.FT.Scripts.Tweens
{
    public class MyTweenRotate : MyTween
    {
        public Transform objectToTween;
        public Vector3 targetRotation;
        
        private Tween myTween;

        private void Start()
        {
            if(onStart)
                PlayForward();
        }
        
        public override Tween BuildTween()
        {
            myTween = objectToTween.DOLocalRotate(targetRotation, duration).SetEase(easeType);
            
            if (loop)
                BuildTween().SetLoops(-1, loopType);
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