using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private bool hasShown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasShown) return;

        // The collider may sit on a child of the airplane, so look upward for the controller.
        AirplaneController airplane = other.GetComponentInParent<AirplaneController>();
        if (airplane == null || !airplane.CompareTag("Player")) return;
        if (!airplane.hasTakenOff) return;

        hasShown = true;

        GameManager manager = FindFirstObjectByType<GameManager>();
        if (manager != null)
            manager.ShowMenu();
        else
            GameMenu.enabled = true;
    }
}
