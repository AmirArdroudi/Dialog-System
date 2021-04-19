using UnityEngine;
using VOID.DD.Scripts.Events;

namespace VOID.DD.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "dialogSet_lvlX_title", menuName = "Gameplay/Dialog/Dialog Data Set")]
    public class DialogDataSetSO : BaseSO
    {
        public DialogDataSo[] dialogDataset;
        [Space]
        [Tooltip("Event to raise after clicking on OK button on the last dialog line.")]
        public GameEvent okButtonEvent;
    }
}