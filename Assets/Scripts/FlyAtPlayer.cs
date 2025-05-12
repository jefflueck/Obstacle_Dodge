using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{

    [SerializeField] Transform player;

    [SerializeField]
    private Vector3 playerPosition;

    [SerializeField]
    private float speed = 10f;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
}
