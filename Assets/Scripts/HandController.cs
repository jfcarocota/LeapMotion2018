using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{

    [SerializeField]
    Color color;
    [SerializeField, Range(0.1f, 100f)]
    float rayLenght;
    [SerializeField]
    LayerMask selectableLayer;

    [SerializeField]
    List<FingerController> fingers;

    RaycastHit hit;

    [SerializeField]
    Transform reticleTrs;

    Vector3 reticleOrgScale;

    float orgTipPosZ;
    Cubo cubo;

    ItemInfo itemInfo;

    private void Awake()
    {
        reticleOrgScale = reticleTrs.localScale;
        orgTipPosZ = fingers[1].Tip.position.z;
    }

    private void FixedUpdate()
    {
        if(Physics.Raycast(fingers[1].Tip.position, fingers[1].Tip.forward, out hit, rayLenght, selectableLayer))
        {
            if (hit.collider)
            {
                //hit.transform.position = new Vector3(hit.point.x, hit.point.y, hit.transform.position.z);

                reticleTrs.position = hit.point;
                reticleTrs.localScale = reticleOrgScale * (hit.distance + orgTipPosZ);

                reticleTrs.rotation = Quaternion.FromToRotation(reticleTrs.forward, hit.normal);

                //cubo = hit.collider.GetComponent<Cubo>();

                //cubo.big();
                if (!itemInfo)
                {
                    itemInfo = hit.collider.GetComponent<ItemInfo>();
                    GameManager.instance.SetInfo = itemInfo.TextInfo;
                }
                //GameManager.instance.IsActive = !GameManager.instance.IsActive;
                if (!GameManager.instance.IsActive)
                {
                    GameManager.instance.IsActive = true;
                }
            }
        }
        else
        {
            if (GameManager.instance.IsActive)
            {
                GameManager.instance.IsActive = false;
            }
            if (itemInfo)
            {
                itemInfo = null;
                GameManager.instance.SetInfo = "";
            }
       
            reticleTrs.rotation = Quaternion.Euler(Vector3.zero);
            reticleTrs.localScale = reticleOrgScale;
            reticleTrs.position = fingers[1].Tip.position;
            reticleTrs.position = new Vector3(fingers[1].Tip.position.x, 
                fingers[1].Tip.position.y, orgTipPosZ);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawRay(fingers[1].Tip.position, fingers[1].Tip.forward * rayLenght);
    }
}
