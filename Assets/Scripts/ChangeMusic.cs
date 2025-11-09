using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField] AudioSource _oldMusic;
    [SerializeField] AudioSource _newMusic;
    [SerializeField] GameObject _trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _oldMusic.Stop();
            _newMusic.Play();
            Debug.Log("BUUU");
        }
    }
}
