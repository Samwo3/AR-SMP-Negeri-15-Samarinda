using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemTanpaAtap : MonoBehaviour
{
    public static SistemTanpaAtap instance;
    public int IDt;
    public GameObject TempatSpawnt;
    public GameObject[] KoleksiBangunant;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        IDt = ButtonID.ID_Bangunan;
        PilihBangunant();
    }

    public void PilihBangunant()
    {
        GameObject BendaSebelumnyat = GameObject.FindGameObjectWithTag("BangunanTanpaAtap");
        if (BendaSebelumnyat != null) Destroy(BendaSebelumnyat);

        GameObject Bendat = Instantiate(KoleksiBangunant[IDt]);
        Bendat.transform.SetParent(TempatSpawnt.transform, false);
        Bendat.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
        Bendat.transform.Rotate (0,180,0, Space.Self);
    }
}
