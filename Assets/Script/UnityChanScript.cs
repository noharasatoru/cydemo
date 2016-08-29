using UnityEngine;
using System.Collections;

public class UnityChanScript : MonoBehaviour {
    private Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if (Input.GetKey ("up")) {
            anim.SetBool ("Walk", true);
        } else {
            anim.SetBool ("Walk", false);
        }
    }
}