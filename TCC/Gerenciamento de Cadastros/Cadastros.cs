using Dados;
using DadosBD;
using DadosBD.Localizacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Gerenciamento_de_Cadastros;

namespace TCC
{
    public partial class Cadastros : Form
    {
        string objTab = "";

        public int b = 0;

        public Cadastros(string tab)
        {
            InitializeComponent();
            objTab = tab;

            Funcao_BD fun = new Funcao_BD();
            List<Funcao_Dados> fund = new List<Funcao_Dados>();
            Funcao_Dados f = new Funcao_Dados();
            f.id_funcao = 0;
            //f.desc_funcao = "";
            fund = fun.Select();
            fund.Insert(0, f);
            cbFuncao.DisplayMember = "desc_funcao";
            cbFuncao.ValueMember = "id_funcao";
            cbFuncao.DataSource = fund;
            //cbFuncao.SelectionStart = 0;

            DadosBD.AgenciaBancaria.AgBanq agen = new DadosBD.AgenciaBancaria.AgBanq();
            List<Dados.Agencia_Bancaria.BancoDados> agd = new List<Dados.Agencia_Bancaria.BancoDados>();
            Dados.Agencia_Bancaria.BancoDados a = new Dados.Agencia_Bancaria.BancoDados();
            a.id_banco = 0;
            //a.desc_banco = "";
            agd = agen.Select();
            agd.Insert(0, a);

            cbABancariaFunc.DisplayMember = "desc_banco";
            cbABancariaFunc.ValueMember = "id_banco";
            cbABancariaFunc.DataSource = agd;
            //cbABancariaFunc.SelectionStart = 0;

            DadosBD.Func_BD func = new Func_BD();
            List<Dados.Func_Dados> fd = new List<Func_Dados>();
            Dados.Func_Dados fu = new Func_Dados();
            fu.fun_id = 0;
            //fu.Nome = "";
            fd = func.Todos();
            fd.Insert(0, fu);
            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "fun_id";
            cbFuncionario.DataSource = fd;
            //cbFuncionario.SelectionStart = 0;

            DadosBD.Setor_BD setor = new Setor_BD();
            List<Dados.Setor_Dados> sd = new List<Setor_Dados>();
            Dados.Setor_Dados s = new Setor_Dados();
            s.id_setor = 0;
            s.setor_produto = "";
            s.sub_setor_produto = "";
            s.tipo = "";
            sd = setor.Select();
            sd.Insert(0, s);

            cbSetor.DisplayMember = "setor_produto";
            cbSetor.ValueMember = "id_setor";
            cbSetor.DataSource = sd;
            //cbSetor.SelectionStart = 0;

            DadosBD.Produto.Fabricante_BD fab = new DadosBD.Produto.Fabricante_BD();
            List<Dados.Fabricante_Dados> fbd = new List<Fabricante_Dados>();
            Dados.Fabricante_Dados fb = new Fabricante_Dados();
            fb.id_fabricante = 0;
            fb.nome_fabricante = "";
            fb.marca_fabricante = "";
            fbd = fab.Select();
            fbd.Insert(0,fb);

            cbFabricante.DisplayMember = "nome_fabricante";
            cbFabricante.ValueMember = "id_fabricante";
            cbFabricante.DataSource = fbd;
            //cbFabricante.SelectionStart = 0;

            cbMarca.DisplayMember = "marca_fabricante";
            //cbMarca.ValueMember = "marca_fabricante";
            cbMarca.DataSource = fbd;
            //cbMarca.SelectionStart = 0;
            
        }
        private void btnGerFUNCI_Click(object sender, EventArgs e)
        {
            Funcionarios_Cad fun = new Funcionarios_Cad(this);
            fun.ShowDialog();
        }
        private void btnGerFOR_Click(object sender, EventArgs e)
        {
            Fornecedores_Cad forn = new Fornecedores_Cad(this);
            forn.ShowDialog();
        }
        private void btnGerCLI_Click(object sender, EventArgs e)
        {
            Clientes_Cad cli = new Clientes_Cad(this);
            cli.ShowDialog();
        }
        private void btnGerProd_Click(object sender, EventArgs e)
        {
            Produtos_Cad pro = new Produtos_Cad(this);
            pro.ShowDialog();
        }
        private void btnGerUser_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios(this);
            u.ShowDialog();
        }
        private void btnGerFuncao_Click(object sender, EventArgs e)
        {
            Funcoes f = new Funcoes(this);
            f.ShowDialog();
        }
        private void btnGerFabri_Click(object sender, EventArgs e)
        {
            Fabricantes f = new Fabricantes(this);
            f.ShowDialog();
        }
        private void btnGerSetores_Click(object sender, EventArgs e)
        {
            Setores s = new Setores(this);
            s.ShowDialog();
        }
        private void btnGerLoc_Click(object sender, EventArgs e)
        {
            Localizacoes l = new Localizacoes(this);
            l.ShowDialog();

        }
        private void btnGerFP_Click(object sender, EventArgs e)
        {
            FormasdePagamento f = new FormasdePagamento(this);
            f.ShowDialog();
        }
        private void btnGerVei_Click(object sender, EventArgs e)
        {
            Veiculos v = new Veiculos(this);
            v.ShowDialog();
        }
        private void btnGerAB_Click(object sender, EventArgs e)
        {
            Agencias_Bancarias a = new Agencias_Bancarias(this);
            a.ShowDialog();
        }
// métodos para a alteração de informações:
        int idAlterar = 0; // <-- variavel para alteração
// alteração de informações do funcionario
        public void alterar_Func(int id,int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Func_BD d = new DadosBD.Func_BD();
                Func_Dados funcionario = d.BviaCod(id);
                lblCod_FUNC.Text = id.ToString();
                funcionario.fun_id = id;
                txtNomeFuncionario.Text = funcionario.Nome;
                cbFuncao.SelectedIndex = funcionario.id_funcao;
                mtbDateNasci.Text = funcionario.data_nasc.ToString();
                mtbTelefoneFunc.Text = funcionario.telefone;
                txtEmailFunc.Text = funcionario.email;
                cbTipoPessoaFunc.Text = funcionario.t_pessoa;
                txtRSocialFunc.Text = funcionario.razao_social;
                mtbRGFunc.Text = funcionario.RG;
                mtbCPFfunc.Text = funcionario.CPf;
                mtbCEPfunc.Text = funcionario.cep;
                cbUFfunc.Text = funcionario.uf;
                txtEndFunc.Text = funcionario.endereco;
                txtBairroFunc.Text = funcionario.bairro;
                txtCidadeFunc.Text = funcionario.cidade;
                txtCNHfunc.Text = funcionario.cnh;
                txtCATfunc.Text = funcionario.cat;
                txtCTPSfunc.Text = funcionario.ctps;
                txtContaFunc.Text = funcionario.conta;
                txtAgenciaFunc.Text = funcionario.agencia;
                cbABancariaFunc.SelectedIndex = funcionario.id_banco;
            }catch(FormatException){
                MessageBox.Show("erro de converção","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch(Exception a){
                MessageBox.Show(" "+a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
// alteração de informações do cliente
        public void alterar_Cli(int id, int lngb)
        {
            try{
            b = lngb;
            idAlterar = id;
            DadosBD.Cliente_BD d = new DadosBD.Cliente_BD();
            Cliente_Dados cliente = d.BviaCod(id);
            lblID_cli.Text = id.ToString();
            txtNome.Text = cliente.Nome;
            mtbDataNascCli.Text = cliente.data_nasc.ToString();
            mtbTelCli.Text = cliente.telefone;
            txtEmailCli.Text = cliente.email;
            mtbRGcli.Text = cliente.RG;
            mtbCPFCli.Text = cliente.CPf;
            txtEndCli.Text = cliente.endereco;
            txtRSocialCli.Text = cliente.razao_social;
            cbTPessoaCli.Text = cliente.t_Pessoa;
            mtbCepCli.Text = cliente.cep;
            txtCidadeCli.Text = cliente.cidade;
            txtBairoCli.Text = cliente.bairro;
            cbUFcli.Text= cliente.uf;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
// alteração de informações do Usuario
        public void alterar_User(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Usuario_BD d = new DadosBD.Usuario_BD();
                Usuario_Dados usuario = d.BviaCod(id);
                lblID_User.Text = id.ToString();
                cbFuncionario.SelectedIndex = usuario.func_id;
                txtLogin.Text = usuario.user_log;
                txtSenha.Text = usuario.user_pwd;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações de função
        public void alterar_Funcao(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Funcao_BD d = new DadosBD.Funcao_BD();
                Funcao_Dados funcao = d.BviaCod(id);
                lblIdFuncao.Text = id.ToString();
                txtFuncao.Text = funcao.desc_funcao;
                txtSalario.Text = funcao.salario.ToString();
                txtCargaHoraria.Text = funcao.carga_horaria;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações do fornecedor
        public void alterar_Forn(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Fornecedor.Fornecedor_BD bd = new DadosBD.Fornecedor.Fornecedor_BD();
                Dados.Fornecedor.Fornecedor_Dados forn = bd.pesquisaViaCod(id);
                lblId_Forn.Text = id.ToString();
                txtNomeForn.Text = forn.Nome;
                mtbDataNascForn.Text = forn.data_nasc;
                mtbTelForn.Text = forn.Telefone;
                txtEmailForn.Text = forn.Email;
                txtSiteForn.Text = forn.site;
                mtbRGforn.Text = forn.RG;
                txtCPFforn.Text = forn.CPF;
                txtEndForn.Text = forn.endereco;
                txtRsocial.Text = forn.razao_social;
                cbTipoPForn.Text = forn.t_pessoa;
                txtCNPJ.Text = forn.cnpj;
                mtbCepForn.Text = forn.cep;
                txtIncriEstadu.Text = forn.ins_Est;
                txtCidade.Text = forn.cidade;
                txtBairro.Text = forn.bairro;
                cbUFforn.Text = forn.uf;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações do produto
        public void alterar_Prod(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Produto_BD bd = new DadosBD.Produto_BD();
                Dados.Produto_Dados prod = bd.BviaCod(id);
                lblId_Prod.Text = id.ToString();
                cbSetor.SelectedIndex = prod.id_setor;
                cbFabricante.SelectedIndex = prod.id_fabricante;
                txtDescProd.Text = prod.descricao;
                cbMarca.Text = prod.Marca;
                txtUnidMed.Text = prod.unidade_med;
                txtPCompra.Text = prod.preco_compra.ToString();
                txtPVenda.Text = prod.preco_venda.ToString();
                txtMLucro.Text = prod.margem_lucro.ToString();
                txtCodBarra.Text = prod.cod_barra.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações do fabricante
        public void alterar_Fabricante(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Produto.Fabricante_BD bd = new DadosBD.Produto.Fabricante_BD();
                Dados.Fabricante_Dados fabri = bd.BviaCod(id);
                lblId_Fabri.Text = id.ToString();
                txtNomeFabri.Text = fabri.nome_fabricante;
                txtMarca.Text = fabri.marca_fabricante;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações do produto
        public void alterar_Setor(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Setor_BD bd = new DadosBD.Setor_BD();
                Dados.Setor_Dados setor = bd.BviaCod(id);
                lblIDsetor.Text = id.ToString();
                txtSetorProd.Text = setor.setor_produto;
                txtSubSetProd.Text = setor.sub_setor_produto;
                txtTipo.Text = setor.tipo;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações de localização
        public void alterar_Loc(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Localizacao.Localizacao_BD bd = new DadosBD.Localizacao.Localizacao_BD();
                Dados.Localização.Localizacao_Dados loc = bd.pesquisaViaCOD(id);
                lblID_loc.Text = id.ToString();
                txtCorredor.Text = loc.corredor;
                txtPartileira.Text = loc.pratileira;
                txtGaveta.Text = loc.gaveta;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações de formas de pagamento
        public void alterar_FormaPg(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.FormaDePagamento.FormaDePagamento_BD bd = new DadosBD.FormaDePagamento.FormaDePagamento_BD();
                Dados.FormaDePagamento.FormaDePagamento_Dados forma = bd.buscarViaCod(id);
                lblID_FP.Text = id.ToString();
                txtFormPag.Text = forma.desc_formade;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações do veiculo
        public void alterar_Veiculo(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.Veiculo.Veiculo_BD bd = new DadosBD.Veiculo.Veiculo_BD();
                Dados.Veiculos.VeiculosDados vei = bd.pesquisaViaCodigo(id);
                lblID_Veic.Text = id.ToString();
                txtPlacaV.Text = vei.placa_veiculo;
                txtDescVeic.Text = vei.desc_veiculo;
                txtAnoFab.Text = vei.ano_veiculo;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// alteração de informações de agencia bancaria
        public void alterar_AB(int id, int lngb)
        {
            try
            {
                b = lngb;
                idAlterar = id;
                DadosBD.AgenciaBancaria.AgBanq bd = new DadosBD.AgenciaBancaria.AgBanq();
                Dados.Agencia_Bancaria.BancoDados ban = bd.pesquisaViaCodigo(id);
                lblID_b.Text = id.ToString();
                txtAgenciaB.Text = ban.desc_banco;
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                Dados.Func_Dados dados = new Dados.Func_Dados();
                DadosBD.Func_BD bd = new DadosBD.Func_BD();
                dados.Nome = txtNomeFuncionario.Text;
                dados.id_funcao = int.Parse(cbFuncao.SelectedIndex.ToString());
                dados.id_banco = int.Parse(cbABancariaFunc.SelectedIndex.ToString());
                dados.Nome = txtNomeFuncionario.Text;
                dados.data_nasc = DateTime.Parse(DateTime.Parse(mtbDateNasci.Text).ToString("yyyy/MM/dd , HH:mm:ss"));
                dados.telefone = mtbTelefoneFunc.Text;
                dados.email = txtEmailFunc.Text;
                dados.t_pessoa = cbTipoPessoaFunc.Text;
                dados.razao_social = txtRSocialFunc.Text;
                dados.RG = mtbRGFunc.Text;
                dados.CPf = mtbCPFfunc.Text;
                dados.endereco = txtEndFunc.Text;
                dados.cep = mtbCEPfunc.Text;
                dados.cnh = txtCNHfunc.Text;
                dados.cat = txtCATfunc.Text;
                dados.ctps = txtCTPSfunc.Text;
                dados.bairro = txtBairroFunc.Text;
                dados.cidade = txtCidadeFunc.Text;
                dados.uf = cbUFfunc.Text;
                dados.agencia = txtAgenciaFunc.Text;
                dados.conta = txtContaFunc.Text;

//quando no from dos Funcionarios o botão de alteração é clicado por parametro é passado um numero neste caso o 1 e o código do funcionario, atravez do selectRows[0].cells[0].Value, armazenando o código do funcionario em uma label não visivel,localizado em cada aba no canto inferior esquerdo, para o form anterior, no caso o de cadastros na aba funcionario, para então ser executado o método de select pelo codigo e após, a populção dos campos de acordo com o código do funcionario.
//esta lógica foi utilizada pra todos os métodos de alteração mudando apenas o valor que recebe por parametro para que o programa saiba ezatamante o que devera ser alterado, ja que todos os cadastros ficam em um mesmos form que possui uma aba para cada um deles.            
                
                if (b == 1)  
                {
                    dados.fun_id = Convert.ToInt32(lblCod_FUNC.Text);
                    bd.ALT(dados);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimp_Click(sender, e);
                }
                else
                {

//como o botão salvar é utilizado tando para incerção quanto para alteração de dados, quando o botão é clicado e ele não recebe um valor atravez do form seguinte como acima, o valor da varialvel b é 0 assim o programa sabe que neste caso ele tem que adicionar o registro e não alterar 
                   
                    if (b == 0)
                    {
                        bd.ADD(dados);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimp_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
        private void btnADDUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFuncionario.SelectedIndex.ToString() == null || txtLogin.Text == null || txtSenha.Text == null)
                {
                    MessageBox.Show("Nada de campos nulos ou não selecionados");
                }
                else
                {

                    DadosBD.Usuario_BD bd = new DadosBD.Usuario_BD();
                    Dados.Usuario_Dados d = new Dados.Usuario_Dados();
                    //d.user_id = int.Parse(lblID_User.Text);
                    d.func_id = int.Parse(cbFuncionario.SelectedIndex.ToString());
                    d.user_log = txtLogin.Text;
                    d.user_pwd = txtSenha.Text;

                    if (b == 3)
                    {
                        d.user_id = Convert.ToInt32(lblID_User.Text);
                        bd.ALT(d);
                        b = 0;
                        MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparUser_Click(sender, e);
                    }
                    else
                    {
                        if (b == 0)
                        {
                            bd.ADD(d);
                            MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimparUser_Click(sender, e);
                        }
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDfuncao_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                if (double.TryParse(txtSalario.Text, out a) == false)
                {
                    MessageBox.Show("Digite apenas numeros ex: 0 ou 0,00");
                }
                else
                {
                    DadosBD.Funcao_BD bd = new DadosBD.Funcao_BD();
                    Dados.Funcao_Dados d = new Dados.Funcao_Dados();
                    d.desc_funcao = txtFuncao.Text;
                    d.salario = Double.Parse(txtSalario.Text);
                    d.carga_horaria = txtCargaHoraria.Text;
                    if (b == 4)
                    {
                        d.id_funcao = Convert.ToInt32(lblIdFuncao.Text);
                        bd.ALT(d);
                        b = 0;
                        MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparFuncao_Click(sender, e);
                    }
                    else
                    {
                        if (b == 0)
                        {
                            bd.ADD(d);
                            MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimparFuncao_Click(sender, e);
                        }
                    }

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDfornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.Fornecedor.Fornecedor_BD bd = new DadosBD.Fornecedor.Fornecedor_BD();
                Dados.Fornecedor.Fornecedor_Dados d = new Dados.Fornecedor.Fornecedor_Dados();
                d.Nome = txtNomeForn.Text;
                d.data_nasc = DateTime.Parse(mtbDataNascForn.Text).ToString("yyyy/MM/dd");
                d.Telefone = mtbTelForn.Text;
                d.Email = txtEmailForn.Text;
                d.site = txtSiteForn.Text;
                d.RG = mtbRGforn.Text;
                d.CPF = txtCPFforn.Text;
                d.endereco = txtEndForn.Text;
                d.razao_social = txtRsocial.Text;
                d.t_pessoa = cbTipoPForn.Text;
                d.cnpj = txtCNPJ.Text;
                d.cep = mtbCepForn.Text;
                d.ins_Est = txtIncriEstadu.Text;
                d.cidade = txtCidade.Text;
                d.bairro = txtBairro.Text;
                d.uf = cbUFforn.Text;
                if (b == 5)
                {
                    d.for_id = Convert.ToInt32(lblId_Forn.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparForn_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparForn_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDproduto_Click(object sender, EventArgs e)
        {
            try
            {
                // colocar mascara de preço parque o o valor seja double e não int
                //ERRO AQUI!!!
                //double conparasion;
                //if (double.TryParse(txtPCompra.Text, out conparasion) == false || double.TryParse(txtPVenda.Text, out conparasion) || double.TryParse(txtMLucro.Text, out conparasion))
                //{
                //    MessageBox.Show("Digite Apenas Numero em preço de compra, venda e margem de lucro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                    DadosBD.Produto_BD bd = new DadosBD.Produto_BD();
                    Dados.Produto_Dados d = new Dados.Produto_Dados();
                    d.id_setor = int.Parse(cbSetor.SelectedIndex.ToString());
                    d.id_fabricante = int.Parse(cbFabricante.SelectedIndex.ToString());
                    d.cod_barra = Double.Parse(txtCodBarra.Text);
                    d.descricao = txtDescProd.Text;
                    d.Marca = cbMarca.Text;
                    d.unidade_med = txtUnidMed.Text;
                    d.preco_compra = Double.Parse(txtPCompra.Text);
                    d.preco_venda = Double.Parse(txtPVenda.Text);
                    d.margem_lucro = Double.Parse(txtMLucro.Text);
                    if (b == 6)
                    {
                        d.id_produto = Convert.ToInt32(lblId_Prod.Text);
                        bd.ALT(d);
                        b = 0;
                        MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparProd_Click(sender, e);
                    }
                    else
                    {
                        if (b == 0)
                        {
                            bd.ADD(d);
                            MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimparProd_Click(sender, e);
                        }
                    }
                //}
            }catch(FormatException a){

                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDcliente_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.Cliente_BD bd = new DadosBD.Cliente_BD();
                Dados.Cliente_Dados d = new Dados.Cliente_Dados();
                d.Nome = txtNome.Text;
                d.data_nasc = DateTime.Parse(DateTime.Parse(mtbDataNascCli.Text).ToString("yyyy/MM/dd , HH:mm:ss")); ;
                d.telefone = mtbTelCli.Text;
                d.email = txtEmailCli.Text;
                d.RG = mtbRGcli.Text;
                d.CPf = mtbCPFCli.Text;
                d.endereco = txtEndCli.Text;
                d.razao_social = txtRSocialCli.Text;
                d.t_Pessoa = cbTPessoaCli.Text;
                d.cep = mtbCepCli.Text;
                d.cidade = txtCidadeCli.Text;
                d.bairro = txtBairoCli.Text;
                d.uf = cbUFcli.Text;
                if (b == 2)
                {
                    d.cli_id = Convert.ToInt32(lblID_cli.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparCli_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparCli_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnADDfabricante_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.Produto.Fabricante_BD bd = new DadosBD.Produto.Fabricante_BD();
                Dados.Fabricante_Dados d = new Dados.Fabricante_Dados();
                d.nome_fabricante = txtNomeFabri.Text;
                d.marca_fabricante = txtMarca.Text;
                if (b == 7)
                {
                    d.id_fabricante = Convert.ToInt32(lblId_Fabri.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparFabri_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparFabri_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDsetor_Click(object sender, EventArgs e)
        {
            try
            {

                DadosBD.Setor_BD bd = new DadosBD.Setor_BD();
                Dados.Setor_Dados d = new Dados.Setor_Dados();
                d.setor_produto = txtSetorProd.Text;
                d.sub_setor_produto = txtSubSetProd.Text;
                d.tipo = txtTipo.Text;

                if (b == 8)
                {
                    d.id_setor = Convert.ToInt32(lblIDsetor.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparSetor_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparSetor_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnADDlocalizacao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.Localizacao.Localizacao_BD bd = new DadosBD.Localizacao.Localizacao_BD();
                Dados.Localização.Localizacao_Dados d = new Dados.Localização.Localizacao_Dados();
                d.corredor = txtCorredor.Text;
                d.pratileira = txtPartileira.Text;
                d.gaveta = txtGaveta.Text;

                if (b == 9)
                {
                    d.id_loc = Convert.ToInt32(lblID_loc.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparLoc_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparLoc_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDformaPag_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.FormaDePagamento.FormaDePagamento_BD bd = new DadosBD.FormaDePagamento.FormaDePagamento_BD();
                Dados.FormaDePagamento.FormaDePagamento_Dados d = new Dados.FormaDePagamento.FormaDePagamento_Dados();
                d.desc_formade = txtFormPag.Text;

                if (b == 10)
                {
                    d.id_FormaPag = Convert.ToInt32(lblID_FP.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparFP_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparFP_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.Veiculo.Veiculo_BD bd = new DadosBD.Veiculo.Veiculo_BD();
                Dados.Veiculos.VeiculosDados d = new Dados.Veiculos.VeiculosDados();
                d.desc_veiculo = txtDescVeic.Text;
                d.ano_veiculo = txtAnoFab.Text;
                d.placa_veiculo = txtPlacaV.Text;

                if (b == 11)
                {
                    d.id_veiculo = Convert.ToInt32(lblID_Veic.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparVei_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparVei_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnADDagenciaBancaria_Click(object sender, EventArgs e)
        {
            try
            {
                DadosBD.AgenciaBancaria.AgBanq bd = new DadosBD.AgenciaBancaria.AgBanq();
                Dados.Agencia_Bancaria.BancoDados d = new Dados.Agencia_Bancaria.BancoDados();
                d.desc_banco = txtAgenciaB.Text;

                if (b == 12)
                {
                    d.id_banco = Convert.ToInt32(lblID_b.Text);
                    bd.ALT(d);
                    b = 0;
                    MessageBox.Show("Dados Alterados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparAB_Click(sender, e);
                }
                else
                {
                    if (b == 0)
                    {
                        bd.ADD(d);
                        MessageBox.Show("Dados Cadastrados com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparAB_Click(sender, e);
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
// limpeza dos campos especificos de cada aba do form:
        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = string.Empty;
            cbFuncao.Text = string.Empty;
            cbABancariaFunc.Text = string.Empty;
            txtNomeFuncionario.Text = string.Empty;
            mtbDateNasci.Text = string.Empty;
            mtbTelefoneFunc.Text = string.Empty;
            txtEmailFunc.Text = string.Empty;
            cbTipoPessoaFunc.Text = string.Empty;
            txtRSocialFunc.Text = string.Empty;
            mtbRGFunc.Text = string.Empty;
            mtbCPFfunc.Text = string.Empty;
            txtEndFunc.Text = string.Empty;
            mtbCEPfunc.Text = string.Empty;
            txtCNHfunc.Text = string.Empty;
            txtCATfunc.Text = string.Empty;
            txtCTPSfunc.Text = string.Empty;
            txtBairroFunc.Text = string.Empty;
            txtCidadeFunc.Text = string.Empty;
            cbUFfunc.Text = string.Empty;
            txtAgenciaFunc.Text = string.Empty;
            txtContaFunc.Text = string.Empty;
        }
        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            mtbDataNascCli.Text = string.Empty;
            mtbTelCli.Text = string.Empty;
            txtEmailCli.Text = string.Empty;
            mtbRGcli.Text = string.Empty;
            mtbCPFCli.Text = string.Empty;
            txtEndCli.Text = string.Empty;
            txtRSocialCli.Text = string.Empty;
            cbTPessoaCli.Text = string.Empty;
            mtbCepCli.Text = string.Empty;
            txtCidadeCli.Text = string.Empty;
            txtBairoCli.Text = string.Empty;
            cbUFcli.Text = string.Empty;
        }
        private void btnLimparUser_Click(object sender, EventArgs e)
        {
            lblID_User.Text = string.Empty;
            cbFuncionario.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
        private void btnLimparFuncao_Click(object sender, EventArgs e)
        {
            txtFuncao.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtCargaHoraria.Text = string.Empty;
        }
        private void btnLimparForn_Click(object sender, EventArgs e)
        {
            txtNomeForn.Text = string.Empty;
            mtbDataNascForn.Text = string.Empty;
            mtbTelForn.Text = string.Empty;
            txtEmailForn.Text = string.Empty;
            txtSiteForn.Text = string.Empty;
            mtbRGforn.Text = string.Empty;
            txtCPFforn.Text = string.Empty;
            txtEndForn.Text = string.Empty;
            txtRsocial.Text = string.Empty;
            cbTipoPForn.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            mtbCepForn.Text = string.Empty;
            txtIncriEstadu.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cbUFforn.Text = string.Empty;
        }
        private void btnLimparProd_Click(object sender, EventArgs e)
        {
            cbSetor.Text = string.Empty;
            cbFabricante.Text = string.Empty;
            //string cb = "depoisNoisVe";
            //cb = string.Empty;
            txtDescProd.Text = string.Empty;
            cbMarca.Text = string.Empty;
            txtUnidMed.Text = string.Empty;
            txtPCompra.Text = string.Empty;
            txtPVenda.Text = string.Empty;
            txtMLucro.Text = string.Empty;
            txtCodBarra.Text = string.Empty;
        }
        private void btnLimparFabri_Click(object sender, EventArgs e)
        {
            txtNomeFabri.Text = string.Empty;
            txtMarca.Text = string.Empty;  
        }
        private void btnLimparSetor_Click(object sender, EventArgs e)
        {
            txtSetorProd.Text = string.Empty;
            txtSubSetProd.Text = string.Empty;
            txtTipo.Text = string.Empty;
        }
        private void btnLimparLoc_Click(object sender, EventArgs e)
        {
            txtCorredor.Text = string.Empty;
            txtPartileira.Text = string.Empty;
            txtGaveta.Text = string.Empty;
        }
        private void btnLimparFP_Click(object sender, EventArgs e)
        {
            txtFormPag.Text = string.Empty;
        }
        private void btnLimparVei_Click(object sender, EventArgs e)
        {
            txtPlacaV.Text = string.Empty;
            txtDescVeic.Text = string.Empty;
            txtAnoFab.Text = string.Empty;
        }
        private void btnLimparAB_Click(object sender, EventArgs e)
        {
            txtAgenciaB.Text = string.Empty;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCodBarra.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show("Codigo Lido!");
                }
            }
        }

        private void Cadastros_Activated(object sender, EventArgs e)
        {
            if (objTab == "Agencia")
            {
            tabMenu.SelectedTab = abaBanco;
            }

            if (objTab == "Clientes")
            {
                tabMenu.SelectedTab = abaCliente;
            }

            if (objTab == "Fabricantes")
            {
                tabMenu.SelectedTab = abaFabricante;
            }

            if (objTab == "Fornecedores")
            {
                tabMenu.SelectedTab = abaFornecedor;
            }

            if (objTab == "Funcao")
            {
                tabMenu.SelectedTab = abaFuncao;
            }

            if (objTab == "Func")
            {
                tabMenu.SelectedTab = abaFuncionario;
            }

            if (objTab == "Loc")
            {
                tabMenu.SelectedTab = abaLoc;
            }

            if (objTab == "Forma")
            {
                tabMenu.SelectedTab = abaPag;
            }

            if (objTab == "Prod")
            {
                tabMenu.SelectedTab = abaProdutos;
            }

            if (objTab == "Setor")
            {
                tabMenu.SelectedTab = abaSetor;
            }

            if (objTab == "user")
            {
                tabMenu.SelectedTab = abaUsuario;
            }

            if (objTab == "Veiculos")
            {
                tabMenu.SelectedTab = abaVeiculo;
            }
        }


        private void txtMLucro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //double conversion;
                //if (double.TryParse(txtMLucro.Text, out conversion) == false)
                //{
                 //   MessageBox.Show("Apenas numeros na margem de lucro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    if (txtMLucro.Text != "" && txtPCompra.Text != "")
                    {
                        txtPVenda.Text = (Double.Parse(txtPCompra.Text) + ((Double.Parse(txtPCompra.Text) * (Double.Parse(txtMLucro.Text) / 100)))).ToString();
                    }
                //}
            }
            catch (FormatException)
            {
                MessageBox.Show("erro de converção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPVenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
