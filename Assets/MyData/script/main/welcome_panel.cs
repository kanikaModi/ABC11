using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome_panel : MonoBehaviour
{
    public GameObject GOpanel;
    public void btnok_click()
    {
        GOpanel.SetActive(false);
    }
}