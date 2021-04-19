using UnityEngine;

namespace VariableSO
{
    [CreateAssetMenu(fileName = "varF_", menuName = "Gameplay/variables/Float")]
    public class FloatVariable : ScriptableObject
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