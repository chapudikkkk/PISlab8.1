namespace PISlab8._1
{
    public partial class Form1 : Form, ICourseView
    {
        private CoursePresenter presenter;
        public Form1()
        {
            InitializeComponent();

            presenter = new CoursePresenter(this, new Course());
        }

        void ICourseView.SetEffectiveness(double result)
        {
            label4.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double rating = Convert.ToDouble(textBox1.Text);
                double hours = Convert.ToDouble(textBox2.Text);
                if (hours <= 0 || rating <= 0) { throw new Exception();}
                presenter.LoadCourse(rating, hours);
            }
            catch
            {
                MessageBox.Show("Помилка введення");
            }
        }
    }
}
