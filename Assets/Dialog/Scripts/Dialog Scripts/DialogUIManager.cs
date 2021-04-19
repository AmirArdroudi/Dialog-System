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
        public SimpleDialog DialogBox;
        [HideInInspector] public bool isDialogBoxOpen = false;

        
        /// <summary>
        ///  fill dialog box UI elements from a dialogDataSO
        /// </summary>
        /// <param name="dialogData">dialogDataSO</param>
        public void UpdateDialogBoxData(ref DialogDataSo dialogData)
        {
            DialogBox.UpdateDialogBox(dialogData);
        }
        
        public void ShowDialogBox(bool state)
        {
            DialogBox.ShowDialogBox(state);
        }


        public void SetOkButtonState(bool state)
        {
            DialogBox.okButton.interactable = state;
        }

        public Button GetOkButton()
        {
            return DialogBox.okButton;
        }

    }
}