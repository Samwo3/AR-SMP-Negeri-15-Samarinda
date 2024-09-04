using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notifikasi : MonoBehaviour
{
    public Text notificationText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
        StartCoroutine(sendNotification("Foto berhasil disimpan!", 2));
    }

    IEnumerator sendNotification (string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }
}

