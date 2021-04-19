using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Dialog
{
    /// <summary>
    /// Dialog manager is responsible for all dialog things
    /// </summary>
    public class DialogManager : MonoBehaviour
    {
        
        public DialogUIManager dialogUIManager;
        [Space]
        private Queue<DialogDataSo> dialogDataQueue = default;
        
        private void Start()
        {
            dialogDataQueue = new Queue<DialogDataSo>();
        }

        public void LoadDialogDataSet(DialogDataSetSO dialogDataSetSo)
        {
            // clear last dialog data
            dialogDataQueue.Clear();
            dialogUIManager.GetOkButton().interactable = false;
            dialogUIManager.GetOkButton().onClick.RemoveAllListeners();
            
            // fill dialog data queue
            for (int i = 0; i < dialogDataSetSo.dialogDataset.Length; i++)
            {
                dialogDataQueue.Enqueue(dialogDataSetSo.dialogDataset[i]);
            }
            
            // load first dialog data
            LoadDialogData(dialogDataQueue.Dequeue());
            
            // add OK button listener
            dialogUIManager.GetOkButton().onClick.AddListener(dialogDataSetSo.okButtonEvent.Raise);
            
        }
        private void LoadDialogData(DialogDataSo dialogDataSo)
        {
            dialogUIManager.UpdateDialogBoxData(ref dialogDataSo);
            if(dialogUIManager.isDialogBoxOpen == false)
                dialogUIManager.ShowDialogBox(true);
        }
        
        
        /// <summary>
        /// Called by Next button on dialog box
        /// </summary>
        public void LoadNextDialogLine()
        {
            if (dialogDataQueue.Any())
                LoadDialogData(dialogDataQueue.Dequeue());
            else
                dialogUIManager.SetOkButtonState(true);
        }
        
    }
}