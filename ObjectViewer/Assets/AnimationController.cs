using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
    
    public static bool animOn = false;

    private Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
        if(animOn == true)
        {
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }

	}
}
