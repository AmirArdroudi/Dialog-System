using UnityEngine;

namespace VariableSO
{
    [CreateAssetMenu (fileName = "varS_", menuName = "Gameplay/variables/String")]
    public class StringVariable : ScriptableObject
    {
        public string Value;

        public void SetValue(string value)
        {
            Value = value;
        }
        public void SetValue(StringVariable value)
        {
            Value = value.Value;
        }
        
        

    }
}