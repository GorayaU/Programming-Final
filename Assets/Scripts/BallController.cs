using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float timer;
    private bool movingOnX;
    public bool playing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playing = true;
            movingOnX = !movingOnX;
        }
        if (playing && movingOnX)
        {
            gameObject.transform.position += Vector3.right/75;
        }else if (playing && !movingOnX)
        {
            gameObject.transform.position += Vector3.forward/75;
        }
        if (gameObject.transform.position.y <= 0f)
        {
            playing = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == ("Platform"))
        {
            Debug.Log("Collision exited");
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            timer += Time.deltaTime;
            Debug.Log("Timer started");
            Debug.Log(timer);
            if (timer > 0.5f)
            {
                Debug.Log("Droping object");
                collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
                Destroy(collision.gameObject, 2);
                timer = 0;
            }
        }
    }
}
