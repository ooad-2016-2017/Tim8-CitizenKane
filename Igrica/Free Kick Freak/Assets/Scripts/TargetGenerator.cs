using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour {

    
    public GameObject metaPrefab;
	// Use this for initialization
	void Start () {
        GameObject meta1 = (GameObject)Instantiate(metaPrefab, new Vector3(3.72f, 1.23f, 5.91f), transform.rotation);
        GameObject meta2 = (GameObject)Instantiate(metaPrefab, new Vector3(3.72f, -0.18f, 5.91f), transform.rotation);
        GameObject meta3 = (GameObject)Instantiate(metaPrefab, new Vector3(-3.47f, -0.18f, 5.91f), transform.rotation);
        GameObject meta4 = (GameObject)Instantiate(metaPrefab, new Vector3(-3.47f, 1.23f, 5.91f), transform.rotation);
        GameObject meta5 = (GameObject)Instantiate(metaPrefab, new Vector3(0.07f, 0.38f, 5.91f), transform.rotation);
        meta1.transform.Rotate(new Vector3(90, 0, 0));
        meta2.transform.Rotate(new Vector3(90, 0, 0));
        meta3.transform.Rotate(new Vector3(90, 0, 0));
        meta4.transform.Rotate(new Vector3(90, 0, 0));
        meta5.transform.Rotate(new Vector3(90, 0, 0));
 
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
