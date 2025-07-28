using UnityEngine;

public class VacaMovimiento : MonoBehaviour
{
    public Transform areaMovimiento;
    public float velocidad = 1f;
    private Vector2 destino;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NuevoDestino();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);


        Debug.Log(transform.position + " | " + destino);

        if (Vector2.Distance(transform.position, destino)<0.1f){
            NuevoDestino();
        } 
    }

    void NuevoDestino(){
        Vector2 centro = areaMovimiento.position;
        Vector2 tama�o = areaMovimiento.localScale;

        float x = Random.Range(centro.x - tama�o.x / 2f, centro.x + tama�o.x / 2f);
        float y = Random.Range(centro.y - tama�o.y / 2f, centro.y + tama�o.y / 2f);

        destino = new Vector2(x, y);

   }
}
