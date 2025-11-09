using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] GameObject _ourCopy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _ourCopy.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _ourCopy.SetActive(false);
        }
    }
}
