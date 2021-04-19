using UnityEngine;
using DG.Tweening;
using MyBox;
using TMPro;
using UnityEngine.UI;

namespace VOID.FT
{
    public enum TextureType
    {
        Sprite, ImageUI, TextMeshProGUI
    }
    public class MyTweenColor : MyTween
    {
        public TextureType textureType;
        
        [ConditionalField(nameof(textureType),false, TextureType.ImageUI)]
        public Image imageToTween;
        [ConditionalField(nameof(textureType),false, TextureType.Sprite)]
        public SpriteRenderer spriteToTween;
        [ConditionalField(nameof(textureType),false, TextureType.TextMeshProGUI)]
        public TextMeshProUGUI textMeshProUGUI;

        public ColorReference endColor;
        
        private Tween _myTween;

        private void Start()
        {
            if(onStart)
                PlayForward();
        }

        public override Tween BuildTween()
        {
            switch (textureType)
            {
                case TextureType.Sprite:
                    _myTween = spriteToTween.DOColor(endColor.Value, duration);
                    break;
                case TextureType.ImageUI:
                    _myTween = imageToTween.DOColor(endColor.Value, duration);
                    break;
                case TextureType.TextMeshProGUI:
                    _myTween = textMeshProUGUI.DOColor(endColor.Value, duration);
                    break;
            }

            if (loop)
                _myTween.SetLoops(loopCounts, loopType);
            _myTween.SetAutoKill(autoKill);
            
            return _myTween;
        }
        
        public override void PlayForward()
        {
            if (_myTween == null)
                BuildTween();
            _myTween.PlayForward();
        }
        public void PlayBackward()
        {
            if (_myTween == null)
                BuildTween();
            _myTween.PlayBackwards();
        }
        
        public override void Pause()
        {
            _myTween?.Pause();
        }
        public override Tween GetMyTween() { return _myTween; }
    }
}