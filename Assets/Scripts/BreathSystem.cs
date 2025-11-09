using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class BreathSystem : MonoBehaviour
{
    [Header("Oxygen UI")]
    [SerializeField] Image _oxygenBarImage;
    [SerializeField] Image _efectBarImage;
    [SerializeField] float _efectBarImageDelayer;
    [Header("        ")]
    [SerializeField] TextMeshProUGUI _oxygenText;
    [Header("        ")]
    [Header("Oxygen Amount")]
    [SerializeField] float _maxOxygen;
    [SerializeField] float _minOxygen;
    [SerializeField] float _currentOxygen = 100;
    [SerializeField] float _oxygenDecreaseTime;
    [SerializeField] float _oxygenDecreaseDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //_currentOxygen = _maxOxygen;
        StartCoroutine(OxygenDecreaser());
    }

    // Update is called once per frame
    void Update()
    {
        _oxygenText.text = _currentOxygen.ToString();

        if (_oxygenBarImage.fillAmount != _efectBarImage.fillAmount)
        {
            _efectBarImage.fillAmount = Mathf.Lerp(_efectBarImage.fillAmount, _oxygenBarImage.fillAmount, _efectBarImageDelayer);
        }
        if (_currentOxygen == _minOxygen)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("AAAA");
        }
    }

    public void OxygenDecrease (float oxygenDecrease)
    { 
        _currentOxygen -= oxygenDecrease;
        _oxygenBarImage.fillAmount = _currentOxygen / _maxOxygen;
    }
    public void OxygenIncrease(float oxygenIncrease)
    {
        _currentOxygen += oxygenIncrease;
        _oxygenBarImage.fillAmount = _currentOxygen / _maxOxygen;
    }
    IEnumerator OxygenDecreaser()
    {
        while (true)
        {
            yield return new WaitForSeconds(_oxygenDecreaseTime);

            if (_currentOxygen>0)
            {
                OxygenDecrease(_oxygenDecreaseDamage);
            }
        }
    }
}
