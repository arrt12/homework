using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TicTakToe : MonoBehaviour
{
    private bool isTrue = true;
    private TcT[,] cells = new TcT[3, 3];

    public void Ck()
    {
        SceneManager.LoadScene(1);
    }


    public void ocl(TcT cell)
    {
        if (cell.currs != TcT.es.None)
        {
            return;
        }
        if (isTrue == true)
        {
            cell.srt(TcT.es.o);
        }
        else
        {
            cell.srt(TcT.es.x);
        }
        cells[cell.x, cell.y] = cell;

        isTrue = !isTrue;
        CB();
    }
       
    private void CB()
    {
        foreach (TcT cell in cells)
        {
            int samecount = 0;
            if (cell == null)
            {
                continue;
            }

            for (int x = -2; x <= 2; x++)
            {

                if (cell.x + x < 0 || cell.x + x> 2 || cells[cell.x+ x, cell.y] == null)
                    continue;

                if (cells[cell.x + x, cell.y].currs == cell.currs)
                {
                    samecount += 1;
                }
            }
           
            Debug.Log($"samecount �� {samecount}�Դϴ�");

            samecount = 0;
            for (int y = -2; y <= 2; y++)
            {
                if (cell.y + y < 0 || cell.y + y> 2 || cells[cell.x, cell.y+y] == null)
                    continue;

                if (cells[cell.x, cell.y +y].currs == cell.currs)
                {
                    samecount += 1;
                }

            }
            if (samecount == 3)
            {
                Debug.Log("���ӿ���");
                SceneManager.LoadScene(5);
                
            }
            
        }
      
       
    }
    //���޾Ƽ� 3���� ���� (none�� �ƴ� )state���� äũ�ؾ���
    //�׷��� ���ؼ� �ʿ��� ������ ? ������ ��ġ ��
    

   
}
