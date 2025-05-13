using UnityEditor;
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
        gameObject.SetActive(false);
        playerPosition = player.transform.position;

    }

    void Update()
    {
        PlayerMovement();
        DestroyWhenReached();
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    private void PlayerMovement()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);

    }
}
