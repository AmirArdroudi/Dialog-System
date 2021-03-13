using System;
using UnityEngine;
using TMPro;
using SimpleJSON;
using LoLSDK;
using UnityEngine.UI;

namespace VOID.FT
{
    public abstract class DialogBase : MonoBehaviour
    {
        public Button okButton;
        public Canvas canvas;
        public TMP_Text dialogText;
        protected JSONNode defs;
        [Space]
        [Tooltip("Index of the character which is selected in CharacterSelect Menu")]
        public StringReference selectedCharacterIndex;
        
        public abstract void UpdateDialogBox(DialogDataSo dialogDataSo);
        public abstract void ShowDialogBox(bool state);

        protected void Start()
        {
            defs = SharedState.LanguageDefs;
            okButton.interactable = false;
        }

        public void Speech(string dialog)
        {
            LOLSDK.Instance.SpeakText(dialog);
        }
        
    }
}