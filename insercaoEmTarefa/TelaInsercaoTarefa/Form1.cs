using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InserirTarefa.BLL;
using Microsoft.VisualBasic;
using TelaInsercaoTarefa.DTO;

namespace TelaInsercaoTarefa
{
    public partial class frmInsertTarefa : Form
    {
        public frmInsertTarefa()
        {
            InitializeComponent();
        }

        private void frmInsertTarefa_Load(object sender, EventArgs e)
        {
            string atendente = Interaction.InputBox("Informe o atendente", "Inserção de atendente", "");
            lblAtendente.Text = atendente.ToString();

            //carregar os Combo Box
            CarregarDados();

            //inserir data Atual
            lblData.Text = DateTime.Now.ToString("d");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //inserir função para gravar na base de dados
            try
            {
                TarefaDTO TAREFA = new TarefaDTO();

                TAREFA.Task = int.Parse(txtTask.Text);
                TAREFA.Cliente = txtCliente.Text;
                TAREFA.Urgencia = int.Parse(txtUrgencia.Text);
                TAREFA.Tempo = int.Parse(txtTempo.Text);
                TAREFA.Versao = cmbVersao.Text;
                TAREFA.Motivo = int.Parse(cmbMotivo.Text);
                TAREFA.TaskOrigem = int.Parse(txtTaskOrigem.Text);
                TAREFA.Data = DateTime.Parse(lblData.Text);
                TAREFA.Obs = txtObs.Text;
                TAREFA.Area = int.Parse(cmbArea.Text);
                TAREFA.Time = int.Parse(cmbTime.Text);
                TAREFA.Atendente = lblAtendente.Text;
                TAREFA.Trello = txtTrelloURL.Text;


                //jogando dados na base
                int x = new TarefaBLL().GravarDados(TAREFA);
                if (x > 0)
                    MessageBox.Show("Inserção concluida com sucesso.");
                
                //limpar campos
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não conseguiu fazer a inserção." + ex.Message);
            }
        }

        private void LimparCampos()
        {
            lblData.Text = DateTime.Now.ToString("d");
            txtCliente.Text = string.Empty;
            txtObs.Text = string.Empty;
            txtTask.Text = string.Empty;
            txtTaskOrigem.Text = string.Empty;
            txtTempo.Text = string.Empty;
            txtTrelloURL.Text = string.Empty;
            txtUrgencia.Text = string.Empty;
            cmbArea.Text = default;
            cmbMotivo.Text = default;
            cmbTime.Text = default;
            cmbVersao.Text = default;
        }

        private void CarregarDadosCmbArea()
        {
            //adiciona todas as opções da tabela area
            
            IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();
            listTarefaDTO = new TarefaBLL().CarregarDadosCmbArea();

            cmbArea.DataSource = listTarefaDTO;

        }
        private void CarregarDadosCmbMotivo()
        {
            //adiciona todas as opções da tabela motivo
            
            IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();
            listTarefaDTO = new TarefaBLL().CarregarDadosCmbMotivo();

            cmbMotivo.DataSource = listTarefaDTO;
        }
        private void CarregarDadosCmbTime()
        {
            //adiciona todas as opções da tabela time
            
            IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();
            listTarefaDTO = new TarefaBLL().CarregarDadosCmbTime();

            cmbTime.DataSource = listTarefaDTO;
        }
        private void CarregarDadosCmbVersao()
        {
            //adiciona todas as opções da tabela versao
            IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();
            listTarefaDTO = new TarefaBLL().CarregarDadosCmbVersao();

            cmbVersao.DataSource = listTarefaDTO;
        }

        private void CarregarDados()
        {
            CarregarDadosCmbArea();
            CarregarDadosCmbMotivo();
            CarregarDadosCmbTime();
            CarregarDadosCmbVersao();
        }
    }
}
