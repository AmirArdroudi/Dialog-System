using UnityEngine;
using UnityEngine.UI;

namespace Dialog
{
    
    /// <summary>
    /// Dialog UI Manager is responsible for handeling dialog UI related 
    /// functions and animations
    /// </summary>
    public class DialogUIManager : MonoBehaviour
    {
        public SimpleDialog simpleDialogBox;
        public ComplexDialog complexDialogBox;
        private bool isCurrentDialogComplex = false;
        [HideInInspector] public bool isDialogBoxOpen = false;

        
        /// <summary>
        ///  fill dialog box UI elements from a dialogDataSO
        /// </summary>
        /// <param name="dialogData">dialogDataSO</param>
        public void UpdateDialogBoxData(ref DialogDataSo dialogData)
        {
            isCurrentDialogComplex = dialogData.isComplexDialog;
            
            if (isCurrentDialogComplex)
                complexDialogBox.UpdateDialogBox(dialogData);
            else
                simpleDialogBox.UpdateDialogBox(dialogData);
        }
        
        public void ShowDialogBox(bool state)
        {
            if (isCurrentDialogComplex)
                complexDialogBox.ShowDialogBox(state);
            else
                simpleDialogBox.ShowDialogBox(state);
        }


        public void SetOkButtonState(bool state)
        {
            if(isCurrentDialogComplex)
                complexDialogBox.okButton.interactable = state;
            else
                simpleDialogBox.okButton.interactable = state;
        }

        public Button GetOkButton()
        {
            return isCurrentDialogComplex ? complexDialogBox.okButton : simpleDialogBox.okButton;
        }

    }
}