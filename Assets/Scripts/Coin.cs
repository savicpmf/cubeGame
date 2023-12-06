using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Transform trans;
    public float rotationSpeed = 90f;
    void Update()
    {
        trans.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }

}

