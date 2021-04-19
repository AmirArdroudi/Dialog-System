using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Dialog
{
    public abstract class DialogBase : MonoBehaviour
    {
        public Button okButton;
        public Canvas canvas;
        public TMP_Text dialogText;
        protected JSONNode defs;
        
        public abstract void UpdateDialogBox(DialogDataSo dialogDataSo);
        public abstract void ShowDialogBox(bool state);

        protected void Start()
        {
            defs = SharedState.LanguageDefs;
            okButton.interactable = false;
        }
        
    }
}