using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace ViveSR
{
    namespace anipal
    {
        namespace Eye
        {

            public class Practice : MonoBehaviour
            {
                Vector3 GazeOriginCombinedLocalC, GazeDirectionCombinedLocalC;
                Ray ray;
                Ray ray2;
                FocusInfo focusinfo;



                // Use this for initialization
                void Start()
                {

                }

                // Update is called once per frame
                void Update()
                {


                    SRanipal_Eye.GetGazeRay(GazeIndex.COMBINE, out GazeOriginCombinedLocalC, out GazeDirectionCombinedLocalC);

                    Vector3 GazeDirectionCombinedC = Camera.main.transform.TransformDirection(GazeDirectionCombinedLocalC);
                    RaycastHit hit;
                    Physics.Raycast(GazeOriginCombinedLocalC, GazeDirectionCombinedC,out hit);

                    SRanipal_Eye.Focus(GazeIndex.COMBINE, out ray, out focusinfo);


                    if (Input.GetKeyDown(KeyCode.S))
                    {
                        Debug.Log(GazeOriginCombinedLocalC);
                        Debug.Log(GazeDirectionCombinedC);
                        Debug.Log(Camera.main.transform.position);
                        Debug.Log(Camera.main.transform.rotation * Vector3.forward);

                        Debug.Log(focusinfo.point);
                        Debug.Log(hit.point);
                        Debug.Log(ray);
                    }


                }
            }
        }
    }
}
