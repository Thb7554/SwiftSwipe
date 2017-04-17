using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    public float Timer;
    public bool destroyBool;
    private Color originalColor;
    public Renderer rend;
    public bool missBool;
    public GameObject clickManager;
    // Use this for initialization
    void Start()
    {
        clickManager = GameObject.Find("GameObject");
        missBool = false;
        RaycastHit hit;
        rend = GetComponent<Renderer>();
        if (Physics.Raycast(transform.position, transform.forward * 1, out hit))
        {
            if (hit.transform.tag == "StartZone")
            {
                clickManager.GetComponent<Click>().startedBool = true;
            }
            else if (hit.transform.tag == "EndZone")
            {
                clickManager.GetComponent<Click>().endedBool = true;
            }
        }

        else
        {
            missBool = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (missBool)
        {
            rend.material.color = new Color(1.0f, (4 * Time.time % 2) / 2, 0.0f);
        }
        if (destroyBool)
        {
            Destroy(this.gameObject);
        }
    }
}
