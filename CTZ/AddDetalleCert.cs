using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddDetalleCert : MaterialForm
    {
        private int IDU, IDROL;
        private string CERT;
        private Functions ft = new Functions();

        private void AddDetalleCert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'documentacionDataSet.Uso' table. You can move, or remove it, as needed.
            this.usoTableAdapter.Fill(this.documentacionDataSet.Uso);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string sql = "declare @idc as int;" +
                        "declare @idu as int = " + uso.SelectedValue + "; " +
                        "set @idc = (select idcertificado from certificado where certificado = '" + certificado.Text + "');" +
                         "           declare @act as int;" +
                         " declare @actual bit; " +
                         " set @actual = (select top 1 actual from detalleCert where idCert = @idc order by FechaRegistro desc) " +
                          "          set @act = (select count(idCert) from detalleCert where iduso = @idu and idCert = @idc );" +
                           "         if @act < 1 " +
                            "        begin " +
                             "           Insert into detallecert(IdUso, IdCert, FechaRegistro, idusuario, actual) VALUES(@idu, @idc, SYSDATETIME(), " + IDU + ", @actual) " +

                            "select " +
                             "   case " +
                              "      when @act<0 then 'Agregado' " +

                               " end as 'added' " +
                        "end " +
                        "else " +
                        "begin " +
                         "   select " +
                         "   case " +

                          "  when count(iddetallecert )>= 1 then 'No agregado' " +

                           " end as 'added' " +

                           " from detalleCert where iduso = @idu and idCert = @idc " +
                        "end"

                        ;
            SqlDataReader read = ft.GetRead(sql);
            //Como diferenciar cuando a pesar de retornar valores la consulta es falsa porque regresa cuantos
            //certificados ya se encuentran con esas caracteristicas
            if (uso.SelectedIndex != -1 && read.GetValue(0).ToString() != "Agregado")
            {
                MessageBox.Show("Es probable que el certificado ya cuente con esta variante");
            }
            else
            {
                MessageBox.Show("Agregado.");
            }
        }

        private void uso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = uso.SelectedValue.ToString();
        }

        public AddDetalleCert(int idu, int idrol, string cert)
        {
            /*Aqui se puede agregar un uso al certificado,Los certificados pueden tener más de un uso
             */
            InitializeComponent();
            IDU = idu; IDROL = idrol; CERT = cert;
            certificado.Text = CERT;
            certificado.Enabled = false;
        }
    }
}