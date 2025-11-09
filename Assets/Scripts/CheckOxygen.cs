using UnityEngine;

public class CheckOxygen : MonoBehaviour
{
    [SerializeField] GameObject _oxygenPrefab;
    [SerializeField] GameObject _oxygenUI;
    [SerializeField] bool _check;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _check = !_check;
            _oxygenPrefab.SetActive(_check);
            _oxygenUI.SetActive(false);
        }
    }
}
