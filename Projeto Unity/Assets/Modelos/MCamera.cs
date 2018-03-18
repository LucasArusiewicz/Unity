using UnityEngine;

public class MCamera : MonoBehaviour {

    //Limites de camera
    public float limite_Zoom_In, limite_Zoom_Out;

    //Referencia do Transform da MainCamera
    private Transform main_Camera_transform;

    //Valores de entrada dos eixos
    private float input_h, input_v;

    //Variavel do zoom da camera, altera valor Y do Transform
    private float zoom;

    void Start()
    {
        //Cria referencia do transform da MainCamera
        main_Camera_transform = Camera.main.transform;

        //Atribui valores padão de zoom da Camera
        if (limite_Zoom_In == 0)
        {
            limite_Zoom_In = 36f;
        }

        if (limite_Zoom_Out == 0)
        {
            limite_Zoom_Out = 100f;
        }
    }

    void Update()
    {

        //Pega entrada dos eixos
        input_h = Input.GetAxis("Horizontal");
        input_v = Input.GetAxis("Vertical");

        //Reseta valor de zoom
        zoom = 0;

        //Verifica scrollWheel do Mouse e realiza ZoomIn
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && main_Camera_transform.position.y > limite_Zoom_In)
        {
            zoom -= 2f;
        }

        //Verifica scrollWheel do Mouse e realiza ZoomOut
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && main_Camera_transform.position.y < limite_Zoom_Out)
        {
            zoom += 2f;
        }

        //Realiza ajuste na mov da camera
        //AjustaEixo(ref input_h, ref input_v);
    }

    //Apos coletar informacoes no Update() atualiza camera
    private void LateUpdate()
    {
        AtualizaCamera();
    }

    //Atualiza a camera de fato
    private void AtualizaCamera()
    {
        main_Camera_transform.position += new Vector3(input_h, zoom, input_v);
    }
}
