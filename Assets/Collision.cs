using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float Timer;
    public bool destroyBool;
    private Color originalColor;
    public Renderer rend;
    public GameObject clickManager;
    // Use this for initialization
    void Start()
    {
        clickManager = GameObject.Find("GameObject");
        RaycastHit hit;
        rend = GetComponent<Renderer>();
        if (Physics.Raycast(transform.position, transform.forward * 1, out hit))
        {
			if (hit.transform.tag == "StartZone" && !clickManager.GetComponent<Click>().endedBool)
            {
                clickManager.GetComponent<Click>().startedBool = true;
				clickManager.GetComponent<Timer> ().boolOn = true;

            }
			else if (hit.transform.tag == "EndZone" &&  clickManager.GetComponent<Click>().startedBool)
            {
				//clickManager.GetComponent<Timer>().boolOn = false;
                clickManager.GetComponent<Click>().endedBool = true;
            }
        }

        else
        {
            clickManager.GetComponent<Click>().outOfBounds = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject);
    }
}
