using UnityEngine;

namespace VOID.DD
{
    [CreateAssetMenu(fileName = "varF_", menuName = "Gameplay/variables/Float")]
    public class FloatVariable : BaseSO
    {
        public float Value;
        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetValue(FloatVariable value)
        {
            Value = value.Value;
        }
        
        public void ApplyChange(float amount)
        {
            Value += amount;
        }

        public void ApplyChange(FloatVariable amount)
        {
            Value += amount.Value;
        }
    }
}