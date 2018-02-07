using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    //TODO: save camera position and set it to saved position back until shaking finished
    //TODO: calls ShakeCamera when hitting hero

    protected float shakeTimer;
    protected float shakeAmount;
    Hitbox hit;

    private void FixedUpdate()
    {
        hit = FindObjectOfType<Hitbox>();
        if (shakeTimer >= 0)
        {
            Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;

            transform.position = new Vector3(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y, transform.position.z);

            shakeTimer -= Time.deltaTime;
        }


     //   if (hit.Triggered())
      //  {
            ShakeCamera(0.01f, 0.2f);
      //  }
    }

    public void ShakeCamera(float shakePower, float shakeDuration)
    {
        shakeAmount = shakePower;
        shakeTimer = shakeDuration;
    }
}
