namespace TestWinForm_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Person person=new Person();
            person.Name =txtName.Text;
            person.Surname=txtSurName.Text;
            person.Familyname=txtFamilyName.Text;
            person.Egn=txtEGN.Text;
            person.Poll = Pol.Text;
            person.Work=txtWork.Text;


            MessageBox.Show($"��� ��������� {person.Name},{person.Surname},{person.Familyname} � ��� {person.Egn},{person.Poll}, �������: {person.Work}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEGN_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}