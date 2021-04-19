using UnityEngine;
using DG.Tweening;
using MyBox;

namespace VOID.FT
{
    public class MyTweenScale : MyTween
    {
        public Transform objectToTween;
        [MinMaxRange(0,10)]public MinMaxFloat targetScale;
        
        private Tween myTween;
        
        public void Start()
        {
            if(onStart)
                PlayForward();
        }
        
        public override Tween BuildTween()
        {
            float randomScale = Random.Range(targetScale.Min, targetScale.Max);
            myTween = objectToTween.DOScale(randomScale, duration).SetEase(easeType);
            
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