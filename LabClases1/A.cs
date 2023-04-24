using System;

namespace LabClases1
{
    public class A
    {
        string _NombreInstancia;
        public A()
        {
            _NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            _NombreInstancia = nombre;
        }
        public string NombreInstancia {

            get {

                return _NombreInstancia;

            }

            set {

                _NombreInstancia = value;

            }

        }
        public void mostrarNombre()
        {
            Console.WriteLine(_NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("Se invoco el metodo M1");
        }
        public void M2()
        {
            Console.WriteLine("Se invoco el metodo M2");
        }
        public void M3()
        {
            Console.WriteLine("Se invoco el metodo M3");
        }

    }

}
