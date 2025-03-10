using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private XRController rightController; // Reference to the VR controller

    [SerializeField]
    private LayerMask placementLayerMask;

    private Vector3 lastPos;

    public Vector3 GetSelectedMapPosition()
    {
        if (rightController != null && rightController.transform != null)
        {
            Ray ray = new Ray(rightController.transform.position, rightController.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, placementLayerMask))
            {
                lastPos = hit.point;
            }
        }
        return lastPos;
    }
}
