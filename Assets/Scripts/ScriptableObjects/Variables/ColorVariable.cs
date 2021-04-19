using UnityEngine;

namespace VOID.DD
{
    [CreateAssetMenu(fileName = "varColor_", menuName = "Gameplay/variables/Color", order = 0)]
    public class ColorVariable : BaseSO
    {
        public Color Value;
        public void SetValue(Color value)
        {
            Value = value;
        }

        public void SetValue(ColorVariable value)
        {
            Value = value.Value;
        }
        
        public void ApplyChange(Color amount)
        {
            Value += amount;
        }

        public void ApplyChange(ColorVariable amount)
        {
            Value += amount.Value;
        }
    }
}