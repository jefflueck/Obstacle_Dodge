using Mono.Cecil.Cil;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    void Start()
    {
        // Start player in the center of the screen
        transform.position = new Vector3(0f, 0.5f, -15f);
        PrintInstructions();
    }

    void Update()
    {
        // Move the player based on input
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys or WASD to move around.");
        Debug.Log("Avoid obstacles and reach the goal.");
        Debug.Log("Good luck!");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = 0f;

        transform.Translate(xValue, yValue, zValue);
    }



}

