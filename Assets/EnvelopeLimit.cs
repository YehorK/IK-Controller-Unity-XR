using UnityEngine;

public class EnvelopeLimit : MonoBehaviour
{
    public GameObject ik_object; // Cube that defines robot movement
    public Transform robotEnvelope; // Origin of the spherical boundary
    public float maxRadius = 1f; // Maximum reach radius for the robot

    void Update()
    {
        ConstrainToSphere();
    }

    public void ConstrainToSphere()
    {
        // Calculate the offset from the sphere's origin to object1's position
        Vector3 offset = ik_object.transform.position - robotEnvelope.position;
        //Debug.Log(offset.magnitude);

        // Check if object1 is outside the spherical boundary
        if (offset.magnitude > maxRadius)
        {
            // Restrict object1's position to the sphere's surface
            Vector3 clampedPosition = robotEnvelope.position + offset.normalized * maxRadius;
            //Debug.Log(clampedPosition);
            ik_object.transform.position = clampedPosition;
            Debug.Log("Movement restricted within spherical envelope.");
        }
    }
}
