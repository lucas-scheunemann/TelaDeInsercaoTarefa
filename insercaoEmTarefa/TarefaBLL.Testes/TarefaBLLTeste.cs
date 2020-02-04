using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InserirTarefa;
using InserirTarefa.BLL;

namespace TelaInsercaoTarefaBLL.Testes
{
    [TestClass]
    public class TarefaBLLTeste
    {
        [TestMethod]
        public void CarregarDadosCmbVersao_QuandoForChamado_RetornarConjuntoDeStrings()
        {
            //arrange
            TarefaBLL tarefaBll = new TarefaBLL();
            string[] esperado = new string[2] { "2.1.6.6", "2.1.5.20" };

            //act
            string[] atual = new string[2];
            atual = tarefaBll.CarregarDadosCmbVersao();

            //assert
            Assert.AreEqual(esperado.ToString(), atual.ToString());
        }
        [TestMethod]
        public void CarregarDadosCmbMotivo_QuandoForChamado_RetornarConjuntoDeStrings()
        {
            //arrange
            TarefaBLL tarefaBLL = new TarefaBLL();
            string[] esperado = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };


            //act
            string[] atual = new string[10];
            atual = tarefaBLL.CarregarDadosCmbMotivo();
           

            //assert
            Assert.AreEqual(esperado.ToString(), atual.ToString());
        }

        [TestMethod]
        public void CarregarDadosCmbArea_QuandoForChamado_RetornarCojuntoDeStrings()
        {
            //arrange
            TarefaBLL tarefaBLL = new TarefaBLL();
            string[] esperado = new string[5] { "0", "10", "20", "30", "40" };
            //act
            string[] atual = new string[5];
            atual = tarefaBLL.CarregarDadosCmbArea();

            //assert
            Assert.AreEqual(esperado.ToString(), atual.ToString()); 
        }
        [TestMethod]
        public void CarregarDadosCmbTime_QuandoForChamado_RetornarConjuntoDeStrings()
        {
            //arrange
            TarefaBLL tarefaBLL = new TarefaBLL();
            string[] esperado = new string[3] { "4", "5", "6" };
            //act
            string[] atual = new string[3];
            atual = tarefaBLL.CarregarDadosCmbTime();


            //assert
            Assert.AreEqual(esperado.ToString(), atual.ToString());
        }
    }
}
