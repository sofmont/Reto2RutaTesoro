using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2RutaTesoro
{
    internal class ListaSimple
    {
        public Nodo Inicio { get; private set; }

        public ListaSimple()
        {
            Inicio = null;
        }

        public bool Insertar(int id, string nombre, string pista, int nivelPeligro)
        {
            if (Buscar(id) != null)
                return false; // El ID ya existe

            Nodo nuevo = new Nodo(id, nombre, pista, nivelPeligro);

            if (Inicio == null)
            {
                Inicio = nuevo;
            }
            else
            {
                Nodo actual = Inicio;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            return true;
        }

        public Nodo Buscar(int id)
        {
            Nodo actual = Inicio;
            while (actual != null)
            {
                if (actual.Id == id)
                    return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        public bool Modificar(int id, string nuevoNombre, string nuevaPista, int nuevoNivelPeligro)
        {
            Nodo nodo = Buscar(id);
            if (nodo != null)
            {
                nodo.Nombre = nuevoNombre;
                nodo.Pista = nuevaPista;
                nodo.NivelPeligro = nuevoNivelPeligro;
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            if (Inicio == null)
                return false;

            if (Inicio.Id == id)
            {
                Inicio = Inicio.Siguiente;
                return true;
            }

            Nodo actual = Inicio;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Id == id)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
    }
}
