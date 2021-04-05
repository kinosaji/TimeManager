using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    TextMesh text;
    void Start()
    {
        text = GetComponent<TextMesh>();
    }
    void Update()
    {
        if (Manager.guideNum == 0)
        {
            text.text = "수 업 중";
        }
        else if (Manager.guideNum == 1)
        {
            text.text = "쉬는시간";
        }
        else if (Manager.guideNum == 2)
        {
            text.text = "점심시간 (~14시 10분까지)";
        }
        else if (Manager.guideNum == 20)
        {
            text.text = "탐색중입니다, 잠시만 기다려주세요.";
        }


        else if (Manager.guideNum == 3) // @@@@@@@@@@@@@@수업시작@@@@@@@@@@@@@@
        {
            text.text = "1교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 4)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 10시20분";
        }
        else if (Manager.guideNum == 5)
        {
            text.text = "2교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 6)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 11시20분";
        }
        else if (Manager.guideNum == 7)
        {
            text.text = "3교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 8)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 12시20분";
        }
        else if (Manager.guideNum == 9)
        {
            text.text = "4교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 10)
        {
            text.text = "지금부터 점심시간입니다.";
        }
        else if (Manager.guideNum == 11)
        {
            text.text = "곧 점심시간이 끝납니다. \r\n다음 수업시작시간 : 14시10분";
        }
        else if (Manager.guideNum == 12)
        {
            text.text = "5교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 13)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 15시10분";
        }
        else if (Manager.guideNum == 14)
        {
            text.text = "6교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 15)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 16시10분";
        }
        else if (Manager.guideNum == 16)
        {
            text.text = "7교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 17)
        {
            text.text = "지금부터 쉬는시간입니다. \r\n다음 수업시작시간 : 17시10분";
        }
        else if (Manager.guideNum == 18)
        {
            text.text = "8교시 시작을 알립니다.";
        }
        else if (Manager.guideNum == 19)
        {
            text.text = "금일 모든 수업이 종료되었습니다.";
        }
    }
}
