using Projeto3;
using Projeto4;
using ReaLTaiizor.Forms;

namespace WinFormsApp1
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void op��esToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            //formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor();
            //formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void cadastroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            //formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void relat�rioDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelatorioAlunos = new FormRelatorioAluno();
            //formRelatorioAlunos.MdiParent = this;
            formRelatorioAlunos.Show();
        }

        private void relat�rioDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelatorioProfessores = new FormRelatorioProfessor();
            //formRelatorioProfessores.MdiParent = this;
            formRelatorioProfessores.Show();
        }

        private void relat�rioDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelatorioCursos = new FormRelatorioCurso();
            //formRelatorioCursos.MdiParent = this;
            formRelatorioCursos.Show();
        }
    }
}