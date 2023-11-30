using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool movingOnX;

    [SerializeField] private BallController BC;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            movingOnX = !movingOnX;
        }
        if (BC.playing && movingOnX)
        {
            gameObject.transform.position += Vector3.right / 75;
        }
        else if (BC.playing && !movingOnX)
        {
            gameObject.transform.position += Vector3.forward / 75;
        }
    }
}
