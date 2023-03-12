using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {    
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
