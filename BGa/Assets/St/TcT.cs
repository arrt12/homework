using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TcT : MonoBehaviour
{
    public Text targetText;
    public es currs;
    public int x;
    public int y;
   
    public enum es
    {
        None,
        o,
        x,
    }
    private void Start()
    {
        srt(es.None);
    }


    public void srt(es target)
    {
        switch (target)
        {
            case es.None:
                targetText.text = "";
                break;
            case es.x:
                targetText.text = "x";
                break;
            case es.o:
                targetText.text = "o";
                break;
        }
        currs = target;
    }
}
