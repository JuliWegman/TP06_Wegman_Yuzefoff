class Candidato{
public int idCandidato {get;set;}
public int idPartido {get;set;}
public string Apellido {get;set;}
public string Nombre {get;set;}
public DateTime FechaNacimiento {get;set;}
public string Foto {get;set;}
public string Postulacion {get;set;}
public Candidato(int idcandidato,int idpartido,string apellido,string nombre, DateTime fechaNacimiento, string foto, string postulacion){
    idCandidato=idcandidato;
    idPartido=idpartido;
    Apellido=apellido;
    Nombre=nombre;
    Foto=foto;
    FechaNacimiento=fechaNacimiento;
    Postulacion=postulacion;
}
}