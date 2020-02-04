using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaInsercaoTarefa.DAL;
using TelaInsercaoTarefa.DTO;

namespace InserirTarefa.BLL
{
    public class TarefaBLL
    {
        public IList<TarefaDTO> CarregarDadosCmbArea()
        {
            try
            {
                return new TarefaDAL().CarregarDadosCmbArea();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbMotivo()
        {
            try
            {
                return new TarefaDAL().CarregarDadosCmbMotivo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbTime()
        {
            try
            {
                return new TarefaDAL().CarregarDadosCmbTime();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbVersao()
        {
            try
            {
                return new TarefaDAL().CarregarDadosCmbVersao();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public int GravarDados(TarefaDTO TAREFA)
        {
            try
            {
                return new TarefaDAL().InserirDados(TAREFA);
            }
            catch (Exception ex)
            {
                throw ex;
            }
                
        }
    }
}
