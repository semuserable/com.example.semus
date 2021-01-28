using UnityEngine;

public class OnStartHello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
        => Debug.Log($"Hello from {nameof(OnStartHello)}.Start()!");
}
