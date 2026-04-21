using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed_X = 5.0f;
  
    void Update()
        //매 프레임마다 실행
    {
        transform.Translate(Vector3.right * speed_X * Time.deltaTime);
    }
}
