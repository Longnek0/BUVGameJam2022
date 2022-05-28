using UnityEngine;

public class Time_And_Destroy : MonoBehaviour
{
    [SerializeField] private float DestroyIn = 3.0f;

    private void Start()
    {
        Destroy(gameObject, DestroyIn);
    }
}