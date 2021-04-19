﻿using System.Collections;
using UnityEngine;
using MyDotween;

namespace Dialog
{
    public class SimpleDialog : DialogBase
    {
        public MyTweenMove dialogBoxTween;
        

        public override void UpdateDialogBox(DialogDataSo dialogDataSo)
        {
            dialogText.text = dialogDataSo.dialogLine;
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
                // dialogBoxTween.GetMyTween().PlayBackwards();
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
