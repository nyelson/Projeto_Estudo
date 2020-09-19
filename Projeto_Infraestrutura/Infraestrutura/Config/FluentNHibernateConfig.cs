using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Projeto_Dominio.Domain.DomainEntities;

namespace Projeto_Infraestrutura.Infraestrutura.Config
{
    public class FluentNHibernateConfig
    {
        private static FluentNHibernateConfig instance;
        string _dbFile = string.Empty;
        bool _overwriteExisting = false;

        public FluentNHibernateConfig()
        {
            Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.UsingFile(_dbFile))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Aluno>())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Turma>())
                    .ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
        }

        public FluentNHibernateConfig(string dbFile, bool overwriteExisting)
        {
            _dbFile = dbFile;
            _overwriteExisting = overwriteExisting;
        }

        public static FluentNHibernateConfig CreateInstance()
        {
            return GetInstance();
        }

        private static FluentNHibernateConfig GetInstance()
        {
            if(instance == null)
            {
                instance = new FluentNHibernateConfig();
            }

            return instance;
        }

        private void BuildSchema(Configuration config)
        {
            if(_overwriteExisting)
            {
                if(File.Exists(_dbFile)) File.Delete(_dbFile);

                var schema = new SchemaExport(config);
                schema.Create(false, true);
            }
        }
    }
}