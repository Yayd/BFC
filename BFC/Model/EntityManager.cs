using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BFC.Model
{
    public class EntityManager
    {
		private readonly ISessionFactory sessionFactory;
		private bool IsCreate = false;

        public EntityManager()
        {
			sessionFactory = CreateSessionFactory(); //Фабрика соединений 
            if (IsCreate)
            {
                ExecuteSQLScript();
            }
        }

        public void SaveOrUpdate<T>(T entity)
        {
			using (var session = sessionFactory.OpenSession())
            {
				using (var transaction = session.BeginTransaction())
                {
					session.SaveOrUpdate(entity);
					transaction.Commit();
                }
            }
        }

		public void Delete<T> (T entity)
        {
			using (var session = sessionFactory.OpenSession())
            {
				using (var transaction = session.BeginTransaction())
                {
					session.Delete(entity);
					transaction.Commit();
                }
            }
        }

		public IList<T> FindAll<T>()
        {
			using (var session = sessionFactory.OpenSession())
            {
				using (var transaction = session.BeginTransaction())
                {
					return session.CreateCriteria(typeof(T)).List<T>();
                }
            }
        }

		public T FindOneById<T>(int id)
        {
			using (var session = sessionFactory.OpenSession())
            {
				using (var transaction = session.BeginTransaction())
                {
					return session.Get<T>(id);
                }
            }
        }

		//Настройка соединения с БД
		private ISessionFactory CreateSessionFactory()
		{
			return Fluently.Configure()
			  .Database(
				SQLiteConfiguration.Standard
				  .UsingFile("BFC.db")
			  )
			  .Mappings(m =>
				m.FluentMappings.AddFromAssemblyOf<BFC.Main>())
			  .ExposeConfiguration(BuildSchema)
			  .BuildSessionFactory();
		}

		private void ExecuteSQLScript()
        {
			Initializer initializer = new Initializer();
			string command = initializer.ReadScript();
			
			using (var session = sessionFactory.OpenSession())
			{
				using (var transaction = session.BeginTransaction())
				{
					var query = session.CreateSQLQuery(command).ExecuteUpdate();
					session.Flush();
					transaction.Commit();
				}
			}
		}

		private void BuildSchema(Configuration config)
		{
			if (!File.Exists("BFC.db"))
            {
				new SchemaExport(config)
					.Create(true, true);
				IsCreate = true;
			}
            else
            {
				new SchemaUpdate(config)
					.Execute(true, true);
			}
		}
	}
}
