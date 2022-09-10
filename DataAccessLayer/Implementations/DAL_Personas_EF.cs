using DataAccessLayer.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;

namespace DataAccessLayer.Implementations
{
    public class DAL_Personas_EF : IDAL_Personas
    {
        
        private string sqlConnection = "Server=localhost,14330;Database=Practico3;User Id=sa;Password=Tisj*2022;";

        public Persona AddPersona(Persona x)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                using (Practico4Context db = new Practico4Context())
                {
                    Personas toSave = Personas.ToSave(x);
                    db.Personas.Add(toSave);
                    db.SaveChanges();
                    return Get(x.Documento);
                }

            }
        }
            public Persona Get(string documento)
        {
            using (Practico4Context db = new Practico4Context())
            {
                return db.Personas.Where(X => X.Documento == documento).FirstOrDefault()?.ToEntity();            
            } 


        }

        public List<Persona> GetPersonas()
        {
            using (Practico4Context db = new Practico4Context())
            {

                return db.Personas.Select(x => x.ToEntity()).ToList();
            }
        }
    }

}

