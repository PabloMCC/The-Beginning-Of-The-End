using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singelton
    public static GameManager gM;
    private void Awake()
    {
        if (gM == null)
        {
            gM = this;
        }
        else
        {
            Destroy(gM);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion
    [Header("Player")]
    public Transform pTransform;
    public float pSpeed;
    public float pjumpHeight;
    public Transform pTransformGroundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    


    [Header ("Game")]
    public string pName;
    public float mouseCameraSensitivity;
    public float cameraXRotation;
    public float gravity;
}
