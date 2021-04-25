using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // 버튼 클락 이벤트
    
    public void gmae1()
    {
        SceneManager.LoadScene(2);
    }

    public void gmae2()
    {
        SceneManager.LoadScene(3);
    }

    public void gmae3()
    {
        SceneManager.LoadScene(4);
    }
  
}
