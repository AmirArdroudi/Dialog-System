// using System.Collections;
// using UnityEngine.UI;
// using UnityEngine.Video;
// using UnityEngine;
//
//
// namespace Dialog
// {
//     public class ComplexDialog : DialogBase
//     {
//         
//         public Image avatarImage;
//         public VideoPlayer videoPlayer;
//         public MyTweenMove dialogBoxTween;
//         
//         private string dialog;
//         public override void UpdateDialogBox(DialogDataSo dialogDataSo)
//         {
//             if (videoPlayer.clip == null)
//             {
//                 videoPlayer.clip = dialogDataSo.videoOptions.videoClip;
//                 videoPlayer.playbackSpeed = dialogDataSo.videoOptions.playbackSpeed;
//                 
//                 avatarImage.sprite = dialogDataSo.avatarSprite;
//             }
//
//             string jsonKey = dialogDataSo.dialogKeyJson;
//             if (dialogDataSo.isCharacterRelatedDialog)
//                 jsonKey += "_ch" + selectedCharacterIndex.Value;
//             
//             dialogText.text = defs[jsonKey];
//             Speech(jsonKey);
//         }
//
//         public override void ShowDialogBox(bool state)
//         {
//             if (state)
//             {
//                 dialogBoxTween.PlayForward();
//                 StartCoroutine(ShowCanvas(0, true));
//             }
//             else
//             {
//                 dialogBoxTween.PlayBackward();
//                 StartCoroutine(ShowCanvas(2, false));
//             }
//         }
//         private IEnumerator ShowCanvas(float delay, bool state)
//         {
//             yield return new WaitForSeconds(delay);
//             canvas.enabled = state;
//         }
//     }
// }
