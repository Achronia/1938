using UnityEngine;

public class TakeOxygen : MonoBehaviour,IInteractable
{
    public BreathSystem _breathSystem;
    [SerializeField] float _takeOxygen;
    public void Interact()
    {
        Oxygen();
    }
    private void Oxygen()
    {
        _breathSystem.OxygenIncrease(_takeOxygen);
        Destroy(gameObject);
    }
}
