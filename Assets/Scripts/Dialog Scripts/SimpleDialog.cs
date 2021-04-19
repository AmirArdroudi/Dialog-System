﻿using System.Collections;
using UnityEngine;


namespace Dialog
{
    public class SimpleDialog : DialogBase
    {
        public MyTweenMove dialogBoxTween;
        

        public override void UpdateDialogBox(DialogDataSo dialogDataSo)
        {
            string jsonKey = dialogDataSo.dialogKeyJson;
            if (dialogDataSo.isCharacterRelatedDialog)
                jsonKey += "_ch" + selectedCharacterIndex.Value;
    
            dialogText.text = defs[jsonKey];
            Speech(jsonKey);
        }
        
        public override void ShowDialogBox(bool state)
        {
            if (state)
            {
                dialogBoxTween.PlayForward();
                StartCoroutine(ShowCanvas(0, true));
            }
            else
            {
                dialogBoxTween.GetMyTween().PlayBackwards();
                StartCoroutine(ShowCanvas(2, false));
            }
        }

        private IEnumerator ShowCanvas(float delay, bool state)
        {
            yield return new WaitForSeconds(delay);
            canvas.enabled = state;
        }
    }
}