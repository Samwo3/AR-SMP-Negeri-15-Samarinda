using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AmbilGambar : MonoBehaviour
{
    public void TakePhoto()
    {
        StartCoroutine(TakeAPhoto());
    }

    IEnumerator TakeAPhoto()
    {
        yield return new WaitForEndOfFrame();
        Camera camera = Camera.main;
        int width = Screen.width;
        int height = Screen.height;
        RenderTexture rt = new RenderTexture(width, height, 24);
        camera.targetTexture = rt;
        var currentRT = RenderTexture.active;
        RenderTexture.active = rt;
        camera.Render();
        Texture2D image = new Texture2D(width, height);
        image.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        image.Apply();
        camera.targetTexture = null;
        RenderTexture.active = currentRT;
        byte[] bytes = image.EncodeToPNG();
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery
        ( image, "AR SMPN 15 SMD", "ImageModel.png", (success, path) => Debug.Log 
        ("Media save result: " + success + " " + path));
        Debug.Log ("Permission result: " + permission);
        Destroy(rt);
        Destroy(image);
    }
}
