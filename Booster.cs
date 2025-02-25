using UnityEngine;

public class Booster : MonoBehaviour
{
    public float boost = 5f;


    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= boost;
        other.GetComponent<FirstPersonMovement>().runSpeed *= boost;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= boost;
        other.GetComponent<FirstPersonMovement>().runSpeed /= boost;
    }
}
