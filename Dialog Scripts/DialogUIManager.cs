using MyBox;
using UnityEngine;
using UnityEngine.UI;

namespace VOID.FT
{
    /// <summary>
    /// Dialog UI Manager is responsible for handeling dialog UI related 
    /// functions and animations
    /// </summary>
    public class DialogUIManager : MonoBehaviour
    {
        public SimpleDialog simpleDialogBox;
        public bool hasComplexDialog = false;
        [ConditionalField(nameof(hasComplexDialog))]
        public ComplexDialog complexDialogBox;
        private bool isCurrentDialogComplex = false;
        [HideInInspector] public bool isDialogBoxOpen = false;

        private void Awake()
        {
#if UNITY_EDITOR
            if (simpleDialogBox == null)
                Debug.LogError("simplexDialogBox reference is missing!");
            if (complexDialogBox == null && hasComplexDialog)
                Debug.LogError("complexDialogBox reference is missing!");
#endif
        }

        /// <summary>
        ///  fill dialog box UI elements from a dialogDataSO
        /// </summary>
        /// <param name="dialogData">dialogDataSO</param>
        public void UpdateDialogBoxData( ref DialogDataSo dialogData)
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