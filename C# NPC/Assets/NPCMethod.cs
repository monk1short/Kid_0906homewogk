using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMethod : MonoBehaviour
{/// <summary>
 /// �y�� Homework
 /// NPC ��k�w�q
 /// </summary>
    //���
    private void Dialog()
    {
        
    }
    //�}�Ұө�
    public bool StoreOpen( )
    {
        return true ;
    }
    //�ʶR�D��
    public int ItemPurchase( int price = 100 )
    {
        return 0;
    }
    //���o����
    public void GetMission(int MissionNumber )
    {
        
    }
    //���ȧ�s
    private int MissionUpdate( int PropsAmount = 1 )
    {
        return 0 ;
    }
    //��������
    private bool MissionCompleted(bool MissionNumber )
    {
        return false ;
    }

    private void Start()
    {
        
    }
}
