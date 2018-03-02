using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp_test : MonoBehaviour {

    public Renderer rend;
    //public Animation anim;
    private Animator anim;
    private bool playsound = true;
   // private bool B_anim = true;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        anim = GetComponent<Animator>();       
    }
	
	// Update is called once per frame
	void Update () {
		if(rend.enabled==true && playsound==true)
        {
            //AudioManager.Main.PlayNewSound("FlyingSword");
            FindObjectOfType<audiomanager>().Play("Sword");
            anim.SetTrigger("startAanim");
            playsound = false;
        }
        
	}

    /*void OnEnable()
    {
        print("Hey");
    }*/
}
