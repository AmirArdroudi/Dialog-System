using UnityEngine;

namespace VOID.DD
{
    public class BaseSO : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string developerDescription = " ";
#endif

    }
}