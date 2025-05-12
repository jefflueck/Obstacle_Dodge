using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]
    private int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        // Check if the player has collided with an object
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);

    }

}

