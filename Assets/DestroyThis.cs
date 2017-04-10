using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour {
    public float Timer;
    public bool destroyBool;
    private Color originalColor;
    public Renderer rend;
    private bool hit;
	// Use this for initialization
	void Start () {
        hit = true;
        rend = GetComponent<Renderer>();
		if (Physics.Raycast(transform.position, transform.forward * 1, 100))
           rend.material.color = originalColor;
        else
        {
            hit = false;
        }

	}
	
	// Update is called once per frame
	void Update () {
        if(!hit)
        {
            rend.material.color = new Color(1.0f, (4*Time.time%2)/2,0.0f);
        }
        if(destroyBool){
            Destroy(this.gameObject);
        }
	}
}
