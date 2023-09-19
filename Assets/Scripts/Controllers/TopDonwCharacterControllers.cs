using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDonwCharacterControllers : MonoBehaviour
{
    // event 외부에서는 호출하지 못하게 막는다
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

//이동 연습 코트
//{
//    [SerializeField] private float speed = 5f;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void  Update()
//    {
//        // Drag, Ctrl + K C 주석  K U 풀기
//        //float x = Input.GetAxisRaw("Horizontal");
//        //float y = Input.GetAxisRaw("Vertical");

//        //transform.position += new Vector3(x, y) * speed * Time.deltaTime; 
//    }
//}
