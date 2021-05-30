using UnityEngine;

public enum guns
{
    idle,
    Handgun,
    shotgun,
}

public struct damage
{
    public float Distance;
    public int Damageamount;
    public Vector2 Spray;
    public Transform Position;
    public Vector3 angle;
    public int Force;
    public Vector3 Origin;


    public damage(int damageamount, int force, Vector2 spray, Transform position, Vector3 origin)
    {
        this.Distance = 40;
        this.Damageamount = damageamount;
        this.Spray = spray;
        this.Position = position;
        this.Force = force;
        this.Origin = origin;
        Vector3 vecdist = (this.Distance * position.forward) + position.position;
        this.angle = (vecdist + new Vector3(Random.Range(0, spray.x), Random.Range(0, spray.y), 0)) - position.position;
        //this.angle = position.position - origin;
    }


}

[System.Serializable]
public struct ammo
{
    public int MaxCartridgeSize;
    public int CartridgeSize;
    public int MaxAmmo;

    public void Reload()
    {
        if (this.MaxAmmo >= MaxCartridgeSize)
        {
            this.MaxAmmo -= this.MaxCartridgeSize-this.CartridgeSize;
            this.CartridgeSize = this.MaxCartridgeSize;
            
        }
        else if (MaxAmmo != 0)
        {
            int bulletsneed = this.MaxCartridgeSize - this.CartridgeSize;
            int rembullets = this.MaxAmmo % this.MaxCartridgeSize;
            if (rembullets > bulletsneed)
            {
                this.CartridgeSize = this.MaxCartridgeSize;
                this.MaxAmmo = rembullets - bulletsneed;
            }
            else
            {
                this.CartridgeSize = rembullets;
                this.MaxAmmo = 0;
            }
        }
    }

    public void AddAmmo(int bullets)
    {
        this.MaxAmmo += bullets;
    }

    public ammo(int maxcartrigesize, int cartridgesize, int maxammo)
    {
        this.MaxCartridgeSize = maxcartrigesize;
        this.CartridgeSize = cartridgesize;
        this.MaxAmmo = maxammo;


    }
}

public class GunManager : MonoBehaviour
{
    [SerializeField] int guncycle;
    float holder;
    public guns guntype;
    [SerializeField] GameObject point;
    public static GunManager Gun;

    [Header("Gun menu")]
    [SerializeField] GameObject handgun;
    [SerializeField] ammo Handgunamo = new ammo(6, 3, 12);
    [SerializeField] GameObject shotgun;
    [SerializeField] Light Flashlight;
    [SerializeField] LayerMask ignoreme;
    [SerializeField] Animator GunAnim;
    //[SerializeField] GameObject Gun;

    GameObject activegunstate;

    public void Awake()
    {
        Gun = this;
    }

    void Start()
    {
        registerinput();
        activegunstate = handgun;
    }

    void registerinput()
    {
        inputmanager.input.pinput.playerkeyboardcontols.weaponwheel.performed += ctx => holder = ctx.ReadValue<float>();
        inputmanager.input.pinput.playerkeyboardcontols.weaponwheel.performed += ctx =>
        {
            guncycle += (int)holder;
            if (guncycle > 1)
            {
                guncycle = 0;
            }

            else if (guncycle < 0)
            {
                guncycle = 1;
            }

            switch (guncycle)
            {
                case 0:
                    guntype = guns.idle;
                    //activegunstate.SetActive(false);
                    //handgun.SetActive(true);
                    activegunstate = null;
                    GunAnim.SetTrigger("idle");
                    GunAnim.ResetTrigger("handgun");
                    break;

                case 1:
                    guntype = guns.Handgun;
                    GunAnim.SetInteger("bullets", Handgunamo.CartridgeSize);
                    //activegunstate.SetActive(false);
                    //handgun.SetActive(true);
                    activegunstate = handgun;
                    GunAnim.SetTrigger("handgun");
                    GunAnim.ResetTrigger("idle");
                    break;
            }
        };

        inputmanager.input.pinput.playerkeyboardcontols.fire.performed += ctx =>
        {
            switch (guntype) 
            {
                case guns.idle:
                break;

                case guns.Handgun:
                GunAnim.SetInteger("bullets", Handgunamo.CartridgeSize);
                
                GunAnim.SetTrigger("fire");
                
                break;
             }
        };

        inputmanager.input.pinput.playerkeyboardcontols.Reload.performed += ctx =>
         {
             switch (guntype)
             {
                 case guns.idle:
                     break;

                 case guns.Handgun:
                     if(Handgunamo.CartridgeSize!= Handgunamo.MaxCartridgeSize && Handgunamo.MaxAmmo > 0)
                     {
                         GunAnim.SetTrigger("reload");
                     }

                     break;
             }
         };

        inputmanager.input.pinput.playerkeyboardcontols.flashlight.performed += ctx =>
        {
            Flashlight.enabled = Flashlight.enabled == true ? false : true;
        };
    }

   public void GunShot()
    {
        switch (guntype)
        {
            case guns.idle:

                break;

            case guns.Handgun:
                {
                    damage dam = new damage(10, 2, Vector2.zero, point.transform, Camera.main.transform.position);
                    RaycastHit hit;
                    Handgunamo.CartridgeSize -= 1;
                    //Debug.DrawLine(dam.Position.position, dam.angle * dam.Distance);

                    if (Physics.Raycast(dam.Origin, dam.angle, out hit, dam.Distance, ~ignoreme))
                    {
                        if (hit.collider.gameObject.layer == 6)
                        {
                            hit.collider.GetComponent<Idamagable<float, Vector3, int>>().takedamage(1, hit.point, 2);
                        }
                    }
                    break;
                }

            case guns.shotgun:
                {

                    for (int i = 0; i < 10; i++)
                    {
                        damage dam = new damage(2, 1, Vector2.one * 5f, point.transform, Camera.main.transform.position);
                        RaycastHit hit;
                        Debug.DrawLine(Camera.main.transform.position, dam.angle * dam.Distance);
                        if (Physics.Raycast(dam.Origin, dam.angle, out hit, dam.Distance, ~ignoreme))
                        {
                            if (hit.collider.gameObject.layer == 6)
                            {
                                hit.collider.GetComponent<Idamagable<float, Vector3, int>>().takedamage(1, transform.position, 2);
                            }
                        }

                    }
                    break;
                }
        }
    }

   
    public void Reload()
    {
        switch (guntype)
        {
            case guns.idle:

                break;

            case guns.Handgun:
                {
                    Handgunamo.Reload();
                    break;
                }

            case guns.shotgun:
                {

                   
                    break;
                }
        }
    }


}
