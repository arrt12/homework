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
            //���� ���ý����� �̵� 
            SceneManager.LoadScene(1);
        }
    }

    //�ڷ�ƾ
    // ����� ������Ʈ������ �ݺ��������� �����Ű�� �ȵȴ�.
    private IEnumerator amt()
    {
        twee.color = new Color(twee.color.r, twee.color.g, twee.color.b, 0.5f); //���� 50% ����
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
    //    Debug.Log("����");
    //    yield return null;
    //    Debug.Log("�������� ���");  
    //    yield return new WaitForSeconds(3f);//n�� ���
    //   Debug.Log("3�� ���");
    //    yield return new WaitForSecondsRealtime(1f);//n�� ���
    //    Debug.Log("����");