using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AturMode : MonoBehaviour
{
    public GameObject Atap;
    public GameObject TanpaAtap;

    void Start()
    {
        TanpaAtap.SetActive(false);
    }

    public void PilihModeAtap()
    {
        Atap.SetActive(true);
        TanpaAtap.SetActive(false);
    }

    public void PilihModeTanpaAtap()
    {
        Atap.SetActive(false);
        TanpaAtap.SetActive(true);
    }

}
