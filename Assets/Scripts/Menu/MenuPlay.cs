using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour
{

    public string firstGameScene;

    public void onPlay()
    {

        SceneManager.LoadScene(firstGameScene);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
