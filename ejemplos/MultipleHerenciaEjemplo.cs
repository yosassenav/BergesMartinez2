
using System;

class Profesor {
private:
  string nombre;
  string materia;
public:
  Profesor(const string &n, const string &m) : nombre( n ), materia( m )
    {}
  const string &getNombre() const
    { return nombre; }
  const string &getMateria() const
    { return materia; }
};


class Investigador {
private:
  string nombre;
  string especialidad;
public:
  Investigador (const string &n, const string &e) : nombre( n ), especialidad( e )
    {}
  const string &getNombre() const
    { return nombre; }
  const string &getEspecialidad() const
    { return especialidad; }
};


class ProfesorUniversitario : public Profesor, public Investigador {
public:
  ProfesorUniversitario(const string &n, const string &e, const string &m)
    : public Profesor( n, m ), public Investigador( n, e )
    {}
};


int main()
{
  ProfesorUniversitario p( "Baltasar", "Máquinas Virtuales", "Tecnología de Objetos" );
  
  cout << p.getNombre() << ','
       << p.getMateria() << ','
       << p.getEspecialidad() << endl
  ;
}


// http://jbgarcia.webs.uvigo.es/asignaturas/TO/cursilloCpp/17_herencia_multiple.html


