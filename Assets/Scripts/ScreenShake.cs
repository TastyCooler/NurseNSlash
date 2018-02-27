using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    //TODO: save camera position and set it to saved position back until shaking finished
    //TODO: calls ShakeCamera when hitting hero

    protected float shakeTimer;
    protected float shakeAmount;
    Hitbox hit;

    // variables to set transform.position to this variable
    // saving coordinates
    protected float objectposx;
    protected float objectposy;
    protected float objectposz;

    private void FixedUpdate()
    {
        hit = FindObjectOfType<Hitbox>();

        if (shakeTimer >= 0)
        {
            Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;

            transform.position = new Vector3(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y, transform.position.z);

            shakeTimer -= Time.deltaTime;
        }


        if (hit.Triggered())
        {
            // saving gameObject position in the variables
            objectposx = gameObject.transform.position.x;
            objectposy = gameObject.transform.position.y;
            objectposz = gameObject.transform.position.z;

            ShakeCamera(0.005f, 0.1f);
        }
        else
        {
            
        }
    }

    public void ShakeCamera(float shakePower, float shakeDuration)
    {
        shakeAmount = shakePower;
        shakeTimer = shakeDuration;
    }
}