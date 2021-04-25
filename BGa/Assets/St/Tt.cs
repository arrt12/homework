using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tt : MonoBehaviour
{
    public Text twee;

    private void Start()
    {
        StartCoroutine(amt());
    }

    private void Update()
    {
        if(Input.anyKeyDown == true)
        {
            //게임 선택신으로 이동 
            SceneManager.LoadScene(1);
        }
    }

    //코루틴
    // 절대로 업데이트문에서 반복문에서는 실행시키면 안된다.
    private IEnumerator amt()
    {
        twee.color = new Color(twee.color.r, twee.color.g, twee.color.b, 0.5f); //투명도 50% 적용
        float af = twee.color.a;
        while (true)
        {
            
            twee.color = new Color(twee.color.r, twee.color.g, twee.color.b, af);
            yield return null;

            if (af >= 1)
                af = 0.5f;
            af += 0.5f * Time.deltaTime;

        }
    }
}
    //{
    //    Debug.Log("시작");
    //    yield return null;
    //    Debug.Log("한프레임 대기");  
    //    yield return new WaitForSeconds(3f);//n초 대기
    //   Debug.Log("3초 대기");
    //    yield return new WaitForSecondsRealtime(1f);//n초 대기
    //    Debug.Log("끝남");