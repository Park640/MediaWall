using HKY;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class HokuyoTest : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

    public URGSensorObjectDetector URG;
    public Camera cam;
    public GameObject clickObj;
    public Transform returnPos;

    [SerializeField] float coolTime = 0;
    Vector2 offset; // URG�� positionoffset
    int width, height; // URG�� detectWidth, detectHeight
    float camWidth, camHeight; // ī�޶��� �ʺ�, ����

    double dx, dy; // ���� ����

    public void GetRect()
    {
        offset = URG.positionOffset;
        width = URG.detectRectWidth/2;
        height = URG.detectRectHeight/2;

        camHeight = cam.orthographicSize;
        camWidth = cam.aspect * camHeight;

        dx = Math.Round(camWidth, 3) / (width/2);
        dy = camHeight / (height/2);
    }

    public Vector2 MappedPos(ProcessedObject obj)
    {
        return new Vector2((obj.position.x - offset.x) * camWidth / width, ((obj.position.y - offset.y) * camHeight / height)+camHeight-camHeight);

    }
    private void Awake()
    {
        GetRect();
    }
    private void Update()
    {
        if (URG.detectedObjects.Count > 0)
        {
            coolTime = 0;
            clickObj.transform.position = MappedPos(URG.detectedObjects[URG.detectedObjects.Count - 1]);
        }
        else
        {
            if ((coolTime += Time.deltaTime) >= 0.3) StartCoroutine(ClickDestroy());
        }
    }
    

    IEnumerator ClickDestroy()
    {
        coolTime= 0;
        yield return new WaitForSeconds(0);
        clickObj.transform.position = returnPos.position;
    }
}
