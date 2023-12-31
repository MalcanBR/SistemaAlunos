﻿using FirebirdSql.Data.FirebirdClient;
using SistemaAlunos.Factory;
using SistemaAlunos.Models.Domain;


namespace SistemaAlunos.Repository
{
    public  abstract class RepositorioAbstrato
    {

        protected readonly FbConnection conn;

        public RepositorioAbstrato()
        {
            conn = ConexaoComBD.GetConexao();
        }

        public abstract void Add(Aluno aluno);
        public abstract void Update(Aluno aluno);
        public abstract void Remove(int matricula);
        public abstract IEnumerable<Aluno> Get(int matricula);
        public abstract IEnumerable<Aluno> GetAll();
    }
}
