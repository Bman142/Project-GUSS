using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class TitleTouchScreen : MonoBehaviour
{
    private Touch touch;
    [SerializeField] int GameScene;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.pressure > 0)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    this.GetComponent<SceneLoader>().onSceneChange(GameScene);
                }
            }

            
        }

    }
}
