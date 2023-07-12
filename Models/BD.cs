using System.Data.SqlClient;
using Dapper;
namespace TP06;
class BD{
 private static string _connectionString=@"Server=localhost;DataBase=Elecciones2023;Trusted_Connection=True;";

 public static void AgregarCandidato(Candidato can){
    string sql="INSERT INTO Candidato(idPartido,Apellido,Nombre,FechaNacimiento,Foto,Postulacion) VALUES (@cidPartido,@cApellido,@cNombre,@cFoto,@cPostulacion)";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        BD.Execute(sql,new{cidPartido=can.idPartido,cApellido=can.Apellido,cNombre=can.Nombre,cFoto=can.Foto,cPostulacion=can.Postulacion});
    }
 }
 public static void EliminarCandidato(int idCan)
 {
    string sql="DELETE FROM Candidato WHERE idCandidato=@cidCandidato";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        BD.Execute(sql,new{cidCandidato=idCan});
    }
 }
 public static Partido VerInfoPartido(int idPar)
 {
    Partido elegido=null;
    string sql="SELECT * FROM Partido WHERE idPartido=@pidPartido";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        elegido=BD.QueryFirstOrDefault<Partido> (sql,new{pidPartido=idPar});
    }
    return elegido;
 }
  public static Candidato VerInfoCandidato(int idCan)
  {
    Candidato elegido=null;
    string sql="SELECT * FROM Candidato WHERE idCandidato=@cidCandidato";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        elegido=BD.QueryFirstOrDefault<Candidato> (sql,new{cidCandidato=idCan});
    }
    return elegido;
  }
  
   public static List<Partido> ListarPartidos(){
    List<Partido> elegido=null;
    string sql="SELECT * FROM Partido";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        elegido=BD.Query<Partido>(sql).ToList();
    }
    return elegido;
  }
  public static List<Partido> ListarCandidatos(int idPar){
    List<Partido> elegido=null;
    string sql="SELECT * FROM Candidato WHERE idPartido=@cidPartido";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        elegido=BD.Query<Partido>(sql,new{cidPartido=idPar}).ToList();
    }
    return elegido;
  }
}
