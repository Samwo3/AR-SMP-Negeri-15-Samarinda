using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableObject : MonoBehaviour
{
    public GameObject model;
    public void whenButtonClicked()
    {
        if (model.activeInHierarchy == true)
            model.SetActive(false);
        else
            model.SetActive(true);
    }
}
