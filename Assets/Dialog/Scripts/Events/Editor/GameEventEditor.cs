using UnityEditor;
using UnityEngine;

namespace VOID.DD.Scripts.Events
{
    #if UNITY_EDITOR
    
    [CustomEditor(typeof(GameEvent), editorForChildClasses: true)]
    public class GameEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            
            base.OnInspectorGUI();

            GUI.enabled = true;
            
            GameEvent e = target as GameEvent;
            
            if(GUILayout.Button("Raise Event"))
                e.Raise();
        }
    }
    
    #endif
}