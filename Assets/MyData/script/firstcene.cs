using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using UnityEngine.SceneManagement;

public class firstcene : MonoBehaviour {
    public Text BtnText;
    //public Button createdButton;
    void Start()
    {
        VuforiaBehaviour.Instance.enabled = false;
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        BtnText.text = "Loading... 5...";
        yield return new WaitForSeconds(1);
        BtnText.text = "Loading... 4...";
        yield return new WaitForSeconds(1);
        BtnText.text = "Loading... 3...";
        yield return new WaitForSeconds(1);
        BtnText.text = "Loading... 2...";
        yield return new WaitForSeconds(1);
        BtnText.text = "Loading... 1...";
        yield return new WaitForSeconds(1);
        BtnText.text = "Loading... 0...";
        SceneManager.LoadScene("options");
    }

}
