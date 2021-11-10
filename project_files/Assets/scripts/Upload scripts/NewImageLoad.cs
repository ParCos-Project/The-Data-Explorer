// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.EventSystems;
// using System.Collections;
// using UnityEngine.Networking;

// public class NewImageLoad : MonoBehaviour, IPointerDownHandler {

//     public Renderer preview;
//     public Text text;

//     void Start() {
//         Application.ExternalEval(
//             @"
// document.addEventListener('click', function() {

//     var fileuploader = document.getElementById('fileuploader');
//     if (!fileuploader) {
//         fileuploader = document.createElement('input');
//         fileuploader.setAttribute('style','display:none;');
//         fileuploader.setAttribute('type', 'file');
//         fileuploader.setAttribute('id', 'fileuploader');
//         fileuploader.setAttribute('class', 'focused');
//         document.getElementsByTagName('body')[0].appendChild(fileuploader);

//         fileuploader.onchange = function(e) {
//         var files = e.target.files;
//             for (var i = 0, f; f = files[i]; i++) {
//                 window.alert(URL.createObjectURL(f));
//                 SendMessage('" + gameObject.name +@"', 'FileDialogResult', URL.createObjectURL(f));
//             }
//         };
//     }
//     if (fileuploader.getAttribute('class') == 'focused') {
//         fileuploader.setAttribute('class', '');
//         fileuploader.click();
//     }
// });
//             ");
//     }

//     public void OnPointerDown (PointerEventData eventData)  {
//         Application.ExternalEval(
//             @"
// var fileuploader = document.getElementById('fileuploader');
// if (fileuploader) {
//     fileuploader.setAttribute('class', 'focused');
// }
//             ");
//     }

//     public void FileDialogResult(string fileUrl) {
//         Debug.Log(fileUrl);
//         text.text = fileUrl;
//         StartCoroutine(PreviewCoroutine(fileUrl));
//     }

//     IEnumerator PreviewCoroutine(string url) {
//         UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
//         yield return request.SendWebRequest();

//         if (request.result != UnityWebRequest.Result.Success)
//         {
//             Debug.Log(request.error);
//             StartCoroutine(DownloadImage(imageURL));
//         } else
//         {
//             texture = DownloadHandlerTexture.GetContent(request);
//             Sprite tempSprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height),
//                 new Vector2(0.5f, 0.5f));
//             loadingIcon.SetActive(false);
//             placeholder.sprite = tempSprite;
//         }
//     }

//     public class Response
//     {
//         public string url;
//     }
// }
