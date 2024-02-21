using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetLevel : MonoBehaviour
{
    TextMeshProUGUI tmpro;
    // Start is called before the first frame update
    void Start()
    {
        tmpro = gameObject.GetComponent<TextMeshProUGUI>();
        tmpro.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
