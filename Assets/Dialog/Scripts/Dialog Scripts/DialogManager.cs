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

        public void LoadDialogDataset(DialogDatasetSO dialogDatasetSo)
        {
            // clear last dialog data
            dialogDataQueue.Clear();
            dialogUIManager.GetOkButton().interactable = false;
            dialogUIManager.GetOkButton().onClick.RemoveAllListeners();
            
            // fill dialog data queue
            for (int i = 0; i < dialogDatasetSo.dialogDataset.Length; i++)
            {
                dialogDataQueue.Enqueue(dialogDatasetSo.dialogDataset[i]);
            }
            
            // load first dialog data
            LoadDialogData(dialogDataQueue.Dequeue());
            
            // add OK button listener
            dialogUIManager.GetOkButton().onClick.AddListener(dialogDatasetSo.okButtonEvent.Raise);
            
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