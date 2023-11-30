using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            float time = Time.deltaTime;
            if (time > 0.5)
            {
                gameObject.GetComponent<Rigidbody>().useGravity = true;
                Destroy(gameObject, 2);
                time = 0;
            }
        }
    }
}
