using UnityEngine;

public class HealthBarFollow : MonoBehaviour
{
    public Transform target; // The player's transform
    public Vector3 offset;

    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
        }
    }
}