using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMethod : MonoBehaviour
{/// <summary>
 /// 宜修 Homework
 /// NPC 方法定義
 /// </summary>
    //對話
    private void Dialog()
    {
        
    }
    //開啟商店
    public bool StoreOpen( )
    {
        return true ;
    }
    //購買道具
    public int ItemPurchase( int price = 100 )
    {
        return 0;
    }
    //取得任務
    public void GetMission(int MissionNumber )
    {
        
    }
    //任務更新
    private int MissionUpdate( int PropsAmount = 1 )
    {
        return 0 ;
    }
    //完成任務
    private bool MissionCompleted(bool MissionNumber )
    {
        return false ;
    }

    private void Start()
    {
        
    }
}
