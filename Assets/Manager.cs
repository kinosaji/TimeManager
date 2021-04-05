using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] audioClips;

    AudioSource Audio;


    static public int guideNum = 20;

    IEnumerator constNum1() // 수업중
    {
        yield return new WaitForSeconds(10f);
        guideNum = 0;
    }
    IEnumerator constNum2() // 쉬는시간
    {
        yield return new WaitForSeconds(10f);
        guideNum = 1;
    }
    IEnumerator constNum3() // 점심시간
    {
        yield return new WaitForSeconds(10f);
        guideNum = 2;
    }
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void Update()
    {
    int Hour = System.DateTime.Now.Hour;
    int Minute = System.DateTime.Now.Minute;
    int Second = System.DateTime.Now.Second;

        if (Hour == 9) // 1교시 시작
        {
            if (Minute == 20)
            {
                if (Second == 00)
                {
                    guideNum = 3;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }
            }

        }
        else if (Hour == 10) // 쉬는시간
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 4;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }
            }
        }
        else if (Hour == 10) // 2교시 시작
        {
            if (Minute == 20)

            {
                if (Second == 00)
                {
                    guideNum = 5;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 11) // 쉬는시간
        {
            if (Minute == 10)
            {

                if (Second == 00)
                {
                    guideNum = 6;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }
            }

        }
        else if (Hour == 11) // 3교시 시작
        {
            if (Minute == 20)
            {
                if (Second == 00)
                {
                    guideNum = 7;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 12) // 쉬는시간
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 8;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }

            }

        }
        else if (Hour == 12) // 4교시 시작
        {
            if (Minute == 20)
            {
                if (Second == 00)
                {
                    guideNum = 9;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 13) // 점심시간 시작
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 10;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum3());
                }

            }


        }
        else if (Hour == 14) // 쉬는시간
        {
            if (Minute == 00)
            {
                if (Second == 00)
                {
                    guideNum = 11;
                    Audio.clip = audioClips[2];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }

            }


        }
        else if (Hour == 14) // 5교시 시작
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 12;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 15) // 쉬는시간
        {
            if (Minute == 00)
            {
                if (Second == 00)
                {
                    guideNum = 13;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }

            }

        }
        else if (Hour == 15) // 6교시 시작
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 14;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 16) // 쉬는시간
        {
            if (Minute == 00)
            {
                if (Second == 00)
                {
                    guideNum = 15;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }

            }

        }
        else if (Hour == 16) // 7교시 시작
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 16;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 17) // 쉬는시간
        {
            if (Minute == 00)
            {
                if (Second == 00)
                {
                    guideNum = 17;
                    Audio.clip = audioClips[1];
                    Audio.Play();
                    StartCoroutine(constNum2());
                }

            }

        }
        else if (Hour == 17) // 8교시 시작
        {
            if (Minute == 10)
            {
                if (Second == 00)
                {
                    guideNum = 18;
                    Audio.clip = audioClips[0];
                    Audio.Play();
                    StartCoroutine(constNum1());
                }

            }

        }
        else if (Hour == 18) // 수업종료
        {
            if (Minute == 00)
            {
                if (Second == 00)
                {
                    guideNum = 19;
                    Audio.clip = audioClips[3];
                    Audio.Play();
                }

            }

        }
    }
}
