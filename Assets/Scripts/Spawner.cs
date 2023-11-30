using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject PTFPrefab;
    [SerializeField] private GameObject Ball;
    private float timer;
    private GameObject Platform;
    Vector3 NewPos;

    // Start is called before the first frame update
    void Start()
    {
        NewPos = transform.position;
        for (int i = 0; i < 20; i++)
        {
            int RNG = Random.Range(1, 3);
            if (RNG == 1)
            {
                NewPos = new Vector3(NewPos.x + 2, 0, NewPos.z);
                Platform = Instantiate(PTFPrefab, NewPos, Quaternion.identity);
                NewPos = Platform.transform.position;
            }
            else if (RNG == 2)
            {
                NewPos = new Vector3(NewPos.x, 0, NewPos.z + 2);
                Platform = Instantiate(PTFPrefab, NewPos, Quaternion.identity);
                NewPos = Platform.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.y > 0)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > 0.2)
            {
                int RNG = Random.Range(1, 3);
                if (RNG == 1)
                {
                    NewPos = new Vector3(NewPos.x + 2, 0, NewPos.z);
                    Platform = Instantiate(PTFPrefab, NewPos, Quaternion.identity);
                    NewPos = Platform.transform.position;
                }
                else if (RNG == 2)
                {
                    NewPos = new Vector3(NewPos.x, 0, NewPos.z + 2);
                    Platform = Instantiate(PTFPrefab, NewPos, Quaternion.identity);
                    NewPos = Platform.transform.position;
                }
                timer = 0;
            }
        }
    }
}
