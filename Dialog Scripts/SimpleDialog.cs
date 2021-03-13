using System.Collections;
using DG.Tweening;
using UnityEngine;
using LoLSDK;
using SimpleJSON;


namespace VOID.FT
{
    public class SimpleDialog : DialogBase
    {
        public MyTweenMove dialogBoxTween;
        public MyTweenMove alienTween;
        

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
                alienTween.PlayForward();
                
                dialogBoxTween.PlayForward();
                StartCoroutine(ShowCanvas(0, true));
            }
            else
            {
                alienTween.PlayBackward();
                
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
