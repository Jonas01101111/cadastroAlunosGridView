using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroAlunosGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            gvAlunos.Rows.Add(tbNome.Text, tbCurso.Text);

            tbNome.Clear();
            tbCurso.Clear();

            MessageBox.Show("Aluno incluído com sucesso!!!", "Inclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lbTotal.Text = gvAlunos.RowCount.ToString();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (gvAlunos.RowCount > 0)
            {
                gvAlunos.Rows.RemoveAt(gvAlunos.CurrentRow.Index);
                MessageBox.Show("Aluno excluído com sucesso!!!", "Exclusão",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbTotal.Text = gvAlunos.RowCount.ToString();
            }
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gvAlunos.CurrentRow.Cells[0].Value= tbAlterar.Text;
            MessageBox.Show("Nome alterado com sucesso!!!", "Alteração",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btExcluirTudo_Click(object sender, EventArgs e)
        {
            if (gvAlunos.RowCount > 0) 
            {
                gvAlunos.Rows.Clear();
            }
            lbTotal.Text=gvAlunos.RowCount.ToString();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gvAlunos.RowCount > 0)
            tbAlterar.Text = gvAlunos.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
