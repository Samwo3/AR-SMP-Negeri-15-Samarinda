using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    public static Sistem instance;
    public int ID;
    public GameObject TempatSpawn;
    public GameObject[] KoleksiBangunan;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = ButtonID.ID_Bangunan;
        PilihBangunan();
    }

    public void PilihBangunan()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Bangunan");
        if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Benda = Instantiate(KoleksiBangunan[ID]);
        Benda.transform.SetParent(TempatSpawn.transform, false);
        Benda.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
        Benda.transform.Rotate (0,180,0, Space.Self);
    }
}
