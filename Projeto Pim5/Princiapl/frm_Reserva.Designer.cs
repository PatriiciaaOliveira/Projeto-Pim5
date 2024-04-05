using System;
using System.Windows.Forms;

namespace SeuNamespace // Substitua "SeuNamespace" pelo nome real do seu namespace
{
    public partial class frm_Reserva : Form
    {
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txbReserva;
        private System.Windows.Forms.ComboBox cbReserva;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label txbPeríodo;
        private System.Windows.Forms.Label txbProfessor;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private EventHandler btnConfirmar_Click;

        public MonthCalendar MonthCalendar1 { get; private set; }

        public frm_Reserva()
        {
            InitializeComponent();
            btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click); // Assinatura correta do evento
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReserva = new System.Windows.Forms.Label();
            this.cbReserva = new System.Windows.Forms.ComboBox();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txbPeríodo = new System.Windows.Forms.Label();
            this.txbProfessor = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Inglês",
            "Artes",
            "Ciências",
            "L.P.T",
            "Ed. Fisíca"});
            this.comboBox1.Location = new System.Drawing.Point(189, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
            this.comboBox1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Série";
            // 
            // txbReserva
            // 
            this.txbReserva.AutoSize = true;
            this.txbReserva.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReserva.Location = new System.Drawing.Point(80, 245);
            this.txbReserva.Name = "txbReserva";
            this.txbReserva.Size = new System.Drawing.Size(81, 22);
            this.txbReserva.TabIndex = 50;
            this.txbReserva.Text = "Reserva";
            // 
            // cbReserva
            // 
            this.cbReserva.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReserva.FormattingEnabled = true;
            this.cbReserva.Items.AddRange(new object[] {
            "Datashows",
            "TV  com VCR",
            "TV com DVD",
            "Projetor de slides",
            "Microfone",
            "Notebooks",
            "Tablets",
            "Jogos"});
            this.cbReserva.Location = new System.Drawing.Point(189, 240);
            this.cbReserva.Name = "cbReserva";
            this.cbReserva.Size = new System.Drawing.Size(160, 27);
            this.cbReserva.TabIndex = 49;
            // 
            // cbAula
            // 
            this.cbAula.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Inglês",
            "Artes",
            "Ciências",
            "L.P.T",
            "Ed. Fisíca"});
            this.cbAula.Location = new System.Drawing.Point(189, 181);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(160, 27);
            this.cbAula.TabIndex = 48;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(452, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 31);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(322, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 31);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(205, 356);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 31);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
        }
    }
}
