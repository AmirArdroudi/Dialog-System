using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Dialog
{
    public abstract class DialogBase : MonoBehaviour
    {
        public Button okButton;
        public Canvas canvas;
        public TextMeshProUGUI dialogText;
        
        public abstract void UpdateDialogBox(DialogDataSo dialogDataSo);
        public abstract void ShowDialogBox(bool state);

        protected void Start()
        {
            okButton.interactable = false;
        }
        
    }
}