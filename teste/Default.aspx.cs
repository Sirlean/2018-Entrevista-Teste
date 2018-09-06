using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CarregarFilial();
                CarregarDados();  
            }
        }

        private void CarregarDados() 
        {
            clsDados Dados = new clsDados(); 
            Dados.OpenConnection(); 
            string query = "select * from TB_funcionario"; 

            if (ddlFiltro.SelectedIndex > 0 ) 
            {
                query += " where vc_func_filial = '" + ddlFiltro.SelectedValue + "'"; 
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, Dados.Conexao); 
            DataSet funcionarios = new DataSet();
            adapter.Fill(funcionarios); 
            Dados.CloseConnection();
            gvDados.DataSource = funcionarios.Tables[0];
            gvDados.DataBind(); 
        }

        private void CarregarFilial()
        {
            //ddlFiltro.Items.Add("SP");
            //ddlFiltro.Items.Add("RJ");

            clsDados Dados = new clsDados();
            Dados.OpenConnection();
            string query = "select distinct vc_func_filial from TB_funcionario";

            
            SqlDataAdapter adapter = new SqlDataAdapter(query, Dados.Conexao);
            DataSet funcionarios = new DataSet();
            adapter.Fill(funcionarios);
            Dados.CloseConnection();
            ddlFiltro.DataSource = funcionarios.Tables[0];
            ddlFiltro.DataMember = "vc_func_filial";
            ddlFiltro.DataTextField = "vc_func_filial";
            ddlFiltro.DataBind();
            
            ddlFiltro.Items.Insert(0, "Selecionar");
        }



        protected void ddlFiltro_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}