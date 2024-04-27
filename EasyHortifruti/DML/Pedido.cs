﻿using System;
using System.ComponentModel;

namespace EasyHortifruti.DML
{
    public class Pedido
    {
        public int ID { get; set; }

        public DateTime dataPedido { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public int IdFonte { get; set; }

        public DateTime DataPrev { get; set; }

        public int PrazoPagamento { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime DataConclusao { get; set; }

        public int IdProduto { get; set; }

        public int QuantidadeProduto { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public double TotalVenda { get; set; }

        public double PercentualLucro { get; set; }

        public string DescrProduto { get; set; }

        public string UnidProduto { get; set; }

        public string QtdeProduto { get; set; }

        public decimal VlCompraProduto { get; set; }

        public decimal MargemLucro { get; set; }

        public decimal TotalItem { get; set; }

        public decimal ValorLucroItem { get; set; }
    }

    public enum StatusPedido
    {
        [Description("Pendente")]
        Pendente = 0,

        [Description("Não Aprovado")]
        NaoAprovado = 1,

        [Description("Aprovado")]
        Aprovado = 2,

        [Description("Em Execução")]
        EmExecucao = 3,

        [Description("Concluído")]
        Concluido = 4,

        [Description("Engregue - Finalizado")]
        Entregue = 5
    }
}