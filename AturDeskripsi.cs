using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AturDeskripsi : MonoBehaviour
{
    public GameObject DeskripsiPanel;

    [Header("Deskripsi Bangunan")]
    [TextArea]
    public string[] deskripsi;
    public GameObject TempatDeskripsi;

    [Header("UI Deskripsi")]
    public Text txtDeskripsi;

    void Start()
    {
        DeskripsiPanel.SetActive(false);
        txtDeskripsi.text = deskripsi[ButtonID.ID_Bangunan];
    }

    void Update()
    {

    }

    public void DeskripsiButton()
    {
        if(DeskripsiPanel != null)
        {
            bool isActive = DeskripsiPanel.activeSelf;
            DeskripsiPanel.SetActive(!isActive);
        }
    }
}
