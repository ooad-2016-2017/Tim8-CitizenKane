using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwipeControl : MonoBehaviour
{
    
    private Vector3 fp; 
    private Vector3 lp; 
    private float dragDistance;

    public AudioClip hitSound;
    public float power;
    private List<Vector3> footballPos;
    int pozicija = 0;
    private float factor = 34f; 

    public bool gameStarted = false;

    private bool returned = true;
    GameObject mojaLopta;

    public GameObject loptaPrefab;

    void Start()
    {

        Time.timeScale = 1;
        dragDistance = Screen.height * 10 / 100; 
        Physics.gravity = new Vector3(0, -20, 0);
        setBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (returned)
        {
            if (Input.GetMouseButtonDown(0) && !gameStarted)
            {
                fp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            }
            if(Input.GetMouseButtonUp(0) && !gameStarted)
            {
                lp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
                playerLogic();
            }
        }
    }

    void playerLogic()
    {
        gameStarted = true;
        returned = false;
        if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
        {
            float x = (lp.x - fp.x) / Screen.height * factor;
            float y = (lp.y - fp.y) / Screen.height * factor;
            AudioSource.PlayClipAtPoint(hitSound, mojaLopta.transform.position);
            if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
            {
                returned = false;        
                if ((lp.x > fp.x))
                {   //Right move
                    mojaLopta.GetComponent<Rigidbody>().AddForce((new Vector3(x, 10, 15)) * power);
                }
                else
                {   //Left move
                    mojaLopta.GetComponent<Rigidbody>().AddForce((new Vector3(x, 10, 15)) * power);
                }
            }
            else
            {   
                if (lp.y > fp.y)  //If the movement was up
                {   //Up move
                    mojaLopta.GetComponent<Rigidbody>().AddForce((new Vector3(x, y, 15)) * power);
                }
                else
                {   //Down move

                }
            }
        }

        StartCoroutine(ReturnBall());

    }

    IEnumerator ReturnBall()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(mojaLopta);
        setBall();
        gameStarted = false;
    }

    private void setBall()
    {
        mojaLopta = (GameObject)Instantiate(loptaPrefab, new Vector3(0f, -0.3777281f, -3.635868f), transform.rotation);
        returned = true;
    }
}