Declarar la clase Pila con elementos de tipo Object. Insertar y extraer de la pila datos
de tipo entero.
## La declaración de la clase:
    package TipoPila;
    public class PilaLineal
      {
	    private static final int TAMPILA = 49;
	    private int cima;
	    private Object [] listaPila;
	 	    // operaciones que añaden o extraen elementos
	    public void insertar(Object elemento)
	    public Object quitar()throws Exception
	    public	 Object cimaPila()throws Exception
    // resto de operaciones
	     }
### El siguiente segmento de código inserta los datos 11, 50 y 22:
    PilaLineal pila = new PilaLineal();
    pila.insertar(new Integer(11));
    pila.insertar(new Integer(50));
    pila.insertar(new Integer(22));
### Para extraer de la pila y asignar el dato a una variable:
    Integer dato;
    dato = (Integer) pila.quitar();
