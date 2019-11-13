using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{

    public float speed = 3.0f;
    GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        sword = transform.GetChild(0).gameObject;
    }
        // Update is called once per frame
        void Update()
        {
            // 左に移動
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(-0.1f, 0.0f, 0.0f);
            }
            // 右に移動
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(0.1f, 0.0f, 0.0f);
            }
            // 前に移動
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(0.0f, 0.0f, 0.1f);
            }
            // 後ろに移動
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(0.0f, 0.0f, -0.1f);
            }

            if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }

        }

        void Swipe()
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 target_pos = ray.GetPoint(5.0f);

                sword.transform.LookAt(target_pos);

            }
        }
    }
