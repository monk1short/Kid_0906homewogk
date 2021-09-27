
using UnityEngine;

public class RPG_Moster : MonoBehaviour
{/// <summary>
/// 怪物欄位定義
/// </summary>
    [Header("移動速度"), Range(0, 10)]
    public float MoveSpeed = 3.5f;

    [Range(0, 500)]
    public float attack = 100;

    [Range(0, 5000)]
    public float hp = 350;

    [Range(0, 50)]
    public float rangeTrack = 30;
    public Vector3 offsetTrack;

    [Header("掉落道具")]
    public GameObject prop;

    [Range(0, 1)]
    public float probablity = 1;

    [Header("音效資料")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

}

