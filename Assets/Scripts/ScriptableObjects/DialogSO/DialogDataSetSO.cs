using UnityEngine;

namespace Dialog
{
    [CreateAssetMenu(fileName = "dialogSet_lvlX_title", menuName = "Dialog/Dialog Data Set")]
    public class DialogDataSetSO : ScriptableObject
    {
        public DialogDataSo[] dialogDataset;
        [Space]
        [Tooltip("Event to raise after clicking on OK button on the last dialog line.")]
        public GameEvent okButtonEvent;
    }
}