using UnityEngine;

namespace Dialog
{
    [CreateAssetMenu(fileName = "dialog_lvlX_title", menuName = "Gameplay/Dialog/Dialog Data")]
    public class DialogDataSo : BaseSO
    {
        [Space]
        public bool isComplexDialog;
        
        [Space]
        public string DialogKeyJson;

        [ConditionalField(nameof(isComplexDialog))]
        public bool hasSecondText;
        
        [Space, ConditionalField(nameof(isComplexDialog))]
        public SkeletonDataAsset skeletonDataAsset;
        [ConditionalField(nameof(isComplexDialog))]
        public string animationName = "";
        [ConditionalField(nameof(isComplexDialog))]
        public Material skeletonDataMaterial;

        [ConditionalField(nameof(isComplexDialog))]
        public float animationTimeScale = 1f;
        
        [ConditionalField(nameof(isComplexDialog))]
        public float tutorialScale = 1;

    }
}
