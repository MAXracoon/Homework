using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDonwCharacterControllers : MonoBehaviour
{
    // event �ܺο����� ȣ������ ���ϰ� ���´�
    public event Action<Vector2> OnmoveEvent;
    public event Action<Vector2> OnlookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnmoveEvent?.Invoke(direction);
    }
    public void CallLookEvent(Vector2 direction)
    {
        OnlookEvent.Invoke(direction);
    }
}

//�̵� ���� ��Ʈ
//{
//    [SerializeField] private float speed = 5f;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void  Update()
//    {
//        // Drag, Ctrl + K C �ּ�  K U Ǯ��
//        //float x = Input.GetAxisRaw("Horizontal");
//        //float y = Input.GetAxisRaw("Vertical");

//        //transform.position += new Vector3(x, y) * speed * Time.deltaTime; 
//    }
//}
