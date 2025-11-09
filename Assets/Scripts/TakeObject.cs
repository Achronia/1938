using UnityEngine;

public class TakeObject : MonoBehaviour,IInteractable
{
    [SerializeField] GameObject _nextScene;
    [SerializeField] GameObject _dialogue1;
    [SerializeField] GameObject _dialogue2;
    [SerializeField] bool _nextSceneController;
    public void Interact()
    {
        TakeObjects();
    }

    private void TakeObjects() 
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _nextSceneController = true;
            if (_nextSceneController)
            {
                _dialogue1.SetActive(false);
                _dialogue2.SetActive(true);

                _nextScene.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
