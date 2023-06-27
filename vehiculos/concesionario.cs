using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    class concesionario
    {
        private coche[] _coches;
        private int _limite;
        private Random _rnd;
        private int _numcoches;

        public concesionario(int limite)
        {
            this._coches = new coche[limite];
            _limite = limite;
            _numcoches = 0;
            _rnd = new Random();

        }

        public coche sortearCoche() {
           
            return(_coches[_rnd.Next(_numcoches)]);

        }
        public void mostrarCoche()
        {
            coche cGanado = sortearCoche();
            System.Console.WriteLine(cGanado.ToString());
            
        }

        public void aniadircoche(coche c)
    {
        if (c != null && _numcoches < _coches.Length)
        {
            _coches[_numcoches] = c;
            _numcoches++;
        }
    }

    public void mostrarcoches()
    {
        for (int i = 0; i < _numcoches; i++)
        {
            Console.WriteLine(_coches[i].ToString());
        }
    }

    public void vaciarcoches()
    {
        this._coches = new coche[_limite];
        _numcoches = 0;
    }

    public void eliminarcoche(coche c)
    {
        if (c != null && _numcoches != 0)
        {

            int posicion = -1;
            for (int i = 0; i < _numcoches; i++)
            {
                if (c.id == _coches[i].id)
                {
                    posicion = i;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No existe el coche");
            }
            else
            {
                _coches[posicion] = null;

                for (int i = posicion; i < _numcoches; i++)
                {
                    _coches[i] = _coches[i + 1];

                }
                _coches[_numcoches]=null;
                _numcoches--;

            }

        }
    }
    public coche buscarCoche(int id)
    {
        if (_numcoches != 0)
        {

            int posicion = -1;
            for (int i = 0; i < _numcoches; i++)
            {
                if (id == _coches[i].id)
                {
                    posicion = i;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No existe el coche");
                return null;
            }
            else
            {
                return (_coches[posicion]);


            }

        }
        else {//No hay coches en el concesionario

            return null;
            
        }
    }

}

}

