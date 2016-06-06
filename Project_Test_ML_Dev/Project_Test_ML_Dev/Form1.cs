using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Test_ML_Dev
{
    /// <summary>
    /// Desenvolvido por Giovane Pereira Ramos 
    /// Telefone: (16) 99411-7744
    /// Email: giovane_pr@hotmail.com
    /// 
    /// Destinado a empresa Fcamara
    /// </summary>
    
    public partial class Form1 : Form
    {
        public Form1()
        {
                InitializeComponent();
            this.lblhourdate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            this.salutation(DateTime.Now);
        }
      
  

        private void btnincrement_Click(object sender, EventArgs e)
        {
            DateTime dataField;
            dataField = (DateTime.TryParse(this.lblhourdate.Text, out dataField) ? dataField : DateTime.Now);

            int minutes;
            int.TryParse(this.txtminutes.Text, out minutes);

            if (minutes > 0)
            {
                dataField = dataField.AddMinutes(minutes);
            }
            this.lblhourdate.Text = dataField.ToString("dd/MM/yyyy HH:mm");

            this.salutation(dataField);
        }

        private void btndecrement_Click(object sender, EventArgs e)
        {
            DateTime dataField;
            dataField = (DateTime.TryParse(this.lblhourdate.Text, out dataField) ? dataField : DateTime.Now);

            int minutes;
            int.TryParse(this.txtminutes.Text, out minutes);

            if (minutes > 0)
            {
                dataField = dataField.AddMinutes(-minutes);
            }
            this.lblhourdate.Text = dataField.ToString("dd/MM/yyyy HH:mm");

            this.salutation(dataField);
        }

        private void salutation(DateTime dataField)
        {
            
            int hour = dataField.Hour;
            
            if ((dataField.Hour >= 0) && (dataField.Hour < 12))
                lblgood.Text = ("Good morning");
            else if ((dataField.Hour >=12) && (dataField.Hour < 18)) 
                lblgood.Text = "Good afternoon" ;
            else
                lblgood.Text = "Good evening";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
          
    }

    
      


}

