using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]
    private int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("Hits: " + hits);
        }

    }

}

