using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour {

    public AudioClip hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Meta")
        {
            AudioSource.PlayClipAtPoint(hitSound, collision.collider.transform.position);
            Rigidbody rgb = collision.collider.gameObject.AddComponent<Rigidbody>();
            rgb.mass = 1;
            add();
            StartCoroutine(destroyTarget(collision.collider.gameObject));

        }
    }

    IEnumerator destroyTarget(GameObject meta)
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(meta);
    }


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void add()
    {
        ScoreScript.score += 10;
    }
}
