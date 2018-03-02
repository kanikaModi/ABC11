using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;

public class EnterLearnABC : MonoBehaviour {

	// Use this for initialization
	void Start () {
        VuforiaBehaviour.Instance.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnLearnIconClick()
    {
        SceneManager.LoadScene("main");
    }

    public void OnPlayIconClick()
    {
        SceneManager.LoadScene("gameoptions");
    }
}
