using UnityEngine;

public class TakeObject : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        TakeObjects();
    }

    private void TakeObjects() 
    {
        Destroy(gameObject);
    }
}
