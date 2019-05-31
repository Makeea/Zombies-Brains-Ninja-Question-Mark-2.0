using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour {

    public Collider2D other;


	// Use this for initialization
	private void Awake ()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);

    }
	

}
