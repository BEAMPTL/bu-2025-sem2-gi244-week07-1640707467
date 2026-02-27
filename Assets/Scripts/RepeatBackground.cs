using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = startPos.x - transform.position.x;
        Debug.Log($"distance:{distance}");
        if (distance > 112.8/2)
        {
            transform.position = startPos;
        }
    }
}
