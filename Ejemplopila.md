	package TipoPila;
	public class PilaLineal
	{
		 private static final int TAMPILA = 49;
		 private int cima;
		 private TipoDeDato []listaPila;
		 public PilaLineal()
		 {
			 cima = -1; // condición de pila vacía
			 listaPila = new TipoDeDato[TAMPILA];
		 }
		 // operaciones que modifican la pila
		 public void insertar(TipoDeDato elemento){...}
		 public TipoDeDato quitar(){...}
		 public void limpiarPila(){...}
		 //	operación de acceso a la pila
		 public	 TipoDeDato cimaPila(){...}
		 // verificación estado de la pila
		 public boolean pilaVacia(){...}
		 public boolean pilaLlena(){...}
	}
