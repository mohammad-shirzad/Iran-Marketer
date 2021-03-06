﻿using System;
using System.Threading.Tasks;
using Bargozideh.Framework.Repository.Extensions;
using Bargozideh.Framework.UnitOfWork;
using Dapper;

namespace Bargozideh.Framework.Repository
{
    public abstract partial class Repository<TEntity, TPk>
        where TEntity : class
        where TPk : IComparable 
    {
        public virtual int Count(ISession session)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return
                    session.QuerySingleOrDefault<int>(
                        $"SELECT count(*) FROM {Sql.Table<TEntity>(session.SqlDialect)}");
            }
            return session.Count<TEntity>();
        }
        public virtual int Count(IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return
                    uow.Connection.QuerySingleOrDefault<int>(
                        $"SELECT count(*) FROM {Sql.Table<TEntity>(uow.SqlDialect)}", uow.Transaction);
            }
            return uow.Count<TEntity>();
        }

        public virtual int Count<TSesssion>() where TSesssion : class, ISession
        {
            using (var uow = Factory.Create<IUnitOfWork ,TSesssion>())
            {
                return Count(uow);
            }
        }

        public virtual int Count()
        {
            using (var uow = Factory.Create<IUnitOfWork, ISession>())
            {
                return Count(uow);
            }
        }

        public virtual Task<int> CountAsync(ISession session)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return session.QuerySingleOrDefaultAsync<int>(
                            $"SELECT count(*) FROM {Sql.Table<TEntity>(session.SqlDialect)}");
            }
            return session.CountAsync<TEntity>();
        }

        public virtual Task<int> CountAsync(IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return uow.Connection.QuerySingleOrDefaultAsync<int>(
                            $"SELECT count(*) FROM {Sql.Table<TEntity>(uow.SqlDialect)}");
            }
            return uow.CountAsync<TEntity>();
        }

        public virtual Task<int> CountAsync<TSesssion>() where TSesssion : class, ISession
        {
            using (var uow = Factory.Create<IUnitOfWork, TSesssion>())
            {
                return CountAsync(uow);
            }
        }
    }
}
