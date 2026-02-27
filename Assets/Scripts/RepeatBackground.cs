using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float bgWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        bgWidth = GetComponent<BoxCollider>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerGO = GameObject.Find("Player");
        PlayerController player = playerGO.GetComponent<PlayerController>();
        if (player.isGameOver == true)
        {
            return;
        }

        float distance = startPos.x - transform.position.x;
        Debug.Log($"distance:{distance}");
        if (distance > bgWidth/2)
        {
            transform.position = startPos;
        }
    }
}
