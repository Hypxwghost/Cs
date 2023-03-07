using Microsoft.Data.Sqlite;

namespace PassManager
{
    public partial class F_NewUser : Form
    {
        public F_NewUser()
        {
            InitializeComponent();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            string UserName = Tb_name.Text;
            string Login = Tb_login.Text;
            string Pass = Tb_password.Text;
            string ConfirmPass = Tb_confirmPassword.Text;
            string command;
            string AppDataDir = $"{System.Environment.GetEnvironmentVariable("LOCALAPPDATA")}/PassManager";

            if (Pass != ConfirmPass)
            {
                MessageBox.Show("Password does not match!");
            }
            else
            {
                if (!Directory.Exists($"{AppDataDir}")) { Directory.CreateDirectory($"{AppDataDir}"); } // Creates App folder

                using var conn = new SqliteConnection($"Data Source = {AppDataDir}/data.db"); // Create and Start a connection to db
                conn.Open();

                // TODO criptografar senha
                command = "CREATE TABLE IF NOT EXISTS user (Name TEXT NOT NULL,User TEXT NOT NULL UNIQUE, Password TEXT NOT NULL );";
                SqliteCommand cmd = new(command, conn);
                cmd.ExecuteNonQuery();

                try // Try to create user, if already exists, return error message, else, creates user
                {
                    command = $"INSERT into user (Name,User,Password) values ('{UserName}', '{Login}', '{Pass}')";
                    cmd = new(command, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User created successfully!");
                    this.Close(); // auto closes form
                }
                catch (SqliteException Error)
                {
                    if (Error.SqliteErrorCode == 19) // Error code for 'Unique' SQL tag, triggered when 'Login' already exists in db
                    {
                        MessageBox.Show("User already exists");
                    }
                    else
                    {
                        MessageBox.Show(Error.ToString());
                    }
                }
                conn.Close();
            }
        }
    }
}