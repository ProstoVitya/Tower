using UnityEngine;

public class CubeRescaler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        float[] contactsX = { collision.contacts[0].point.x, collision.contacts[1].point.x };
        float[] contactsZ = { collision.contacts[0].point.z, collision.contacts[1].point.z };

        float xScale = Rescaler.RescaleFace(collision.transform.localScale.x, contactsX[0], contactsX[1]);
        float zScale = Rescaler.RescaleFace(collision.transform.localScale.z, contactsZ[0], contactsZ[1]);

        float xCoordinate = Rescaler.FindCoordinate(collision.transform.position.x, collision.transform.localScale.x, xScale);
        float zCoordinate = Rescaler.FindCoordinate(collision.transform.position.z, collision.transform.localScale.z, zScale);

        collision.transform.localScale = new Vector3(xScale, collision.transform.localScale.y, zScale);
        collision.transform.localPosition = new Vector3(xCoordinate, collision.transform.localPosition.y, zCoordinate);
    }
}