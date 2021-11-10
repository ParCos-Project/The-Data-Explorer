// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEditor;
// using System.IO;
// using UnityEngine.Networking;

// public class Import_Image : MonoBehaviour
// {
//     string path;
//     public Image placeholder;
//     public GameObject loadingIcon;
//     Texture2D texture;
//     UnityWebRequest request;

//     public void OpenExplorer()
//     {
//         //allows you to open file path to look for png
//         path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
//         //path = @"C:\Users\natas\Desktop\My Data Story";

//         loadingIcon.SetActive(true);
//         GetImage();

//     }

//     void GetImage()
//     {
//         //runs update image if path is null
//         if(path != null)
//         {
//             StartCoroutine(UpdateImage());
//         }
//     }

//     IEnumerator UpdateImage()
//     {
//         request = UnityWebRequestTexture.GetTexture("file:///" + path);
//         yield return request.SendWebRequest();

//         //This if statement is just so that if a file doesn't load (such as when it's not an image),
//         //the system justs reopens the file explorer
//             if (request.result != UnityWebRequest.Result.Success)
//                 {
//                     Debug.Log(request.error);
//                     StartCoroutine(UpdateImage());
//                 }
            
//             //then this else statement is where the file request is converted into a texture, and then into a sprite. 
//             else
//                 {
//                     texture = DownloadHandlerTexture.GetContent(request); 
//                     Sprite tempSprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height),
//                         new Vector2(0.5f, 0.5f));
//                     loadingIcon.SetActive(false);
//                     placeholder.sprite = tempSprite;
//                 }

//     }
    
// }