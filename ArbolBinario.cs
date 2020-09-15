using System;
using System.Collections.Generic;

namespace CTEDYA_TP2
{
	public class ArbolBinario<T>
	{
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
		}
		
		public void preorden() {
//			ArbolBinario<T> nodo;
//			if(nodo.getHijoIzquierdo() != null)
//			{
//				hijoIzquierdo.preorden();
//			}
//			if(nodo.getHijoDerecho() != null)
//			{
//				hijoDerecho.preorden();
//			}
		}
		
		public void postorden() {
		}
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			cola.encolar(this);
			while(!cola.esVacia())
			{
				ArbolBinario<T> nodo = cola.desencolar();
				Console.Write(nodo.getDatoRaiz()+" ");
				if(nodo.getHijoIzquierdo() != null)
				{
					cola.encolar(nodo.getHijoIzquierdo());
				}
				if(nodo.getHijoDerecho() != null)
				{
					cola.encolar(nodo.getHijoDerecho());
				}
			}
		}
	
		public int contarHojas() {
			int hojas=0;
			/*si hijo izq e hijo der son nulos retorna el valor 1*/
			if(getHijoIzquierdo() == null && getHijoDerecho() == null)
			{
				return 1;
			}
			/*si hijo izq no es nulo se le suma 1 a la variable hojas y se vuelve a llamar a si misma*/
			if(getHijoIzquierdo() != null)
			{
				hojas += getHijoIzquierdo().contarHojas();
			}
			/*si hijo der no es nulo se le suma 1 a la variable hojas y se vuelve a llamar a si misma*/
			if(getHijoDerecho() != null)
			{
				hojas += getHijoDerecho().contarHojas();
			}
			/*retorna el valor de total de hojas, si es mas de una*/
			return hojas;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
