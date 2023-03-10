using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CowndownTime : MonoBehaviour
{
    public static CowndownTime cowndownTime;
    [SerializeField] private float currTime;
    [SerializeField] private float startTime;

    [SerializeField] private TextMeshProUGUI meshPro, levelText;
    // Start is called before the first frame update
    void Awake(){
        cowndownTime = this;
    }
    void Start()
    {
        currTime = 0;
        meshPro.enabled = false;
        levelText.text = "Level " + SceneManager.GetActiveScene().buildIndex;
        // meshPro.enabled = false;
    }

    public void SetTime(float time){
        currTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (currTime > 0){
            currTime -= Time.deltaTime;
            meshPro.enabled = true;
            meshPro.text = currTime.ToString("0");
            if (currTime <= 0)
            {
                currTime = 0;
                meshPro.enabled = false;
            }
        }
    }
}
