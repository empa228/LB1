namespace Lb1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "Список пользователей:";

                foreach (User u in users)
                {
                    labelInfAboutUsers.Text += ($"{u.Id}.{u.Name} - {u.Age}\n");
                }
            }
        }
    }
}
