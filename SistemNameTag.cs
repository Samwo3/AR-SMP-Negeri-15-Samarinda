using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemNameTag : MonoBehaviour
{
    public static SistemNameTag instancetag;
    public int IDtag;
    public GameObject TempatTag;
    public GameObject[] KoleksiTag;

    private void Awake()
    {
        instancetag = this;
    }

    void Start()
    {
        TempatTag.SetActive(false);
        IDtag = ButtonID.ID_Bangunan;
        PilihTag();
    }

    public void PilihTag()
    {
        GameObject TagSebelumnya = GameObject.FindGameObjectWithTag("NameTag");
        if (TagSebelumnya != null) Destroy(TagSebelumnya);

        GameObject Tag = Instantiate(KoleksiTag[IDtag]);
        Tag.transform.SetParent(TempatTag.transform, false);
        Tag.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
        Tag.transform.Rotate (0,180,0, Space.Self);
    }

    public void TagButton()
    {
        if(TempatTag != null)
        {
            bool isActive = TempatTag.activeSelf;
            TempatTag.SetActive(!isActive);
        }
    }
}
