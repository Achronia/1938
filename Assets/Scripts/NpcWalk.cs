using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NpcWalk : MonoBehaviour
{
    [SerializeField] Transform _targetTransform;
    [SerializeField] GameObject _endSceneStart;
    [SerializeField] string _endSceneName;

    [SerializeField] float _moveSpeed;
    [SerializeField] float _sceneSpeed;
    [SerializeField] Animator _anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      _anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetTransform.position, Time.deltaTime * _moveSpeed);

        if (transform.position==_targetTransform.position)
        {
            _anim.SetBool("Idle", true);
            _endSceneStart.SetActive(true);

            Invoke(nameof(Delayer),_sceneSpeed);
        }
    }
    private void Delayer()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        SceneManager.LoadScene(_endSceneName);
    }
}
