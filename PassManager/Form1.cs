using Microsoft.Data.Sqlite;

namespace PassManager;

public partial class F_Main : Form
{
    public F_Main()
    {
        InitializeComponent();
    }

    private void Btn_newUser_Click(object sender, EventArgs e)
    {
        F_NewUser newUser = new();
        newUser.ShowDialog();
    }

    private void Btn_login_Click(object sender, EventArgs e) // TODO make pass manager, linkar perfil com os dados respectivos de cada usuario
    {
        string AppDataDir = $"{System.Environment.GetEnvironmentVariable("LOCALAPPDATA")}/PassManager";

        string connectionString = $"Data Source={AppDataDir}/data.db";
        SqliteConnection connection = new(connectionString);
        connection.Open();

        string query = "SELECT * FROM user WHERE User=@Login AND Password=@Pass";
        SqliteCommand command = new SqliteCommand(query, connection);
        command.Parameters.AddWithValue("@Login", Tb_user.Text);
        command.Parameters.AddWithValue("@Pass", Tb_pass.Text);

        SqliteDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            MessageBox.Show("Login successful");
        }
        else
        {
            MessageBox.Show("Invalid username or password");
        }

        connection.Close();
    }
}
