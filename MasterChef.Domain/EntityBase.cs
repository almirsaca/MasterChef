using MasterChef.Domain.Exceptions;
using MasterChef.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain
{
    public class EntityBase
    {

        public virtual int UsuarioCriacaoId { get; protected set; }
        public virtual DateTime DataCriacao { get; protected set; }
        public virtual int? UsuarioAlteracaoId { get; protected set; }
        public virtual DateTime? DataAlteracao { get; protected set; }
        public virtual bool Ativo { get; protected set; }



        public virtual void AtualizarUsuarioCriacao(int usuarioid)
        {
            if (usuarioid <= 0)
                AddException(nameof(EntityBase), nameof(this.UsuarioCriacaoId), "Id Usuário Criação inválido.");

            this.UsuarioCriacaoId = usuarioid;
        }

        public virtual void AtualizarUsuarioAlteracao(int? usuarioid)
        {
            if (usuarioid <= 0)
                AddException(nameof(EntityBase), nameof(this.UsuarioAlteracaoId), "Id inválido.");
            this.UsuarioAlteracaoId = usuarioid;
        }

        public virtual void AtualizarDataCriacao(DateTime? data = null) => this.DataCriacao = data.HasValue ? data.GetValueOrDefault() : DateTime.Now;

        public virtual void AtualizarDataAlteracao(DateTime? data = null) => this.DataAlteracao = data.HasValue ? data.GetValueOrDefault() : DateTime.Now;
        public virtual void Ativar() => this.Ativo = true;
        public virtual void Inativar() => this.Ativo = false;



        #region Validações

        private readonly DomainSummaryException _domainSummaryException = new DomainSummaryException();

        public void AddException(ExceptionItemInfo exceptionItemInfo)
        {
            Throw.IfIsNull(exceptionItemInfo, nameof(exceptionItemInfo));
            this._domainSummaryException.Add(exceptionItemInfo);
        }

        public void AddException(string model, string reference, string message)
        {
            var exceptionItemInfo = new ExceptionItemInfo(model, reference, message);
            this.AddException(exceptionItemInfo);
        }

        public void Validate()
        {
            if (this.IsValid()) return;
            throw this._domainSummaryException;
        }

        public bool IsValid()
        {
            if (this._domainSummaryException.Exceptions == null) return true;
            if (this._domainSummaryException.Exceptions.Count == 0) return true;
            return false;
        }
        #endregion

    }
}
