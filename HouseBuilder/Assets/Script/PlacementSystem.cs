using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject rayIndicator;

    [SerializeField]
    private InputManager inputManager;

    private void Update()
    {
        Vector3 rayPos = inputManager.GetSelectedMapPosition();
        rayIndicator.transform.position = rayPos;
    }
}
