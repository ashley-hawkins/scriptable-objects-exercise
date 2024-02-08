using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var currentSceneId = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
            var nextSceneId = (currentSceneId == 0) ? 1 : 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneId);
        }
    }
}
